

using audioCracker.Analysis.Frame.Helpers;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frequency
{
    public class ERSBAnalyser : BandEnergyAnalyser
    {


        public ERSBAnalyser(NumericUpDown minFreq, NumericUpDown maxFreq) : base(minFreq, maxFreq) { }

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            var volume = FFTVolumeAnalyser.EvaluateVolume(data);
            return volume != 0 ? base.ConductAnalysis(data) / volume : 0.0;
        }
    }
}
