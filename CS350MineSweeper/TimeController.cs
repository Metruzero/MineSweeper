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
            stopwatch.Start();
            timer.Enabled = true;
        }

        public void resetTime()
        {
            stopwatch.Reset();
            mainForm.UpdateTimer(0);
        }

        private void timerTick(object sender, EventArgs e)
        {
            mainForm.UpdateTimer(stopwatch.Elapsed.Seconds);
        }



    }
}
