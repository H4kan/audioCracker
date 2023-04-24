using audioCracker.Analysis.Frame;
using audioCracker.Analysis.WindowFunction.Factors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.WindowFunction
{
    public class HammingWindowAnalyser : WindowAnalyser
    {


        public HammingWindowAnalyser(FrameAnalyser modelSignal, WindowConfiguration configuration) 
            : base(modelSignal, configuration, new HammingWindowFactor())
        {
        }

    }
}
