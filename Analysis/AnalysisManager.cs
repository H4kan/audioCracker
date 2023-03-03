using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class AnalysisManager
    {
        private List<(string, IFrameAnalyser)> frameAnalysers;

        private (string, IFrameAnalyser) currentAnalyser;

        public AnalysisManager()
        {
            this.frameAnalysers = new List<(string, IFrameAnalyser)>()
            {
                new ("Volume", new VolumeAnalyser()),
                new ("some", new VolumeAnalyser())
            };
        }

        public IEnumerable<string> GetAnalysersNames()
        {
            return this.frameAnalysers.Select(i => i.Item1);
        }

        public void ChangeAnalyser(string analyserName)
        {
            this.currentAnalyser = this.frameAnalysers.First(a => a.Item1== analyserName);
        }

        public IFrameAnalyser GetAnalyser()
        {
            return this.currentAnalyser.Item2;
        }

}
}
