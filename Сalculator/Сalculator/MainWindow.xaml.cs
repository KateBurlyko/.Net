using System.Windows;
using System.Windows.Controls;

namespace Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate double Calculate(double a, double b);
        Numbers numbers = new Numbers();
        Operations operations = new Operations();
        Calculate calculate;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double[] qwert = new double[1];
            if ((textBox.Text).Contains("="))
            {
                qwert = numbers.Getnumbers(textBox.Text);
                if ((textBox.Text).Contains("+")) calculate = operations.Add;
                if ((textBox.Text).Contains("-")) calculate = operations.Minus;
                if ((textBox.Text).Contains("*")) calculate = operations.Multiply;
                if ((textBox.Text).Contains("/")) calculate = operations.Division;
                textBox.Text = calculate.Invoke(qwert[0], qwert[1]).ToString();
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void drop_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "-";
            calculate = operations.Minus;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "+";
            calculate = operations.Add;
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";
            calculate = operations.Multiply;
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "/";
            calculate = operations.Division;
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            double[] qwert = numbers.Getnumbers(textBox.Text);
            textBox.Text = calculate.Invoke(qwert[0], qwert[1]).ToString();
        }
    }
}