using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlowModor.Timer
{
    public partial class TimerUserControl : UserControl
    {
        private DateTime startTime;
        private TimeSpan elapsedTime;
        private bool isRunning;

        public TimerUserControl()
        {
            InitializeComponent();
            TimerTextBox.SelectionAlignment = HorizontalAlignment.Center;

            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
        }

        #region Timer funcs
        private void ResetChronometer()
        {
            isRunning = false;
            elapsedTime = TimeSpan.Zero;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            TimerTextBox.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            TimerTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
            UpdateDisplay();
        }

        private void UpdateBtns()
        {
            StartBtn.Text = isRunning ? "PAUSE" : "START";
            ResetBtn.Enabled = !isRunning;
        }
        #endregion

        #region user Actions
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                //start from NOW minus TimeSpan.Zero
                //restart from NOW minus recorded TimeSpan (doesn't tick while !isRunning)
                startTime = DateTime.Now - elapsedTime;
                Timer.Start();
            }
            else
            {
                Timer.Stop();
            }
            isRunning = !isRunning;
            UpdateBtns();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            ResetChronometer();
            UpdateBtns();
        }
        #endregion

    }
}
