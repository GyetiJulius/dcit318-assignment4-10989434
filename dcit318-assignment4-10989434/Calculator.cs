using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dcit318_assignment4_10989434
{
    public partial class Calculator : Form
    {
        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private char operation;
        private double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBoxDisplay.Text = input;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand1 = input;
            operation = Convert.ToChar(button.Text);
            input = string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            textBoxDisplay.Text = result.ToString();
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
    }
}
