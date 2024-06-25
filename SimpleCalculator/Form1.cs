using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isOperationPerformed)
            {
                TextBox.Text = "";
                isOperationPerformed = false;
            }
            if (TextBox.Text == "Cannot divide by zero")
            {
                TextBox.Text = "";
            }

            if (button.Text == ".")
            {
                if (!TextBox.Text.Contains("."))
                {
                    TextBox.Text += button.Text;
                }
            }
            else
            {
                if (TextBox.Text == "0")
                {
                    TextBox.Text = button.Text;
                }
                else
                {
                    TextBox.Text += button.Text;
                }
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!string.IsNullOrEmpty(operation) && !isOperationPerformed)
            {
                double currentValue = Double.Parse(TextBox.Text);
                switch (operation)
                {
                    case "+":
                        result += currentValue;
                        break;
                    case "-":
                        result -= currentValue;
                        break;
                    case "*":
                        result *= currentValue;
                        break;
                    case "/":
                        if (currentValue == 0)
                        {
                            TextBox.Text = "Cannot divide by zero";
                            return;
                        }
                        else
                        {
                            result /= currentValue;
                        }
                        break;
                    default:
                        break;
                }

                TextBox.Text = result.ToString();
            }
            else
            {
                
                result = Double.Parse(TextBox.Text);
            }

            operation = button.Text;
            isOperationPerformed = true;
        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 1)
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }
            else
            {
                TextBox.Text = "0";
            }
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            result = 0;
            operation = "";
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                double currentValue = Double.Parse(TextBox.Text);
                double resultValue = 0.0;

                switch (operation)
                {
                    case "+":
                        resultValue = result + currentValue;
                        break;
                    case "-":
                        resultValue = result - currentValue;
                        break;
                    case "*":
                        resultValue = result * currentValue;
                        break;
                    case "/":
                        if (currentValue == 0)
                        {
                            TextBox.Text = "Cannot divide by zero";
                            return;
                        }
                        else
                        {
                            resultValue = result / currentValue;
                        }
                        break;
                    default:
                        break;
                }

                TextBox.Text = resultValue.ToString();
                operation = "";
                isOperationPerformed = false;
            }

        }

        private void ButtonSign_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "-";
            }
            else if (TextBox.Text != "" && TextBox.Text != "-")
            {
                double currentValue = Double.Parse(TextBox.Text);
                currentValue = -currentValue;
                TextBox.Text = currentValue.ToString();
            }
        }
    }
}