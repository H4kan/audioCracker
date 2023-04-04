using audioCracker.Analysis.Clip;
using audioCracker.Analysis.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class FrameAnalysisManager : AnalysisManager
    {

        public FrameAnalysisManager()
        {
            this.clipFrameAnalysers = new List<(string, IFrameAnalyser, IClipAnalyser?, string)>()
            {
                new ("Signal", new ForwardAnalyser(), null, "Amplitudes")
            };
        }
}
}
