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

namespace Exercise15
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            int totaalSeconden = Convert.ToInt32("3662");
            ConvertSecondsToHoursMinutesSeconds(totaalSeconden, out int hours, out int  minutes, out int seconds);
            resultBox.Text = $"{totaalSeconden} seconden is {hours} uur, {minutes} minuten en {seconds} seconden ";

        }
        private void ConvertSecondsToHoursMinutesSeconds(int totaalSeconden, out int hours, out int minutes, out int seconds)
        {
            hours = totaalSeconden / 3600;
            totaalSeconden %= 3600;
            minutes = totaalSeconden / 60;
            totaalSeconden %= 60;
            seconds = totaalSeconden;

        }
    }
}
