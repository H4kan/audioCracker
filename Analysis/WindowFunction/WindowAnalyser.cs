

using audioCracker.Analysis.WindowFunction;
using audioCracker.Decoder;

namespace audioCracker.Analysis.Frame
{
    public abstract class WindowAnalyser : FrameAnalyser
    {
        private WindowConfiguration configuration;
        private IWindowFactor factor;
        private FrameAnalyser modelSignal;

        public WindowAnalyser(FrameAnalyser modelSignal, 
            WindowConfiguration configuration,
            IWindowFactor windowFactor) { 
            this.configuration = configuration;
            this.factor = windowFactor;
            this.modelSignal = modelSignal;
        }

        public override double ConductAnalysis(IEnumerable<float> data)
        {
            throw new NotImplementedException();
        }

        public override (double[]?, double[]) ConductFrameAnalysis(IEnumerable<float> data)
        {
            var windowedData = ConductWindow(data);
            var initialRes = this.modelSignal.ConductFrameAnalysis(windowedData);
            return (initialRes.Item1, initialRes.Item2);
        }

        private IEnumerable<float> ConductWindow(IEnumerable<float> data)
        {
            var frameConf = this.configuration.GetWindow();
            var scale = data.Count() / FrameMerger.frameLenInMs;
            var scaledOffset = frameConf.offset * scale;
            var scaledInterval = frameConf.frameInterval * scale;
            return data.Select((d, idx) =>
                d * factor.GetScaleFactor(scaledOffset, scaledInterval,
                idx));
        }
    }

    public class WindowConfiguration
    {
        private int offsetFrame = 10;
        private int frameInterval = 20;

        public void SetWindow(int offsetFrame, int frameInterval)
        {
            this.offsetFrame = offsetFrame;
            this.frameInterval = frameInterval;
        }

        public (int offset, int frameInterval) GetWindow()
        {
            return (this.offsetFrame, this.frameInterval);
        }
    }
}
