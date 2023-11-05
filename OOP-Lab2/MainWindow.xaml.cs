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

namespace OOP_Lab2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(x.Text, out double X) &&
                double.TryParse(y.Text, out double Y) &&
                double.TryParse(z.Text, out double Z))
            {
                double R = Y + Math.Pow(X - 1, 1.0 / 3.0);
                if (X >= 1 && X + Z != 0 && R >= 0) 
                {
                    double s = Math.Log(X) * Math.Pow(R, 1.0 / 4.0) / (2 * Math.Abs(X + Z));
                    int rounding_numbers = 4;
                    double Result = Math.Round(s, rounding_numbers);
                    MessageBox.Show($"Відповідь: {Result}");
                }
                else
                {
                    MessageBox.Show("Розв'язку немає.");
                }

            }
            else
            {
                MessageBox.Show("Помилка при вводі, введіть правильні значення.");
            }
        }
    }
}
