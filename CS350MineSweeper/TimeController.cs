using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace CS350MineSweeper
{
    class TimeController
    {

        private Stopwatch _stopwatch;
        private System.Windows.Forms.Timer _timer;
        private MainForm _mainForm;

        public TimeController(MainForm mainForm)
        {
            this._mainForm = mainForm;
            InitializeTimer();

        }

        private void InitializeTimer()
        {
            _stopwatch = new Stopwatch();
            _timer = new Timer();
            _timer.Enabled = false;
            _timer.Tick += new System.EventHandler(TimerTick);
        }

        public void StopTime()
        {
            _stopwatch.Stop();
            _timer.Enabled = false;
        }

        public void StartTime()
        {
            //Start stop watch and enable timer
            _stopwatch.Start();
            _timer.Enabled = true;
        }

        public void ResetTime()
        {
            //Reset stop watch and update timer label
            _stopwatch.Reset();
            _mainForm.UpdateTimer(0);
        }

        public int GetTime()
        {
            //Return total seconds since start
            return (int)_stopwatch.Elapsed.TotalSeconds;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            //Update the timer in mainForm with the total number of seconds
            _mainForm.UpdateTimer((int)_stopwatch.Elapsed.TotalSeconds);
        }



    }
}
