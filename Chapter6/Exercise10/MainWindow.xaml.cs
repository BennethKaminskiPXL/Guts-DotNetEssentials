using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Exercise10
{
    public partial class MainWindow : Window
    {
        int teller = 0;
        DispatcherTimer _timer;
        public MainWindow()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
            
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            teller++;
            progressBar.Value++;
            if (teller == 5)
            {
                _timer.Stop();
                okButton.IsEnabled = false;
                MessageBox.Show("U hebt slechts vijf seconden om in te loggen.");

            }
        }
    }
}
