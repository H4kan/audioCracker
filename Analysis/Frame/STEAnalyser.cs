using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class STEAnalyser : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            return data.Average(d => d * d);
        }
    }
}
