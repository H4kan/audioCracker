using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class AmdfFreqAnalyser : FrameAnalyser
    {

        private int framesPerSecond;
        private const int maxDelay = 1000;

        public AmdfFreqAnalyser() {
            this.framesPerSecond = 1000 / FrameMerger.frameLenInMs;
        }


        public override double ConductAnalysis(IEnumerable<float> data)
        {
            var listedData = data.ToList();
            if (!Helpers.IsVoicedFrame(listedData))
            {
                return 0;
            }

            // calculate range for which we will evaluate corr
            var localMaxDelay = (int)Math.Floor(listedData.Count * 0.9);
            var localMaxRange = listedData.Count - localMaxDelay;
            if (localMaxRange > maxDelay)
            {
                localMaxRange = maxDelay;
            }
            var currCorr = 0.0;
            var prevCorr = double.MaxValue;
            int maxFreq = localMaxRange / 3;
            for (int freq = localMaxRange / 3; freq < 2 * localMaxRange; freq++)
            {
                currCorr = EvaluateFreqCorrelation(listedData, freq, localMaxRange);
                if (currCorr < prevCorr)
                {
                    maxFreq = freq;
                    prevCorr = currCorr;
                }
            }
            double seconds = (double)maxFreq / (framesPerSecond * listedData.Count);
            return 1 / seconds;
        }

        private double EvaluateFreqCorrelation(List<float> data, int freq, int range)
        {
            double sum = 0.0;

            for (int i = 0; i < range; i++)
            {
                sum += Math.Abs(data[i] - data[i + freq]);
            }
            return sum;
        }

    }
}
