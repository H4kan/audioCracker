using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class AmdfFreqAnalyser : IFrameAnalyser
    {

        private int framesPerSecond;
        private const int maxDelay = 1000;

        public AmdfFreqAnalyser() {
            this.framesPerSecond = 25;
        }


        public double ConductAnalysis(IEnumerable<float> data)
        {
            var listedData = data.ToList();
            var currCorr = 0.0;
            var prevCorr = double.MaxValue;
            int maxFreq = 0;
            for (int freq = 100; freq < maxDelay; freq++)
            {
                currCorr = EvaluateFreqCorrelation(listedData, freq);
                if (currCorr < prevCorr)
                {
                    maxFreq = freq;
                    prevCorr = currCorr;
                }
            }
            double seconds = (double)maxFreq / (framesPerSecond * listedData.Count);
            return 1 / seconds;
        }

        private double EvaluateFreqCorrelation(List<float> data, int freq)
        {
            double sum = 0.0;

            for (int i = 0; i < data.Count - maxDelay; i++)
            {
                sum += Math.Abs(data[i] - data[i + freq]);
            }
            return sum;
        }
    }
}
