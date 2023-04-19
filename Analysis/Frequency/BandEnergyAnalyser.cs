

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class BandEnergyAnalyser : FrameAnalyser
    {

        private NumericUpDown minFreq;
        private NumericUpDown maxFreq;

        protected double minFreqV => (double)minFreq.Value;
        protected double maxFreqV => (double)maxFreq.Value;

        public BandEnergyAnalyser(NumericUpDown minFreq, NumericUpDown maxFreq)
        {
            this.minFreq = minFreq;
            this.maxFreq = maxFreq;
        }

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            // rectangle method for integral

            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).Select(d => d * d).ToArray();

            var freqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps).ToArray();

            double sum = 0.0;
            for (int i = 0; i < freqs.Length; i++)
            {
                if (freqs[i] < maxFreqV && freqs[i] > minFreqV)
                {
                    sum += amps[i];
                }
            }
            return sum / freqs.Count();
        }
    }
}
