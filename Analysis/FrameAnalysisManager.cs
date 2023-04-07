using audioCracker.Analysis.Clip;
using audioCracker.Analysis.Frame;
using audioCracker.Analysis.Frequency;
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
            this.clipFrameAnalysers = new List<(string, FrameAnalyser, IClipAnalyser?, string)>()
            {
                new ("Signal", new ForwardAnalyser(), null, "Amplitudes"),
                new ("Frequency spectrum", new FFTSpectrumAnalyser(), null, "Amplitudes")
            };
        }
}
}
