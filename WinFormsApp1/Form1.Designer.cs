namespace WinFormsApp1
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
            button0 = new Button();
            button_divide = new Button();
            button_multiply = new Button();
            button_subtract = new Button();
            button_add = new Button();
            button_equals = new Button();
            input1 = new Label();
            sign = new Label();
            input2 = new Label();
            equalsign = new Label();
            button_delete = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 246);
            button1.Name = "button1";
            button1.Size = new Size(80, 48);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 246);
            button2.Name = "button2";
            button2.Size = new Size(80, 48);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(431, 246);
            button3.Name = "button3";
            button3.Size = new Size(80, 48);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(259, 192);
            button4.Name = "button4";
            button4.Size = new Size(80, 48);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(345, 192);
            button5.Name = "button5";
            button5.Size = new Size(80, 48);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(431, 192);
            button6.Name = "button6";
            button6.Size = new Size(80, 48);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(259, 138);
            button7.Name = "button7";
            button7.Size = new Size(80, 48);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(345, 138);
            button8.Name = "button8";
            button8.Size = new Size(80, 48);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(431, 138);
            button9.Name = "button9";
            button9.Size = new Size(80, 48);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(345, 300);
            button0.Name = "button0";
            button0.Size = new Size(80, 48);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button_divide
            // 
            button_divide.Location = new Point(517, 138);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(80, 48);
            button_divide.TabIndex = 10;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += button11_Click;
            // 
            // button_multiply
            // 
            button_multiply.Location = new Point(517, 192);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(80, 48);
            button_multiply.TabIndex = 11;
            button_multiply.Text = "*";
            button_multiply.UseVisualStyleBackColor = true;
            // 
            // button_subtract
            // 
            button_subtract.Location = new Point(517, 246);
            button_subtract.Name = "button_subtract";
            button_subtract.Size = new Size(80, 48);
            button_subtract.TabIndex = 12;
            button_subtract.Text = "-";
            button_subtract.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            button_add.Location = new Point(517, 300);
            button_add.Name = "button_add";
            button_add.Size = new Size(80, 48);
            button_add.TabIndex = 13;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            // 
            // button_equals
            // 
            button_equals.Location = new Point(431, 300);
            button_equals.Name = "button_equals";
            button_equals.Size = new Size(80, 48);
            button_equals.TabIndex = 14;
            button_equals.Text = "=";
            button_equals.UseVisualStyleBackColor = true;
            // 
            // input1
            // 
            input1.AutoSize = true;
            input1.Location = new Point(259, 106);
            input1.Name = "input1";
            input1.Size = new Size(41, 15);
            input1.TabIndex = 15;
            input1.Text = "input1";
            // 
            // sign
            // 
            sign.AutoSize = true;
            sign.Location = new Point(345, 106);
            sign.Name = "sign";
            sign.Size = new Size(29, 15);
            sign.TabIndex = 16;
            sign.Text = "sign";
            // 
            // input2
            // 
            input2.AutoSize = true;
            input2.Location = new Point(431, 106);
            input2.Name = "input2";
            input2.Size = new Size(41, 15);
            input2.TabIndex = 17;
            input2.Text = "input2";
            input2.Click += label3_Click;
            // 
            // equalsign
            // 
            equalsign.AutoSize = true;
            equalsign.Location = new Point(517, 106);
            equalsign.Name = "equalsign";
            equalsign.Size = new Size(15, 15);
            equalsign.TabIndex = 18;
            equalsign.Text = "=";
            // 
            // button_delete
            // 
            button_delete.Location = new Point(259, 300);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(80, 48);
            button_delete.TabIndex = 19;
            button_delete.Text = "backspace";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(559, 106);
            result.Name = "result";
            result.Size = new Size(36, 15);
            result.TabIndex = 20;
            result.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(button_delete);
            Controls.Add(equalsign);
            Controls.Add(input2);
            Controls.Add(sign);
            Controls.Add(input1);
            Controls.Add(button_equals);
            Controls.Add(button_add);
            Controls.Add(button_subtract);
            Controls.Add(button_multiply);
            Controls.Add(button_divide);
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
        private Button button0;
        private Button button_divide;
        private Button button_multiply;
        private Button button_subtract;
        private Button button_add;
        private Button button_equals;
        private Label input1;
        private Label sign;
        private Label input2;
        private Label equalsign;
        private Button button_delete;
        private Label result;
    }
}
