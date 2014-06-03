using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Globalization;

namespace CrosseClocks
{
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// The gameClock keeps track of the elapsed time in the game.
        /// </summary>
        Stopwatch gameClock;

        /// <summary>
        /// The ticker ensures screen updates are regularly called.
        /// </summary>
        DispatcherTimer ticker;

        private const string format = "mm\\:ss\\.f";
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            gameClock = new Stopwatch();

            ticker = new DispatcherTimer();
            ticker.Interval = TimeSpan.FromMilliseconds(Settings.TICK_TIME);
            ticker.Tick += ticker_Tick;
            ticker.Start();

            txtGameClock.Text = gameClock.Elapsed.ToString(format);
        }

        void ticker_Tick(object sender, EventArgs e)
        {
            txtGameClock.Text = gameClock.Elapsed.ToString(format);
        }

        private void txtGameClock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (gameClock.IsRunning)
            {
                gameClock.Stop();
            }
            else
            {
                gameClock.Start();
            }
        }
    }
}