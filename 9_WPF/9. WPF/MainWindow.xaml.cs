using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace _9._WPF
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

        private void buttonConvert2List_Click(object sender, RoutedEventArgs e)
        {
            List<string> items = textBox1.Text.Replace("  ", " ").Split(" ").ToList();
            listBoxResult.ItemsSource = items;
        }

        private void buttonFlipPhrase_Click(object sender, RoutedEventArgs e)
        {
            List<string> items = textBox2.Text.Replace("  ", " ").Split(" ").ToList().Reverse<string>().ToList();
            labelResult.Content = items.Aggregate((i, j) => i + " " + j).ToString();
        }
    }
}
