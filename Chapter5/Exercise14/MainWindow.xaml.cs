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

namespace Exercise14
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

        private void BerekenButton_Click(object sender, RoutedEventArgs e)
        {
            int teConverterenGetal = Convert.ToInt32(getal.Text);
            string geConverteerdeGetal = ConvertNumberToBinary(teConverterenGetal);
            resultBox.Text = geConverteerdeGetal;
        }

        private string ConvertNumberToBinary(int teConverterenGetal)
        {
            string geConverteerdGetal = Convert.ToString(teConverterenGetal, 2);
            return geConverteerdGetal;
        }


    }
}
