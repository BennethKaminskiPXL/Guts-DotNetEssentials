using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        Random randomGenerator1 = new Random();
        Random randomGenerator2 = new Random();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void genButton1_Click(object sender, RoutedEventArgs e)
        {
            int number = randomGenerator1.Next(5000);
            randomLabel1.Content = number.ToString();
        }

        private void genButton2_Click(object sender, RoutedEventArgs e)
        {
            int number = randomGenerator2.Next(5000);
            randomLabel2.Content = number.ToString();
        }
    }
}
