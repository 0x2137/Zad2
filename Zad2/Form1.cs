namespace Zad2
{
    public partial class Form1 : Form
    {
        string expression = "";

        public Form1()
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            InitializeComponent();

            stopwatch.Stop();

            if (stopwatch.ElapsedMilliseconds > 1)
            {
                string logMessage = $"Inicjalizacja komponentów trwała zbyt długo: {stopwatch.ElapsedMilliseconds} ms.";
                string logSource = "Zad2"; 

                // za pierwszym razem trzeba skompilować, otworzyć bin i odpalić .exe jako administrator
                if (!System.Diagnostics.EventLog.SourceExists(logSource))
                {
                    System.Diagnostics.EventLog.CreateEventSource(logSource, "Zad2");
                }

                System.Diagnostics.EventLog.WriteEntry(logSource, logMessage, System.Diagnostics.EventLogEntryType.Warning);
            }
        }

        private bool IsOperator(char c) => "+-*/".Contains(c);

        private bool CanAddOperator(string expr)
        {
            if (string.IsNullOrEmpty(expr)) 
                return false;

            char lastChar = expr[^1];
            return !IsOperator(lastChar);
        }

        private bool CanAddDecimalPoint(string expr)
        {
            if (string.IsNullOrEmpty(expr)) 
                return true;

            int lastOperatorIndex = expr.LastIndexOfAny(['+', '-', '*', '/']);
            string lastNumber;

            if (lastOperatorIndex == -1)
            {
                lastNumber = expr;
            }
            else
            {
                lastNumber = expr.Substring(lastOperatorIndex + 1);
            }

            return !lastNumber.Contains(".");
        }

        private void InsertOne(object sender, EventArgs e)
        {
            expression += "1";
            ResultBox.Text = expression;
        }

        private void InsertTwo(object sender, EventArgs e)
        {
            expression += "2";
            ResultBox.Text = expression;
        }

        private void InsertThree(object sender, EventArgs e)
        {
            expression += "3";
            ResultBox.Text = expression;
        }

        private void InsertFour(object sender, EventArgs e)
        {
            expression += "4";
            ResultBox.Text = expression;
        }

        private void InsertFive(object sender, EventArgs e)
        {
            expression += "5";
            ResultBox.Text = expression;
        }

        private void InsertSix(object sender, EventArgs e)
        {
            expression += "6";
            ResultBox.Text = expression;
        }

        private void InsertSeven(object sender, EventArgs e)
        {
            expression += "7";
            ResultBox.Text = expression;
        }

        private void InsertEight(object sender, EventArgs e)
        {
            expression += "8";
            ResultBox.Text = expression;
        }

        private void InsertNine(object sender, EventArgs e)
        {
            expression += "9";
            ResultBox.Text = expression;
        }

        private void InsertZero(object sender, EventArgs e)
        {
            expression += "0";
            ResultBox.Text = expression;
        }

        private void InsertDecimalPoint(object sender, EventArgs e)
        {
            if (CanAddDecimalPoint(expression))
            {
                expression += ".";
                ResultBox.Text = expression;
            }
        }

        private void InsertDivisionSign(object sender, EventArgs e)
        {
            if (CanAddOperator(expression))
            {
                expression += "/";
                ResultBox.Text = expression;
            }
        }

        private void InsertMultiplicationSign(object sender, EventArgs e)
        {
            if (CanAddOperator(expression))
            {
                expression += "*";
                ResultBox.Text = expression;
            }
        }

        private void InsertPlusSign(object sender, EventArgs e)
        {
            if (CanAddOperator(expression))
            {
                expression += "+";
                ResultBox.Text = expression;
            }
        }

        private void InsertMinusSign(object sender, EventArgs e)
        {
            if (CanAddOperator(expression))
            {
                expression += "-";
                ResultBox.Text = expression;
            }
        }

        private void InsertAC(object sender, EventArgs e)
        {
            expression = "";
            ResultBox.Text = expression;
        }

        private void InsertEqualsSign(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(expression) && !IsOperator(expression[^1]))
            {
                double result = Calculate(expression);
                expression = result.ToString();
                ResultBox.Text = expression;
            }
            else
            {
                throw new FormatException("Niepoprawny format wyrażenia");
            }    
        }

        private List<string> Tokenize(string expr)
        {
            var tokens = new List<string>();
            string number = "";

            foreach (char c in expr)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else if (IsOperator(c))
                {
                    if (number != "") 
                        tokens.Add(number);

                    tokens.Add(c.ToString());
                    number = "";
                }
            }
            if (number != "")
                tokens.Add(number);

            return tokens;
        }

        // funkcje zamiany na RPN pisał bot, potrafię, ale on lepiej to zrobił
        private Queue<string> ToRPN(List<string> tokens)
        {
            var output = new Queue<string>();
            var operators = new Stack<string>();
            Dictionary<string, int> precedence = new Dictionary<string, int>
            {{"+", 1}, {"-", 1}, {"*", 2}, {"/", 2}};

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Enqueue(token);
                }
                else if (precedence.ContainsKey(token))
                {
                    while (operators.Count > 0 && precedence.ContainsKey(operators.Peek()) &&
                           precedence[operators.Peek()] >= precedence[token])
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            return output;
        }

        private double EvaluateRPN(Queue<string> rpn)
        {
            var stack = new Stack<double>();

            while (rpn.Count > 0)
            {
                string token = rpn.Dequeue();
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    if (token == "+")
                    {
                        stack.Push(a + b);
                    }
                    else if (token == "-")
                    {
                        stack.Push(a - b);
                    }
                    else if (token == "*")
                    {
                        stack.Push(a * b);
                    }
                    else if (token == "/")
                    {
                        if (b == 0.0)
                        {
                            throw new DivideByZeroException("Dzielenie przez zero!");
                        }
                        stack.Push(a / b);
                    }
                }
            }

            return stack.Pop();
        }

        private double Calculate(string expr)
        {
            try
            {
                var tokens = Tokenize(expr);
                var rpn = ToRPN(tokens);
                return EvaluateRPN(rpn);
            }
            catch (Exception ex)
            {
                ResultBox.Text = "Błąd: " + ex.Message;
                expression = "";
                return 0;
            }
        }
    }
}
