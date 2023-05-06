using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        int _number;
        int _secondNumber;
        bool _plusOperator;
        bool _minusOperator;
        bool _reset = true;
        int _hiddenTotal = 0;
        public MainWindow()
        {
            InitializeComponent();
            displayTextBlock.Text = "0";
        }

        private void numberClicked(object sender, RoutedEventArgs e)
        {
            var clickedButton = (Button)sender;
            if(_reset == true)
            {
               displayTextBlock.Text = clickedButton.Content.ToString();
                _reset = false;
            }
            else
            {
                displayTextBlock.Text += clickedButton.Content.ToString();
                
            }
            
        }

        private void clearButtonClicked(object sender, RoutedEventArgs e)
        {
            displayTextBlock.Text = "0";
            _reset = true;
            _hiddenTotal = 0; 
        }

        private void operatorButton_Click(object sender, RoutedEventArgs e)
        {
            var clickedOperatorButton = (Button)sender;
            switch (clickedOperatorButton.Content.ToString())
            {
                case "+":
                    if (_reset == false && _minusOperator != true) {_hiddenTotal += Convert.ToInt32(displayTextBlock.Text); }
                    else { _hiddenTotal -= Convert.ToInt32(displayTextBlock.Text); }
                    _reset = true;
                    _plusOperator = true;
                    _minusOperator = false;
                    displayTextBlock.Text = _hiddenTotal.ToString();
                    break;
                case "-":
                    if(_reset == false && _minusOperator == false) { _hiddenTotal +=  Convert.ToInt32(displayTextBlock.Text); }
                    _minusOperator = true;
                    _plusOperator = false;
                    _reset = true;

                    displayTextBlock.Text = _hiddenTotal.ToString();
                    break;
                default:
                    if(_plusOperator && _reset == false)
                    {
                        _hiddenTotal += Convert.ToInt32(displayTextBlock.Text);
                    }
                    else if(_minusOperator && _reset == false) {
                        _hiddenTotal -= Convert.ToInt32(displayTextBlock.Text);
                    }
                    displayTextBlock.Text = _hiddenTotal.ToString();
                    _hiddenTotal = 0;
                    _minusOperator = false;
                    _plusOperator = false;
                    _reset = true;
                    break;
            }
        }
    }
}
