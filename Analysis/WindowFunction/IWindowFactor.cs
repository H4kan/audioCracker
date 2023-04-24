using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction
{
    public interface IWindowFactor
    {
        float GetScaleFactor(int frameOffset, int frameInterval, int frame);
    }
}
