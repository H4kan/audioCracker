using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class VolumeAnalyser : IFrameAnalyser
    {
        public double ConductAnalysis(IEnumerable<float> data)
        {
            return 10.0;
        }
    }
}
