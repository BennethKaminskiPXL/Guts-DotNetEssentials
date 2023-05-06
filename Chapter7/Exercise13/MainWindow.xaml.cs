using System;
using System.Windows;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox.IsChecked == true)
            {
                btwTextBox.Text = Convert.ToString(Convert.ToDouble(priceTextbox.Text)*0.06);
                totalTextBox.Text = Convert.ToString(Convert.ToDouble(priceTextbox.Text)+Convert.ToDouble(btwTextBox.Text));
            }
            else
            {
                btwTextBox.Text = Convert.ToString(Convert.ToDouble(priceTextbox.Text) * 0.21);
                totalTextBox.Text = Convert.ToString(Convert.ToDouble(priceTextbox.Text) + Convert.ToDouble(btwTextBox.Text));

            }
        }
    }
}
