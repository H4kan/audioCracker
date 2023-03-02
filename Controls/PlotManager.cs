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

        private double[] displayedX;
        private double[] actualX;
        private double[] displayedY;
        private List<int> displayedXSeconds;
        private double[] actualXSeconds;

        private FrameProcessor frameProcessor;

        private int framesPerSecond;

        private int framesPerPlot;

        private int yTicks = 10;

        private int secondsOnFrame = 5;

        public PlotManager(FormsPlot dataPlot, TimeManager timeManager, ControlManager controlManager) {
            this.dataPlot = dataPlot;
            this.timeManager = timeManager;
            this.frameProcessor = new FrameProcessor(this, controlManager);

            this.timeManager.perSecondTimer.Tick += new EventHandler(this.RefreshPlotEvent);


            this.dataPlot.Plot.XLabel("Time");
            this.dataPlot.Plot.YLabel("Volume");

            this.framesPerSecond = 25;
            this.framesPerPlot = this.framesPerSecond * secondsOnFrame;
        }

        public void ChangeSecondsOnPlot(int seconds)
        {
            this.framesPerSecond = seconds + 1;
        }

        public void LoadFile(string path, int durationInMs) {
            
            this.frameProcessor.LoadFramesFromFile(path, durationInMs);
            this.frameProcessor.SetAnalyser(new VolumeAnalyser());

        }

        public void ShowPlot()
        {
            this.actualX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();
            this.displayedX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();


            var startIdx = (int)Math.Floor(this.actualX[0]);
            var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

            this.displayedY = this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();

           

            this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            
            this.SetupXTick();
            this.SetupYTick();
            //this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX, this.actualX.Select(d => d.ToString("N1")).ToArray());
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.actualX[i] = this.actualX[i] + this.framesPerSecond;
            }
            this.dataPlot.Refresh();

        }

        private void SetupYTick()
        {
            var yRange = this.frameProcessor.GetRange();
            var tickLength = (yRange.Item2 - yRange.Item1) / (yTicks - 1);

            var yTickPlot = Enumerable.Range(0, yTicks).Select(i => yRange.Item1 + i * tickLength);
            
            this.dataPlot.Plot.YAxis.ManualTickPositions(yTickPlot.ToArray(), yTickPlot.Select(d => d.ToString("F2")).ToArray());
        }
        private void SetupXTick()
        {
            var xRangeSeconds = (0, secondsOnFrame);
            var tickLengthSeconds = (xRangeSeconds.Item2 - xRangeSeconds.Item1) / (secondsOnFrame - 1);

            var xRange = (0, framesPerPlot);
            var tickLength = (xRange.Item2 - xRange.Item1) / (secondsOnFrame - 1);

            this.displayedXSeconds = Enumerable.Range(0, secondsOnFrame).Select(i => xRangeSeconds.Item1 + i * tickLengthSeconds).ToList();
            this.actualXSeconds = Enumerable.Range(0, secondsOnFrame).Select(i => (double)(xRange.Item1 + i * tickLength)).ToArray();

            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualXSeconds, this.displayedXSeconds.Select(d => d.ToString()).ToArray());
        }

        private void RefreshPlotEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.actualX[i] = this.actualX[i] + this.framesPerSecond;
                
            }
            for (int i = 0; i < this.displayedXSeconds.Count; i++)
            {
                this.displayedXSeconds[i] = this.displayedXSeconds[i] + 1;
            }

            var startIdx = (int)Math.Floor(this.actualX[0]);
            var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

            var newDisplayedY =  this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();


            for (int i = 0; i < newDisplayedY.Length; i++)
            {
                this.displayedY[i] = newDisplayedY[i];
            }
            for (int j = newDisplayedY.Length; j < this.displayedY.Length; j++)
            {
                this.displayedY[j] = 0;
            }

            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualXSeconds, this.displayedXSeconds.Select(d => d.ToString()).ToArray());
            this.dataPlot.Render();
        }

#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }
}
