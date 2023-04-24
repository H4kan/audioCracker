using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction.Factors
{
    public class TriangleWindowFactor : IWindowFactor
    {
        public float GetScaleFactor(int frameOffset, int frameInterval, int frame)
        {
            return frame < frameOffset || frame > frameOffset + frameInterval ? 0.0f : 
                GetTriangularValue(frameOffset, frameInterval, frame);
        }

        private float GetTriangularValue(int frameOffset, int frameInterval, int frame)
        {
            return 1 - 2 * (float)(Math.Abs((frame - frameOffset - frameInterval / 2))) / frameInterval;
        }
    }
}
