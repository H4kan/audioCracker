

namespace audioCracker.Analysis.Frame
{
    public class ForwardAnalyser : IFrameAnalyser
    {
        public double ConductAnalysis(IEnumerable<float> data)
        {
            return data.Average(d => d);
        }

        public double[] ConductFrameAnalysis(IEnumerable<float> data)
        {
            return data.Select(d => (double)d).ToArray();
        }
    }
}
