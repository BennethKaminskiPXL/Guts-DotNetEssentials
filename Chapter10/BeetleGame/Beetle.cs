using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        private Canvas _canvas = new Canvas();
        private int _beetleX;
        private int _beetleY;
        private double _beetleSize;
        private double _beetleSpeed;
        private Ellipse _ellipse;
        private bool _right = true;
        private bool _left;
        private bool _visible;
        private bool _up = true;
        private bool _down = true;
        

        public bool Down
        {
            get { return _down; }
            set { _down = value; }
        }
        public bool Up
        {
            get { return _up; }
            set { _up = value; }
        }


        public bool IsVisible
        {
            get { return _visible; }
            set { _visible = value; }
        }


        public bool Left
        { get { return _left; } set { _left = value; } }

        public bool Right
        {
            get { return _right; }
            set { _right = value; }
        }


        public double Speed
        {
            get { return _beetleSpeed; }
            set { _beetleSpeed = value; }
        }


        public double Size
        {
            get { return _beetleSize; }
            set { _beetleSize = value; }
        }


        public int Y
        {
            get { return _beetleY; }
            set { _beetleY = value; }
        }


        public int X
        {
            get { return _beetleX; }
            set { _beetleX = value; }
        }

        public Beetle() { }

        public Beetle(Canvas canvas, int x, int y, double size)
        {
            _canvas = canvas;
            _beetleX = x;
            _beetleY = y;
            _beetleSize = size;
            _ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Red),
                Width = _beetleSize,
                Height = _beetleSize,
                Margin = new Thickness(_beetleX - (_beetleSize/2), _beetleY - (_beetleSize/2), 0, 0)
            };
            _canvas.Children.Add(_ellipse);
        }

        public void ChangePosition() {
            _canvas.Children.Clear();
            
            bool check = borderCheck();
            if (Right) { X += 1; } else { X -= 1; };
            if (Up && check) { Y -= 1; } else { Y += 1; };
            _ellipse.Margin = new Thickness(X - (_beetleSize / 2), Y - (_beetleSize / 2), 0, 0);
            _canvas.Children.Add(_ellipse);
        }
        private bool borderCheck() {
            double upperBorder = Size / 2 + 1;
            int leftBorder = (int)(_beetleSize / 2);
            double rightBorder = _canvas.Width - Size;
            if (Y > upperBorder) { return true; }
            else
            {
                return false;
            }
        }

    }
}
