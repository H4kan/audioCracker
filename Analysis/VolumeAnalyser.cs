using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class VolumeAnalyser : IAnalyser
    {
        public IEnumerable<double> ConductAnalysis(IEnumerable<double> data)
        {
            var fList = new List<double>();
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                fList.Add(100 * rnd.NextDouble());
            }
            return fList;
        }
    }
}
