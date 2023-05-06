using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int teller = 0;
        int minuten = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            teller++;
            secondsRectangle.Width += 10;
            if(teller == 60)
            {
                teller = 0;
                minuten++;
                secondsRectangle.Width = 0;
                minutesRectangle.Width += 10;
            }
            if(minuten == 60)
            {
                minuten = 0;
                minutesRectangle.Width = 0;
            }
        }
    }
}
