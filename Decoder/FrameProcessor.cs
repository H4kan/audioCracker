using audioCracker.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Decoder
{
    public class FrameProcessor
    {

        private IFrameAnalyser currentAnalyser;

        private FrameMerger frameMerger;

        private IEnumerable<IEnumerable<float>> frames;

        private IEnumerable<double> processedFrames;

        public FrameProcessor() { 
            this.frameMerger = new FrameMerger();
        }

        public void LoadFramesFromFile(string filename, int durationInMs)
        {
            this.frames = this.frameMerger.GetFrameDividedAmplitudes(filename, durationInMs);
        }


        public void SetAnalyser(IFrameAnalyser analyser)
        {
            this.currentAnalyser = analyser;

            var childThRef = new ThreadStart(this.ConductAnalysis);

            var childThread = new Thread(childThRef);
            childThread.Start();
        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.processedFrames.Skip(startFrame).Take(endFrame - startFrame);
        }

        public (double, double) GetRange()
        {
            return (this.processedFrames.Min(), this.processedFrames.Max());
        }

        private void ConductAnalysis()
        {
            this.processedFrames = this.frames.Select(f => this.currentAnalyser.ConductAnalysis(f)).ToList();
        }
    }
}
