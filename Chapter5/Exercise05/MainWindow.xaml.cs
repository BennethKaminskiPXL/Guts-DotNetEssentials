using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Exercise05
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            DrawLogo(paperCanvas, brush, 10, 20);
            DrawLogo(paperCanvas, brush, 100, 100);
            DrawTriangle2(paperCanvas, brush, 100, 10, 40, 40);
            DrawTriangle2(paperCanvas, brush, 10, 100, 20, 60);
            DrawTriangle2(paperCanvas, brush, 60, 20, 20, 20);
        }

        private void DrawTriangle2(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPlace,
                                   double yPlace,
                                   double width,
                                   double height)
        {
            Polygon polygon = new Polygon();
  
            polygon.Stroke = brushToUse;
            System.Windows.Point point1 = new System.Windows.Point(xPlace, yPlace);
            System.Windows.Point point2 = new System.Windows.Point(width, yPlace);
            System.Windows.Point point3 = new System.Windows.Point(xPlace + (xPlace / 2), height);
            PointCollection points = new PointCollection();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            polygon.Points = points;
            drawingArea.Children.Add(polygon);
                
        }
        



        private void DrawLogo(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double xPos,
                              double yPos)
        {
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 20);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 40);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double size)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = size,
                Height = size,
                Margin = new Thickness(xPos, yPos, 0, 0),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(rectangle);
        }
    }
}
