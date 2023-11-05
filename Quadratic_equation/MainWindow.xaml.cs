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


namespace Quadratic_equation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quadratic_equation(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(a.Text, out double A) &&
                double.TryParse(b.Text, out double B) &&
                double.TryParse(c.Text, out double C))
            {
                double d = B * B - 4 * A * C;

                if (d > 0)
                {
                    double x1 = (-B + Math.Sqrt(d)) / (2 * A);
                    double x2 = (-B - Math.Sqrt(d)) / (2 * A);
                    MessageBox.Show($"Дискримінант: d = {d}, розв'язки: x1 = {x1}, x2 = {x2}");               }
                else if (d == 0)
                {
                    double x = -B / (2 * A);
                    MessageBox.Show($"Дискримінант: d = {d}, розв'язок: x = {x}");
                }
                else
                {
                    MessageBox.Show($"Дискримінант: d = {d}, Розв'язків немає."); 
                }

                resultTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Помилка при вводі, введіть правильні значення.");
                resultTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}


