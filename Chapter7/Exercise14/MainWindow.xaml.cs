using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            if(femaleRadioButton.IsChecked == false)
            {
                MessageBox.Show($"Je hebt {femaleRadioButton.Content.ToString()} aangeduid ");
            }
            else
            {
                MessageBox.Show($"Je hebt {maleRadioButton.Content.ToString()} aangeduid ");

            }
            
        }
    }
}
