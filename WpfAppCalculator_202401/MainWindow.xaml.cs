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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TASKS make all those decimal numbers possible
            // 3.14
            // 0.00123
            // 0.5
            // 5
            // 0.35.145 (this is wrong!)
            // 0..123 (this is wrong!)

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
