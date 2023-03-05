using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer = System.Windows.Forms.Timer;

namespace audioCracker.Controls
{
    public class TimeManager
    {
        public Timer perSecondTimer;

        public bool IsPaused { get; set; }

        public TimeManager() {
            this.perSecondTimer = new Timer();


            this.perSecondTimer.Interval = 1000;
        }
        

    }
}
