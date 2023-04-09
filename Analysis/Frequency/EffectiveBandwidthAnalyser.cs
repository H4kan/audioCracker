

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class EffectiveBandwidth : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            // rectangle method for integral

            var fc = FFTCentroidAnalyser.EvaluateFC(data);

            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).ToArray();

            var angfreqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps).Select(f => 2 * Math.PI * f).ToArray();

            var bottomIntegral = amps.Select((a, idx) => a * a).Sum();
            var topIntegral = amps.Select((a, idx) => Math.Pow(a * (angfreqs[idx] - fc), 2)).Sum();


            return topIntegral / bottomIntegral;
        }
    }
}
