using audioCracker.Analysis.Frame.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class CorFreqAnalyser : IFrameAnalyser
    {

        private int framesPerSecond;

        private const int maxDelay = 1000;

        public CorFreqAnalyser() {
            this.framesPerSecond = 25;
        }


        public double ConductAnalysis(IEnumerable<float> data)
        {
            var listedData = data.ToList();
            if (!Voicing.IsVoicedFrame(listedData))
            {
                return 0;
            }
            var currCorr = 0.0;
            var prevCorr = 0.0;
            int maxFreq = 50;
            for (int freq = 50; freq < maxDelay; freq++)
            {
                currCorr = EvaluateFreqCorrelation(listedData, freq);
                if (currCorr > prevCorr)
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

            for (int i = 0; i < maxDelay; i++)
            {
                sum += data[i] * data[i + freq];
            }
            return sum;
        }
    }
}
