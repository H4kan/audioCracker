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

        private FrameProcessor frameProcessor;

        private int framesPerSecond;

        private int framesPerPlot;

        private int yTicks = 10;

        public PlotManager(FormsPlot dataPlot, TimeManager timeManager, ControlManager controlManager) {
            this.dataPlot = dataPlot;
            this.timeManager = timeManager;
            this.frameProcessor = new FrameProcessor(this, controlManager);

            this.timeManager.perSecondTimer.Tick += new EventHandler(this.RefreshPlotEvent);


            this.dataPlot.Plot.XLabel("Time");
            this.dataPlot.Plot.YLabel("Volume");

            this.framesPerSecond = 25;
            this.framesPerPlot = this.framesPerSecond * 10;
        }

        public void LoadFile(string path, int durationInMs) {
            
            this.frameProcessor.LoadFramesFromFile(path, durationInMs);
            this.frameProcessor.SetAnalyser(new VolumeAnalyser());

            //this.ShowPlot();
        }

        public void ShowPlot()
        {
            this.actualX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();
            this.displayedX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();



            var startIdx = (int)Math.Floor(this.actualX[0]);
            var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

            this.displayedY = this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();

            var range = this.frameProcessor.GetRange();
            var tickLength = (range.Item2 - range.Item1) / (yTicks - 1);

            var yTickPlot = Enumerable.Range(0, yTicks).Select(i => range.Item1 + i * tickLength);

            this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            this.dataPlot.Plot.YAxis.ManualTickPositions(yTickPlot.ToArray(), yTickPlot.Select(d => d.ToString("F2")).ToArray());
            //this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX, this.actualX.Select(d => d.ToString("N1")).ToArray());
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.actualX[i] = this.actualX[i] + this.framesPerSecond;
            }
            this.dataPlot.Refresh();

        }

        private void RefreshPlotEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.actualX[i] = this.actualX[i] + this.framesPerSecond;
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

            //this.dataPlot.Plot.Remove(this.signalPlot);
            //this.signalPlot = this.dataPlot.Plot.AddSignal(
            //    displayedY,
            //    1
            //    );
            //this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX, this.displayedX.Select(d => d.ToString("N1")).ToArray());
            this.dataPlot.Render();
        }

#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }
}
