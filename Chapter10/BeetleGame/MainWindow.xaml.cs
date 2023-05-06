using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Beetle _beetle;
        private DispatcherTimer _timer;
        private Random _random;
        private int _x;
        private int _y;
        private double _speed;
        private double _size;
        private double _count = 0.00;
        public MainWindow()
        {
            InitializeComponent();
            CalculatePositions();
            sizeSlider.Value = sizeSlider.Minimum;
            _timer = new DispatcherTimer();
            setTimer();
            _timer.Tick += _timer_Tick;
            _beetle = new Beetle(paperCanvas, _x, _y, _size);
            _beetle.Speed = _speed;
        }

        private void CalculatePositions()
        {
            _random = new Random();
            _x = _random.Next(30, Convert.ToInt32(paperCanvas.Width) - 30);
            _y = _random.Next(30, Convert.ToInt32(paperCanvas.Height)-30);
               
            while (Math.Sqrt(Math.Pow((paperCanvas.Width / 2) -( _x),2) + Math.Pow((paperCanvas.Height / 2) - (_y),2)) <= 100) {
                _x = _random.Next(30, Convert.ToInt32(paperCanvas.Width) - 30);
                _y = _random.Next(30, Convert.ToInt32(paperCanvas.Height) - 30);
            };
        }

        
        private void _timer_Tick(object sender, EventArgs e)
        {
            _beetle.ChangePosition();
            _count += 0.01;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (startButton.Content.ToString() == "Start")
            {
                startButton.Content = "Stop";
                speedSlider.IsEnabled = false;
                sizeSlider.IsEnabled = false;
                _timer.Start();
            }
            else if (startButton.Content.ToString() == "Stop"){
                startButton.Content = "Start";
                speedSlider.IsEnabled = true;
                sizeSlider.IsEnabled = true;
                _timer.Stop();
                messageLabel.Content = $"total distance in meters : {_count}";
            }
        }

        private void direction_Clicked(object sender, RoutedEventArgs e)
        {
            Button direction = (Button)sender;
            switch (direction.Content.ToString())
            {
                case "Right":
                    _beetle.Right = true;
                    _beetle.Left = false;
                    break;
                case "Left":
                    _beetle.Right = false;
                    _beetle.Left = true;
                    break;
                case "Up":
                    _beetle.Up = true;
                    _beetle.Down = false;
                    break;
                case "Down":
                    _beetle.Down = true;
                    _beetle.Up = false;
                    break;
                default:
                    MessageBox.Show($"Er is iets mis, aangeduide button is : {direction.Content.ToString()} ");
                    break;
             
            }
            

        }

        private void resetButton_Clicked(object sender, RoutedEventArgs e)
        {
            
            speedSlider.Value = speedSlider.Minimum;
            sizeSlider.Value = sizeSlider.Minimum;
            speedSlider.IsEnabled = true;
            sizeSlider.IsEnabled = true;
            startButton.Content = "Start";
            _beetle.IsVisible = false;
            _timer.Stop();
        }

        private void slider_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(speedSlider != null) {speedLabel.Content = speedSlider.Value.ToString(); _speed = speedSlider.Value; if (_beetle != null) { _beetle.Speed = _speed; } }
            if(sizeSlider != null) { sizeLabel.Content = sizeSlider.Value.ToString(); _size = sizeSlider.Value; 
            if(_beetle != null) {_beetle.Size = _size;}
            }
            setTimer();
           
        }
        private void setTimer()
        {
            if (_timer != null) { _timer.Interval = TimeSpan.FromMilliseconds(100 / speedSlider.Value * sizeSlider.Value / 10); }
        }
       
    }
};

