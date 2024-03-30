namespace FirstProject
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            button_ = new Button();
            buttonPower = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            label2 = new Label();
            buttonOpeningParenthesis = new Button();
            buttonClosingParenthesis = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 55);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 144);
            button1.Name = "button1";
            button1.Size = new Size(48, 48);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 144);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(120, 144);
            button3.Name = "button3";
            button3.Size = new Size(48, 48);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(48, 48);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(66, 198);
            button5.Name = "button5";
            button5.Size = new Size(48, 48);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(120, 198);
            button6.Name = "button6";
            button6.Size = new Size(48, 48);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 252);
            button7.Name = "button7";
            button7.Size = new Size(48, 48);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(66, 252);
            button8.Name = "button8";
            button8.Size = new Size(48, 48);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(120, 252);
            button9.Name = "button9";
            button9.Size = new Size(48, 48);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(66, 306);
            button0.Name = "button0";
            button0.Size = new Size(48, 48);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button_
            // 
            button_.Location = new Point(120, 306);
            button_.Name = "button_";
            button_.Size = new Size(48, 48);
            button_.TabIndex = 12;
            button_.Text = ",";
            button_.UseVisualStyleBackColor = true;
            button_.Click += button__Click;
            // 
            // buttonPower
            // 
            buttonPower.Location = new Point(12, 306);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(48, 48);
            buttonPower.TabIndex = 13;
            buttonPower.Text = "x^n";
            buttonPower.UseVisualStyleBackColor = true;
            buttonPower.Click += buttonPower_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(174, 144);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(48, 48);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(174, 198);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(48, 48);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(174, 252);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(48, 48);
            buttonMinus.TabIndex = 16;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(174, 306);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(48, 48);
            buttonPlus.TabIndex = 17;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 18;
            label2.Text = "Результат:";
            // 
            // buttonOpeningParenthesis
            // 
            buttonOpeningParenthesis.Location = new Point(12, 90);
            buttonOpeningParenthesis.Name = "buttonOpeningParenthesis";
            buttonOpeningParenthesis.Size = new Size(48, 48);
            buttonOpeningParenthesis.TabIndex = 19;
            buttonOpeningParenthesis.Text = "(";
            buttonOpeningParenthesis.UseVisualStyleBackColor = true;
            buttonOpeningParenthesis.Click += buttonOpeningParenthesis_Click;
            // 
            // buttonClosingParenthesis
            // 
            buttonClosingParenthesis.Location = new Point(66, 90);
            buttonClosingParenthesis.Name = "buttonClosingParenthesis";
            buttonClosingParenthesis.Size = new Size(48, 48);
            buttonClosingParenthesis.TabIndex = 20;
            buttonClosingParenthesis.Text = ")";
            buttonClosingParenthesis.UseVisualStyleBackColor = true;
            buttonClosingParenthesis.Click += buttonClosingParenthesis_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(120, 90);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(48, 48);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "Clr";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(174, 90);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(48, 48);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Del";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 363);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonClosingParenthesis);
            Controls.Add(buttonOpeningParenthesis);
            Controls.Add(label2);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonDivide);
            Controls.Add(buttonPower);
            Controls.Add(button_);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button button_;
        private Button buttonPower;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonPlus;
        private Label label2;
        private Button buttonOpeningParenthesis;
        private Button buttonClosingParenthesis;
        private Button buttonClear;
        private Button buttonDelete;
    }
}
