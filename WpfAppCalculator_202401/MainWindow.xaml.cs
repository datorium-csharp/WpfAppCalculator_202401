using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCalculator_202401
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double num1 = 0;
        private double num2 = 0;
        private string operation = String.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                string buttonText = button.Content.ToString();

                if (buttonText == ".")
                {
                    if (Display.Text.Contains("."))
                    {
                        return;
                    }
                }
                else if (buttonText == "C")
                {
                    Display.Text = "0";
                    operation = String.Empty;
                    return;
                }
                else if (buttonText == "+/-")
                {

                }
                else if (buttonText == "+")
                {
                    // store operation
                    operation = buttonText;
                    // store the existing value
                    num1 = Convert.ToDouble(Display.Text);
                    // clear the Display
                    Display.Text = "0";
                    //exit the function
                    return;
                }
                else if (buttonText == "-")
                {
                    // store operation
                    operation = buttonText;
                    // store the existing value
                    num1 = Convert.ToDouble(Display.Text);
                    // clear the Display
                    Display.Text = "0";
                    //exit the function
                    return;
                }
                else if (buttonText == "x")
                {
                    // store operation
                    operation = buttonText;
                    // store the existing value
                    num1 = Convert.ToDouble(Display.Text);
                    // clear the Display
                    Display.Text = "0";
                    //exit the function
                    return;
                }
                else if (buttonText == "/")
                {
                    // store operation
                    operation = buttonText;
                    // store the existing value
                    num1 = Convert.ToDouble(Display.Text);
                    // clear the Display
                    Display.Text = "0";
                    //exit the function
                    return;
                }
                else if (buttonText == "=")
                {
                    double result;
                    // store the current value
                    num2 = Convert.ToDouble(Display.Text);
                    result = num2;

                    // check operation and calculate the result
                    if (operation == "+")
                    {
                        result = num1 + num2;
                    }
                    else if (operation == "-")
                    {
                        result = num1 - num2;
                    }
                    else if (operation == "x")
                    {
                        result = num1 * num2;
                    }
                    else if (operation == "/")
                    {
                        result = num1 / num2;
                    }

                    //show the result in Display
                    Display.Text = result.ToString();
                    operation = String.Empty;
                    //exit the function
                    return;
                }


                if (Display.Text == "0" && buttonText != ".")
                {
                    Display.Text = buttonText;
                }
                else
                {
                    Display.Text += buttonText;
                }       
            }
        }
    }
}
