using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Калькулятор";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetOperand(char op)
        {
            operation = op;
            operand1 = input;
            input = string.Empty;
        }

        private void Calculate()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    // handle division by zero error
                }
            }

            maininput.Text = result.ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            maininput.Text = input;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            SetOperand('-');
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (maininput.Text.Length > 0)
            {
                input = input.Remove(input.Length - 1, 1);
                maininput.Text = input;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            SetOperand('+');
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            SetOperand('*');
        }

        private void divide_Click(object sender, EventArgs e)
        {
            SetOperand('/');
        }

        private void maininput_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void two_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void three_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void four_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void five_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void six_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
        }
    }
}
