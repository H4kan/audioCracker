using audioCracker.Analysis.Clip;
using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class AnalysisManager
    {
        protected List<(string, IFrameAnalyser, IClipAnalyser?, string)> clipFrameAnalysers;

        protected (string, IFrameAnalyser, IClipAnalyser?, string) currentAnalyser;

        public AnalysisManager()
        {
            this.clipFrameAnalysers = new List<(string, IFrameAnalyser, IClipAnalyser?, string)>()
            {
                new ("Signal", new ForwardAnalyser(), null, "Amplitudes"),
                new ("Volume", new VolumeAnalyser(), null, "Volume"),
                new ("STE", new STEAnalyser(), null, "Energy"),
                new ("ZCR", new ZCRAnalyser(), null, "Crossing zero count"),
                new ("autoCorr Frequency Detection", new CorFreqAnalyser(), null, "Base tone frequency"),
                new ("AMDF Frequency Detection", new AmdfFreqAnalyser(), null, "Base tone frequency"),
                new ("VSTD clip volume", new VolumeAnalyser(), new StdNormalizedAnalyser(), "VSTD"),
                new ("Average clip volume", new VolumeAnalyser(), new AverageAnalyser(), "Volume"),
                new ("LSTER", new STEAnalyser(), new CutDownAnalyser(50.0), "fraction of frames"),
                new ("ZSTD", new ZCRAnalyser(), new StdAnalyser(), "ZSTD"),
                new ("HZCRR",  new ZCRAnalyser(), new CutUpAnalyser(150.0), "HZCRR")
            };
        }

        public IEnumerable<string> GetAnalysersNames()
        {
            return this.clipFrameAnalysers.Select(i => i.Item1);
        }

        public void ChangeAnalyser(string analyserName)
        {
            this.currentAnalyser = this.clipFrameAnalysers.First(a => a.Item1== analyserName);
        }

        public (IFrameAnalyser, IClipAnalyser?) GetAnalyser()
        {
            return (this.currentAnalyser.Item2, this.currentAnalyser.Item3);
        }

        public string GetYLabel()
        {
            return this.currentAnalyser.Item4;
        }

}
}
