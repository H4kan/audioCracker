using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public interface IAnalyser
    {
        public IEnumerable<double> ConductAnalysis(IEnumerable<double> data);
    }
}
