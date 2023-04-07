

namespace audioCracker.Analysis.Frame
{
    public class ForwardAnalyser : FrameAnalyser
    {

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            return data.Average(d => d);
        }

        public override (double[]?, double[]) ConductFrameAnalysis(IEnumerable<float> data)
        {
            return (null, data.Select(d => (double)d).ToArray());
        }
    }
}
