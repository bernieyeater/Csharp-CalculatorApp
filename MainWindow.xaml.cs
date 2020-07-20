using System;
using System.Windows;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtBox.Text = number2.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {  //Plus Minus Button
            number1 *= -1;
            txtBox.Text = number1.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtBox.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtBox.Text = number2.ToString();
            }
        }

        private void BtnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Math.Truncate(number1 / 10);
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = Math.Truncate(number2 / 10);
                txtBox.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtBox.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtBox.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtBox.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtBox.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtBox.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtBox.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    txtBox.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtBox.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtBox.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                txtBox.Text = number1.ToString();
            }
            else
            {
                number2 = 0;
                txtBox.Text = number2.ToString();
            }
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            number1 = 0;
            number2 = 0;
            txtBox.Text = "0";

        }
    }
}