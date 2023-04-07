

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class FFTSpectrumAnalyser : FrameAnalyser
    {
        public override bool FrequencyDomain { get { return true; } }

        public override (double[]?, double[]) ConductFrameAnalysis(IEnumerable<float> data)
        {
            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).ToArray();

            var freqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps);

            return (freqs, amps);
        }
    }
}
