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

namespace Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate string InputNumber(string v);
        Numbers numbers = new Numbers();
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
            if (textBox.Text.Contains("="))
            {
                InputNumber input = new InputNumber(numbers.getNumbers);
                textBox.Text = input.Invoke(textBox.Text = textBox.Text);
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
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "/";
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            InputNumber input = new InputNumber(numbers.getNumbers);
            textBox.Text = input.Invoke(textBox.Text = textBox.Text);
        }
    }
}
