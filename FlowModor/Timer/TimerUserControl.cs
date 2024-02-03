using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModor.Timer
{
    public partial class TimerUserControl : UserControl
    {
        public Stopwatch Stopwatch { get; set; } = new Stopwatch();

        public TimerUserControl()
        {
            InitializeComponent();
            TimerTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Timer.Start();
            Stopwatch.StartNew();
            TimerTextBox.Text = Stopwatch.Elapsed.ToString();
            TimerTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = new TimeSpan(0, 0, 0);


        }
    }
}
