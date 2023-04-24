using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction.Factors
{
    public class HannWindowFactor : IWindowFactor
    {
        public float GetScaleFactor(int frameOffset, int frameInterval, int frame)
        {
            return frame < frameOffset || frame > frameOffset + frameInterval ? 0.0f : 
                GetHannValue(frameOffset, frameInterval, frame);
        }

        private float GetHannValue(int frameOffset, int frameInterval, int frame)
        {
            return 0.5f + 0.5f * (float)Math.Cos(Math.PI * 
                2 * (frame - frameOffset - frameInterval / 2) / frameInterval);
        }
    }
}
