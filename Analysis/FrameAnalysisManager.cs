using audioCracker.Analysis.Clip;
using audioCracker.Analysis.Frame;
using audioCracker.Analysis.Frequency;
using audioCracker.Analysis.WindowFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class FrameAnalysisManager : AnalysisManager
    {

        public FrameAnalysisManager(NumericUpDown minFreq, 
            NumericUpDown maxFreq, WindowConfiguration configuration) : base(minFreq, maxFreq)
        {
            this.clipFrameAnalysers = new List<(string, FrameAnalyser, IClipAnalyser?, string)>()
            {
                new ("Signal", new ForwardAnalyser(), null, "Amplitudes"),
                new ("Frequency spectrum", new FFTSpectrumAnalyser(), null, "Amplitudes"),
                new ("Signal (rectangle)", new RectangleWindowAnalyser(
                    new ForwardAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Signal (triangle)", new TriangleWindowAnalyser(
                    new ForwardAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Signal (Hann)", new HannWindowAnalyser(
                    new ForwardAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Signal (Hamming)", new HammingWindowAnalyser(
                    new ForwardAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Signal (Blackman)", new BlackmanWindowAnalyser(
                    new ForwardAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Frequency spectrum (rectangle)", new RectangleWindowAnalyser(
                    new FFTSpectrumAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Frequency spectrum (triangle)", new TriangleWindowAnalyser(
                    new FFTSpectrumAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Frequency spectrum (Hann)", new HannWindowAnalyser(
                    new FFTSpectrumAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Frequency spectrum (Hamming)", new HammingWindowAnalyser(
                    new FFTSpectrumAnalyser(),
                    configuration)
                    , null, "Amplitudes"),
                new ("Frequency spectrum (Blackman)", new BlackmanWindowAnalyser(
                    new FFTSpectrumAnalyser(),
                    configuration)
                    , null, "Amplitudes")
            };
        }
}
}
