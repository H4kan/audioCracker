

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class FFTSpectrumAnalyser : FrameAnalyser
    {

        private MaxFrequencyResolver maxFrequencyResolver;

        public FFTSpectrumAnalyser(MaxFrequencyResolver maxFrequencyResolver) { 
            this.maxFrequencyResolver = maxFrequencyResolver;
        }


        public override bool FrequencyDomain { get { return true; } }

        public override (double[]?, double[]) ConductFrameAnalysis(IEnumerable<float> data)
        {
            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).ToArray();

            var maxFreq = this.maxFrequencyResolver.GetMaxFrequency();

            var freqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps)
                .TakeWhile(d => d <= maxFreq).ToArray();

            amps = amps.Take(freqs.Length).ToArray();


            return (freqs, amps);
        }
    }
}
