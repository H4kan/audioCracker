using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction.Factors
{
    public class HammingWindowFactor : IWindowFactor
    {
        public float GetScaleFactor(int frameOffset, int frameInterval, int frame)
        {
            return frame < frameOffset || frame > frameOffset + frameInterval ? 0.0f :
                GetHammingValue(frameOffset, frameInterval, frame);
        }

        private float GetHammingValue(int frameOffset, int frameInterval, int frame)
        {
            return 0.54f + 0.46f * (float)Math.Cos(Math.PI *
                2 * (frame - frameOffset - frameInterval / 2) / frameInterval);
        }
    }
}
