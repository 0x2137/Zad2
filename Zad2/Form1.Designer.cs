﻿namespace Zad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            ResultBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(64, 64);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += InsertOne;
            // 
            // button2
            // 
            button2.Location = new Point(82, 12);
            button2.Name = "button2";
            button2.Size = new Size(64, 64);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += InsertTwo;
            // 
            // button3
            // 
            button3.Location = new Point(152, 12);
            button3.Name = "button3";
            button3.Size = new Size(64, 64);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += InsertThree;
            // 
            // button4
            // 
            button4.Location = new Point(12, 82);
            button4.Name = "button4";
            button4.Size = new Size(64, 64);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += InsertFour;
            // 
            // button5
            // 
            button5.Location = new Point(82, 82);
            button5.Name = "button5";
            button5.Size = new Size(64, 64);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += InsertFive;
            // 
            // button6
            // 
            button6.Location = new Point(152, 82);
            button6.Name = "button6";
            button6.Size = new Size(64, 64);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += InsertSix;
            // 
            // button7
            // 
            button7.Location = new Point(12, 152);
            button7.Name = "button7";
            button7.Size = new Size(64, 64);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InsertSeven;
            // 
            // button8
            // 
            button8.Location = new Point(82, 152);
            button8.Name = "button8";
            button8.Size = new Size(64, 64);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += InsertEight;
            // 
            // button9
            // 
            button9.Location = new Point(152, 152);
            button9.Name = "button9";
            button9.Size = new Size(64, 64);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += InsertNine;
            // 
            // button10
            // 
            button10.Location = new Point(12, 222);
            button10.Name = "button10";
            button10.Size = new Size(64, 64);
            button10.TabIndex = 9;
            button10.Text = "AC";
            button10.UseVisualStyleBackColor = true;
            button10.Click += InsertAC;
            // 
            // button11
            // 
            button11.Location = new Point(82, 222);
            button11.Name = "button11";
            button11.Size = new Size(64, 64);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += InsertZero;
            // 
            // button12
            // 
            button12.Location = new Point(152, 222);
            button12.Name = "button12";
            button12.Size = new Size(64, 64);
            button12.TabIndex = 11;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = true;
            button12.Click += InsertDecimalPoint;
            // 
            // button13
            // 
            button13.Location = new Point(222, 12);
            button13.Name = "button13";
            button13.Size = new Size(64, 64);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += InsertDivisionSign;
            // 
            // button14
            // 
            button14.Location = new Point(222, 82);
            button14.Name = "button14";
            button14.Size = new Size(64, 64);
            button14.TabIndex = 13;
            button14.Text = "x";
            button14.UseVisualStyleBackColor = true;
            button14.Click += InsertMultiplicationSign;
            // 
            // button15
            // 
            button15.Location = new Point(222, 152);
            button15.Name = "button15";
            button15.Size = new Size(64, 64);
            button15.TabIndex = 14;
            button15.Text = "+";
            button15.UseVisualStyleBackColor = true;
            button15.Click += InsertPlusSign;
            // 
            // button16
            // 
            button16.Location = new Point(222, 222);
            button16.Name = "button16";
            button16.Size = new Size(64, 64);
            button16.TabIndex = 15;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += InsertMinusSign;
            // 
            // button17
            // 
            button17.Location = new Point(152, 292);
            button17.Name = "button17";
            button17.Size = new Size(134, 64);
            button17.TabIndex = 16;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += InsertEqualsSign;
            // 
            // ResultBox
            // 
            ResultBox.Enabled = false;
            ResultBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultBox.Location = new Point(292, 12);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(318, 134);
            ResultBox.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 363);
            Controls.Add(ResultBox);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private TextBox ResultBox;
    }
}
