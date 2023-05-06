using System;
using System.Windows;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        int som;
        float gemiddelde;
        float teller = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Magic_Click(object sender, RoutedEventArgs e)
        {
            teller++;
            Random randint = new Random();
            int getal = randint.Next(200,400);
            som += getal;
            gemiddelde = som / teller;
            randomTextBox.Text = getal.ToString();
            SumTextBoxName.Text = som.ToString();
            AverageTextBoxName.Text = gemiddelde.ToString();
        }
    }
}
