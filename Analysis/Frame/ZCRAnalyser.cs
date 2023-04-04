using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class ZCRAnalyser : IFrameAnalyser
    {
        public double ConductAnalysis(IEnumerable<float> data)
        {
            bool prevPositive = false;
            int sum = 0;
            foreach(var item in data) { 
                if (prevPositive != item > 0)
                {
                    sum++;
                }
                prevPositive = item > 0;
            }
            return 0.5 * sum / data.Count();
        }

        public double[] ConductFrameAnalysis(IEnumerable<float> data)
        {
            throw new NotImplementedException();
        }
    }
}
