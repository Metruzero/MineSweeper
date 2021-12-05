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

        private Stopwatch stopwatch;
        private System.Windows.Forms.Timer timer;
        private MainForm mainForm;

        public TimeController(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeTimer();

        }

        private void InitializeTimer()
        {
            stopwatch = new Stopwatch();
            timer = new Timer();
            timer.Enabled = false;
            timer.Tick += new System.EventHandler(timerTick);
        }

        public void stopTime()
        {
            stopwatch.Stop();
            timer.Enabled = false;
        }

        public void startTime()
        {
            //Start stop watch and enable timer
            stopwatch.Start();
            timer.Enabled = true;
        }

        public void resetTime()
        {
            //Reset stop watch and update timer label
            stopwatch.Reset();
            mainForm.UpdateTimer(0);
        }

        public int getTime()
        {
            //Return total seconds since start
            return (int)stopwatch.Elapsed.TotalSeconds;
        }

        private void timerTick(object sender, EventArgs e)
        {
            //Update the timer in mainForm with the total number of seconds
            mainForm.UpdateTimer((int)stopwatch.Elapsed.TotalSeconds);
        }



    }
}
