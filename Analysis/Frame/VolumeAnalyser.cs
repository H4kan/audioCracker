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
            return Math.Sqrt(data.Average(d => d * d));
        }

        public double[] ConductFrameAnalysis(IEnumerable<float> data)
        {
            throw new NotImplementedException();
        }
    }
}
