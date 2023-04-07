

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class FFTCentroidAnalyser : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            // rectangle method for integral

            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).ToArray();

            var freqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps);

            var bottomIntegral = amps.Sum() * (freqs[1] - freqs[0]);
            var topIntegral = amps.Select((a, idx) => a * freqs[idx]).Sum() * 2 * Math.PI;


            return topIntegral / bottomIntegral;
        }
    }
}
