using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Path1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog sqw = new FolderBrowserDialog();
            DialogResult dialogresult = sqw.ShowDialog();
            FilePath.Text = sqw.SelectedPath;
            DirectoryInfo dir = new DirectoryInfo(sqw.SelectedPath);
            FileInfo[] files = dir.GetFiles("*.dll");
            listBox.ItemsSource = files;
            Path1 = sqw.SelectedPath;
        }

        private void listBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            string dllName = listBox.SelectedItem.ToString();
            string pathToDll = $"{Path1}\\{dllName}";
            var classesOfDll = GetterAttribyts.GetTypes(pathToDll);
            listBoxTypes.ItemsSource = classesOfDll;
        }

        //private void radioButtonFields_Checked(object sender, RoutedEventArgs e)
        //{
        //    int ty = listBoxTypes.SelectedIndex;
        //    string pathToDll = $"{Path1}\\{dllName}";
        //    var classesOfDll = GetterAttribyts.GetTypes(pathToDll);
        //    GetterAttribyts.GetFields();
           
        //}

        //private void listBoxTypes_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{

        //}
    }
}