

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class SCFAnalyser : BandEnergyAnalyser
    {


        public SCFAnalyser(NumericUpDown minFreq, NumericUpDown maxFreq) : base(minFreq, maxFreq) { }

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            var amps = FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).Select(d => d * d).ToArray();

            var freqs = FftSharp.Transform.FFTfreq(data.Count() * 1000 / FrameMerger.frameLenInMs, amps).ToArray();

            double sum = 0.0;
            int count = 0;
            for (int i = 0; i < freqs.Length; i++)
            {
                if (freqs[i] < base.maxFreqV && freqs[i] > base.minFreqV)
                {
                    sum += amps[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return 1.0;
            }

            sum /= count;

            return amps.Max() / sum;
        }
    }
}
