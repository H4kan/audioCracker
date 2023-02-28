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
        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.frames.Select(f => this.currentAnalyser.ConductAnalysis(f)).Skip(startFrame).Take(endFrame - startFrame);
        }

    }
}
