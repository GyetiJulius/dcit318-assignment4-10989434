namespace dcit318_assignment4_10989434
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEqual;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxDisplay = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEqual = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(12, 15);
            textBoxDisplay.Margin = new Padding(3, 4, 3, 4);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.Size = new Size(258, 27);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button0
            // 
            button0.Location = new Point(12, 363);
            button0.Margin = new Padding(3, 4, 3, 4);
            button0.Name = "button0";
            button0.Size = new Size(60, 75);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 260);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(60, 75);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(78, 260);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(60, 75);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 159);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(60, 75);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 159);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(60, 75);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(78, 159);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(60, 75);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(144, 50);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(60, 75);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 50);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(60, 75);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(78, 50);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(60, 75);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(210, 50);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(60, 75);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(78, 363);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(60, 75);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operator_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(210, 159);
            buttonSubtract.Margin = new Padding(3, 4, 3, 4);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(60, 75);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += operator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(210, 260);
            buttonMultiply.Margin = new Padding(3, 4, 3, 4);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(60, 75);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(144, 363);
            buttonDivide.Margin = new Padding(3, 4, 3, 4);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(60, 75);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(144, 260);
            buttonEqual.Margin = new Padding(3, 4, 3, 4);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(60, 75);
            buttonEqual.TabIndex = 15;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 451);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBoxDisplay);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calculator";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
