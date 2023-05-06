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

namespace Exercise04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle _rectangle;
        
        public MainWindow()
        {
            InitializeComponent();
            double x = 10;
            double y = 10;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    DrawRectangle(ref x, ref y);
                    x += 20;
                }
                x = 10;
                y += 20;
            }
           
            
        }

        private void DrawRectangle(ref double x,ref double y)
        {
            _rectangle = new Rectangle()
            {
                Width = 10,
                Height = 10,
                Margin = new Thickness(x,y,0,0),
                Stroke = new SolidColorBrush(Colors.Black)

            };
            canvas.Children.Add( _rectangle );

        }
    }
}
