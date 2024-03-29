﻿

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class FFTCentroidAnalyser : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            return EvaluateFC(data);
        }

        public static double EvaluateFC(IEnumerable<float> data)
        {
            // rectangle method for integral

            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).ToArray();

            var angFreqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps).Select(f => 2 * Math.PI * f).ToArray();

            var bottomIntegral = amps.Sum();
            var topIntegral = amps.Select((a, idx) => a * angFreqs[idx]).Sum();


            return topIntegral / bottomIntegral;
        }
    }
}
