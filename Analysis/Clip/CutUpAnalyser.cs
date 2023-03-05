using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.Clip
{
    public class CutUpAnalyser : IClipAnalyser
    {
        private double cutDownPercent;

        public CutUpAnalyser(double cutDownValue) {
            this.cutDownPercent = cutDownValue / 100;
        }
        public double ConductAnalysis(IEnumerable<double> data)
        {
            var cutDown = data.Average() * this.cutDownPercent;

            var allDataCount = data.Count();

            var ratio = (double)(data.Where(x => x > cutDown).Count() + allDataCount) / (2 * allDataCount);

            return ratio;
        }
    }
}
