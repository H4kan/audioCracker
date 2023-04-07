using audioCracker.Analysis;
using audioCracker.Decoder;
using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Controls
{
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    public class PlotManager
    {

        private FormsPlot dataPlot;
        private TimeManager timeManager;
        private Button savePlotButton;

        private double[] displayedX;
        private double[] actualX;
        private double[] displayedY;
        private double[] nonSilentY;
        private List<int> displayedXSeconds;
        private double[] actualXSeconds;

        private FrameProcessor frameProcessor;
        private SilenceManager silenceManager;
        private ClipProcessor clipProcessor;
        private AnalysisManager analysisManager;

        public int framesPerSecond;
        private int clipsPerSecond;

        private int framesPerPlot;
        private int clipsPerPlot;

        private int yTicks = 10;

        private int secondsOnPlot = 5;

        private IPlottable? currentPlot;
        private IPlottable? silencePlot;

        public bool IsLoaded { get; private set; }

        private EventHandler? currentHandler;

        private bool clipLoaded = false;

        private bool silenceShown = false;

        public int? currentFrame;

        public PlotManager(FormsPlot dataPlot, TimeManager timeManager, ControlManager controlManager, 
            AnalysisManager analysisManager, Button savePlotButton) {
            this.dataPlot = dataPlot;
            this.timeManager = timeManager;
            this.frameProcessor = new FrameProcessor(this, controlManager);
            this.clipProcessor = new ClipProcessor(this.frameProcessor);
            this.silenceManager = new SilenceManager(this, controlManager);
            this.analysisManager = analysisManager;
            this.savePlotButton = savePlotButton;



            this.framesPerSecond = FrameMerger.frameLenInMs;
            this.clipsPerSecond =  this.framesPerSecond / this.clipProcessor.framesPerClip;

            this.currentPlot = null;
            this.IsLoaded = false;
        }

        public void EnableSilence(bool enable = true)
        {
            this.silenceShown = enable;
        }

        public void ChangeSecondsOnPlot(int seconds)
        {
            this.secondsOnPlot = seconds;
            this.framesPerPlot = this.framesPerSecond * secondsOnPlot;
            this.clipsPerPlot = this.clipsPerSecond * secondsOnPlot;
        }

        public void LoadFile(string path, int durationInMs) {
            
            this.frameProcessor.LoadFramesFromFile(path, durationInMs);
            this.silenceManager.LoadFramesIntoSilencer(this.frameProcessor.frames);
            this.IsLoaded = false;
        }

        public void StartAnalysis()
        {
            if (this.currentFrame.HasValue)
            {
                this.StartAnalysisSingleFrame();
            }
            else
            {
                this.StartAnalysisFrames();
            }
        }

        public void StartAnalysisFrames()
        {
            this.dataPlot.Plot.YLabel(this.analysisManager.GetYLabel());
            this.dataPlot.Plot.XLabel(this.analysisManager.GetXLabel());

            var analysers = this.analysisManager.GetAnalyser();

            this.frameProcessor.SetAnalyser(analysers.Item1);

            if (analysers.Item2 != null)
            {
                this.clipLoaded = true;
                this.clipProcessor.SetAnalyser(analysers.Item2);
                this.clipProcessor.StartAnalysis();
            }
            else
            {
                this.clipLoaded = false;
                _ = this.frameProcessor.StartAnalysis();
            }
            if (this.silenceShown)
            {
                this.silenceManager.ConductSilenceAnalysis();
            }

            this.IsLoaded = true;
        }

        private void StartAnalysisSingleFrame()
        {
            this.dataPlot.Plot.YLabel(this.analysisManager.GetYLabel());
            this.dataPlot.Plot.XLabel(this.analysisManager.GetXLabel());

            var analysers = this.analysisManager.GetAnalyser();

            this.frameProcessor.SetAnalyser(analysers.Item1);

            this.clipLoaded = false;

            _ = this.frameProcessor.StartFrameAnalysis(this.currentFrame.Value);

            this.IsLoaded = true;
        }

        public void ShowPlot()
        {
            if (this.currentFrame.HasValue)
            {
                this.ShowPlotSingleFrame();
            }
            else
            {
                this.ShowPlotFrames();
            }
        }

        private void ShowPlotSingleFrame()
        {
            var frameLen = FrameMerger.frameLenInMs;
            if (this.currentPlot != null)
            {
                this.dataPlot.Plot.Remove(this.currentPlot);
            }

            var domain = this.frameProcessor.GetProcessedDomain()?.ToArray();
            this.displayedY = this.frameProcessor.GetProcessedFrame().ToArray();
            this.currentPlot = this.dataPlot.Plot.AddSignal(
                this.displayedY,
                1
                );
            var valueFormat = "F0";

            if (domain == null)
            {
                var frameLenInTicks = this.displayedY.Count();
                var actualXTickPlot = Enumerable.Range(0, (frameLen) / 10).Select(t => (double)10 * t).Select(i => i * frameLenInTicks / frameLen);
                var displayedXTickPlot = Enumerable.Range(0, (frameLen) / 10).Select(t => (double)10 * t);


                

                this.dataPlot.Plot.XAxis.ManualTickPositions(actualXTickPlot.ToArray(), displayedXTickPlot.Select(d => d.ToString(valueFormat)).ToArray());
            }
            else
            {
                var xTicks = 10;
                var actualXTickPlot = Enumerable.Range(0, xTicks).Select(t => (double)t * domain.Length / xTicks);
                var displayedXTickPlot = Enumerable.Range(0, xTicks).Select(t => t * domain.Length / xTicks).Select(i => domain[i]);

                this.dataPlot.Plot.XAxis.ManualTickPositions(actualXTickPlot.ToArray(), displayedXTickPlot.Select(d => d.ToString(valueFormat)).ToArray());
            }

            

            var yRange = this.frameProcessor.GetSingleFrameRange();
            var tickLength = (yRange.Item2 - yRange.Item1) / (yTicks - 1);

            var yTickPlot = Enumerable.Range(0, yTicks).Select(i => yRange.Item1 + i * tickLength);

            var valueFormat2 = tickLength < 0.01 ? "F3" : "F2";

            this.dataPlot.Plot.YAxis.ManualTickPositions(yTickPlot.ToArray(), yTickPlot.Select(d => d.ToString(valueFormat2)).ToArray());

            this.dataPlot.Refresh();

            this.dataPlot.Visible = true;
            this.savePlotButton.Enabled = true;
        }

        private void ShowPlotFrames()
        {
            if (this.clipLoaded)
            {
                this.actualX = Enumerable.Range(0, clipsPerPlot).Select(n => (double)n).ToArray();
                this.displayedX = Enumerable.Range(0, clipsPerPlot).Select(n => (double)n).ToArray();


                var startIdx = (int)Math.Floor(this.actualX[0]);
                var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

                this.displayedY = this.clipProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();
            }
            else
            {
                this.actualX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();
                this.displayedX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();


                var startIdx = (int)Math.Floor(this.actualX[0]);
                var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

                this.displayedY = this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();
                if (this.silenceShown && this.silenceManager.isLoaded)
                {
                    this.nonSilentY = this.silenceManager.GetProcessedFrames(this.frameProcessor.processedFrames, startIdx, endIdx).ToArray();
                }
            }


            if (this.currentPlot != null)
            {
                this.dataPlot.Plot.Remove(this.currentPlot);
            }
            if (this.silencePlot != null)
            {
                this.dataPlot.Plot.Remove(this.silencePlot);
            }

            //this.dataPlot.Refresh();
            this.currentPlot = this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            if (this.silenceShown && this.silenceManager.isLoaded)
            {
                this.silencePlot = this.dataPlot.Plot.AddSignal(
                    nonSilentY,
                    1,
                    Color.Yellow
                    );
            }


            this.SetupXTick();
            this.SetupYTick();

            this.dataPlot.Refresh();
            if (this.currentHandler == null)
            {
                this.currentHandler = new EventHandler(this.RefreshPlotEvent);
                this.timeManager.perSecondTimer.Tick += this.currentHandler;
            }


            this.dataPlot.Visible = true;
            this.savePlotButton.Enabled = true;
        }

        public void SavePlot(string filePath)
        {
            this.dataPlot.Plot.Style(figureBackground: Color.White);
            var bmp = this.dataPlot.Plot.Render();
            bmp.Save(filePath.Replace(".wav", ".jpg"));;
        }

        public int GetFrameLen()
        {
            return this.frameProcessor.GetFrameNumber();
        }

        private void SetupYTick()
        {
            var yRange = this.clipLoaded ? this.clipProcessor.GetRange() : this.frameProcessor.GetRange();
            var tickLength = (yRange.Item2 - yRange.Item1) / (yTicks - 1);

            var yTickPlot = Enumerable.Range(0, yTicks).Select(i => yRange.Item1 + i * tickLength);

            var valueFormat = tickLength < 0.01 ? "F3" : "F2";

            this.dataPlot.Plot.YAxis.ManualTickPositions(yTickPlot.ToArray(), yTickPlot.Select(d => d.ToString(valueFormat)).ToArray());
        }
        private void SetupXTick()
        {
            var xRangeSeconds = (0, secondsOnPlot);
            var tickLengthSeconds = (xRangeSeconds.Item2 - xRangeSeconds.Item1) / (secondsOnPlot - 1);

            var xRange = (0, this.clipLoaded ? clipsPerPlot : framesPerPlot);
            var tickLength = (xRange.Item2 - xRange.Item1) / (secondsOnPlot - 1);

            this.displayedXSeconds = Enumerable.Range(0, secondsOnPlot).Select(i => xRangeSeconds.Item1 + i * tickLengthSeconds).ToList();
            this.actualXSeconds = Enumerable.Range(0, secondsOnPlot).Select(i => (double)(xRange.Item1 + i * tickLength)).ToArray();

            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualXSeconds, this.displayedXSeconds.Select(d => d.ToString()).ToArray());
            
        }

        private void RefreshPlotEvent(object sender, EventArgs e)
        {
            if (this.timeManager.IsPaused) { return; }

            var progressValue = this.clipLoaded ? this.clipsPerSecond : this.framesPerSecond;
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.actualX[i] = this.actualX[i] + progressValue;
                
            }
            for (int i = 0; i < this.displayedXSeconds.Count; i++)
            {
                this.displayedXSeconds[i] = this.displayedXSeconds[i] + 1;
            }

            var startIdx = (int)Math.Floor(this.actualX[0]);
            var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

            var newDisplayedY = this.clipLoaded ?
                this.clipProcessor.GetProcessedFrames(startIdx, endIdx).ToArray() :
                this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();


            for (int i = 0; i < newDisplayedY.Length; i++)
            {
                this.displayedY[i] = newDisplayedY[i];
            }
            for (int j = newDisplayedY.Length; j < this.displayedY.Length; j++)
            {
                this.displayedY[j] = 0;
            }

            if (this.silenceShown && this.silenceManager.isLoaded)
            {
                var newSilenceY = this.silenceManager.GetProcessedFrames(this.frameProcessor.processedFrames, startIdx, endIdx).ToArray();
                for (int i = 0; i < newSilenceY.Length; i++)
                {
                    this.nonSilentY[i] = newSilenceY[i];
                }
                for (int j = newSilenceY.Length; j < this.displayedY.Length; j++)
                {
                    this.nonSilentY[j] = 0;
                }
            }


            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualXSeconds, this.displayedXSeconds.Select(d => d.ToString()).ToArray());
            this.dataPlot.Render();
        }

#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }
}
