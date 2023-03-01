using audioCracker.Analysis;
using audioCracker.Controls;
using audioCracker.Loading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace audioCracker.Decoder
{
    public class FrameProcessor
    {

        private LoaderManager loaderManager;

        private IFrameAnalyser currentAnalyser;

        private FrameMerger frameMerger;

        private IEnumerable<IEnumerable<float>> frames;

        private IEnumerable<double> processedFrames;

        private int estimatedTimeInSeconds;

        public FrameProcessor(PlotManager plotManager, ControlManager controlManager) { 
            this.frameMerger = new FrameMerger();
            this.loaderManager = new LoaderManager(this, plotManager, controlManager);
        }

        public void LoadFramesFromFile(string filename, int durationInMs)
        {
            this.frames = this.frameMerger.GetFrameDividedAmplitudes(filename, durationInMs);
        }


        public void SetAnalyser(IFrameAnalyser analyser)
        {
            this.currentAnalyser = analyser;


            this.ConductEstimation();

            var childThRef = new ThreadStart(this.ConductAnalysis);

            var childThread = new Thread(childThRef);
            childThread.Start();
            this.loaderManager.StartLoading();
        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.processedFrames.Skip(startFrame).Take(endFrame - startFrame);
        }

        public (double, double) GetRange()
        {
            return (this.processedFrames.Min(), this.processedFrames.Max());
        }

        public int GetEstimatedTime()
        {
            return estimatedTimeInSeconds;
        }

        private void ConductEstimation()
        {
            this.estimatedTimeInSeconds = 100;
        }

        private void ConductAnalysis()
        {
            this.processedFrames = this.frames.Select(f => this.currentAnalyser.ConductAnalysis(f)).ToList();
            this.loaderManager.StopLoading();
        }
    }
}
