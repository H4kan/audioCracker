

using audioCracker.Analysis.Frame.Helpers;

namespace audioCracker.Analysis.Frequency
{
    public class FFTVolumeAnalyser : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            return EvaluateVolume(data);
        }

        public static double EvaluateVolume(IEnumerable<float> data)
        {
            return FftSharp.Transform.RFFT(data.Take(Helpers.FloorPower2(data.Count())).Select(d => (double)d).ToArray())
                .Select(cmp => cmp.Real).Average(d => d * d);
        }
    }
}
