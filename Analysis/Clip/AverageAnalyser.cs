using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.Clip
{
    public class AverageAnalyser : IClipAnalyser
    {
        public double ConductAnalysis(IEnumerable<double> data)
        {
            return data.Average();
        }
    }
}
