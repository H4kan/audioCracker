using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction.Factors
{
    public class RectangleWindowFactor : IWindowFactor
    {
        public float GetScaleFactor(int frameOffset, int frameInterval, int frame)
        {
            return frame < frameOffset || frame > frameOffset + frameInterval ? 0.0f : 1.0f;
        }
    }
}
