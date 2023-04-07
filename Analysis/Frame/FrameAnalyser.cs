using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public abstract class FrameAnalyser
    {
        public virtual double ConductAnalysis(IEnumerable<float> data)
        {
            return data.Average();
        }

        public virtual (double[]?, double[]) ConductFrameAnalysis(IEnumerable<float> data)
        {
            return (data.Select(d => (double)d).ToArray(), data.Select(d => (double)d).ToArray());
        }

        public virtual bool FrequencyDomain {  get {  return false; } }
    }
}
