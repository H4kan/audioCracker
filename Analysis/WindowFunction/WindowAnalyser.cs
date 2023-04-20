

using audioCracker.Analysis.WindowFunction;

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
            var frameConf = this.configuration.GetWindow();
            var initialRes = this.modelSignal.ConductFrameAnalysis(data);
            return (initialRes.Item1, initialRes.Item2.Select((d, idx) => 
                d * factor.GetScaleFactor(frameConf.offset, frameConf.frameInterval, idx)).ToArray());
        }
    }

    public class WindowConfiguration
    {
        private int offsetFrame = 0;
        private int frameInterval = 0;

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
