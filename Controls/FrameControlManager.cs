using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Controls
{
    public class FrameControlManager
    {
        private NumericUpDown frameUpDown;
        private TrackBar frameSlider;

        public FrameControlManager(NumericUpDown frameUpDown, TrackBar frameSlider) {
            this.frameUpDown = frameUpDown;
            this.frameSlider = frameSlider;
        }
        
        public void SetBoundary(int max)
        {
            this.frameSlider.Maximum = max;
            this.frameUpDown.Maximum = max;
        }
    }
}
