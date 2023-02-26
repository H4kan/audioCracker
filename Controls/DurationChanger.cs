using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace audioCracker.Controls
{
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    public class DurationChanger
    {
        private Label durationLabel;
        private Label currentLabel;

        private int durationMs;

        private int currentMs;

        private string durationString;

        private string currentString;

        private Timer currentTimer;

        private Wavplayer player;

        public DurationChanger(Wavplayer player, Label durationLabel, Label currentLabel) {
            this.durationLabel = durationLabel;
            this.currentLabel = currentLabel;
            this.durationString = "00:00";
            this.currentString = "00:00";
            this.durationMs = 0;
            this.currentMs = 0;
            this.currentTimer = new Timer();

            this.currentTimer.Tick += new EventHandler(TimerTick);

            this.currentTimer.Interval = 1000;

            this.player = player;
        }

        public void ChangeDuration(int durationMs)
        {
            this.durationMs = durationMs;
            var minutesDuration = this.durationMs / (60 * 1000);
            var secondsDuration = (this.durationMs / 1000) % 60;

            this.durationString = $"{minutesDuration.ToString("D2")}:{secondsDuration.ToString("D2")}";

            this.durationLabel.Text = this.durationString;
            this.currentTimer.Stop();
            this.ChangeCurrent(0);
        }

        private void ChangeCurrent(int currentMs)
        {
            this.currentMs = currentMs;
            var minutesDuration = this.currentMs / (60 * 1000);
            var secondsDuration = (this.currentMs / 1000) % 60;

            this.currentString = $"{minutesDuration.ToString("D2")}:{secondsDuration.ToString("D2")}";
            this.currentLabel.Text = this.currentString;
        }

        public void UnpauseCurrentTicker()
        {
            this.currentTimer.Start();
        }

        public void PauseCurrentTicker()
        {
            this.currentTimer.Stop();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var nextCurrent = this.currentMs + 1000;
            if (nextCurrent < durationMs)
            {
                this.ChangeCurrent(this.currentMs + 1000);
            }
            else
            {
                this.player.Stop();
            }

        }

        public void ResetCurrentTicker()
        {
            this.currentTimer.Stop();
            this.ChangeCurrent(0);
        }

#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }
}
