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

namespace Exercise07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _multiplicationNumber;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sizeButton_Click(object sender, RoutedEventArgs e)
        {
            _multiplicationNumber = Convert.ToInt32(sizeTextBox.Text);
            for (int i = 1; i <= _multiplicationNumber; i++)
            {
                tableTextBox.Text += $"\t{i}";
            }
            tableTextBox.Text += "\t\n";
            for (int i = 1; i <= _multiplicationNumber; i++)
            {
                tableTextBox.Text += $"\n{i}\t";
                for (int j = 1; j <= _multiplicationNumber; j++)
                {
                    tableTextBox.Text += $"{j * i}\t";
                }
            }
        }
    }
}
