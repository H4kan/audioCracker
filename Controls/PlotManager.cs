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

        private SignalPlot signalPlot;

        private FrameProcessor frameProcessor;

        private int framesPerSecond;

        private int framesPerPlot;

        public PlotManager(FormsPlot dataPlot, TimeManager timeManager) {
            this.dataPlot = dataPlot;
            this.timeManager = timeManager;
            this.frameProcessor = new FrameProcessor();

            this.timeManager.perSecondTimer.Tick += new EventHandler(this.RefreshPlotEvent);


            this.dataPlot.Plot.XLabel("Time");
            this.dataPlot.Plot.YLabel("Volume");

            this.framesPerSecond = 25;
            this.framesPerPlot = this.framesPerSecond * 10;
        }

        public void LoadFile(string path, int durationInMs) {
            
            this.frameProcessor.LoadFramesFromFile(path, durationInMs);
            this.frameProcessor.SetAnalyser(new VolumeAnalyser());

            this.ShowPlot();
        }

        public void ShowPlot()
        {
            this.actualX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();
            this.displayedX = Enumerable.Range(0, framesPerPlot).Select(n => (double)n).ToArray();



            var startIdx = (int)Math.Floor(this.actualX[0]);
            var endIdx = (int)Math.Floor(this.actualX[this.actualX.Length - 1]);

            this.displayedY = this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();

            this.signalPlot = this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX., this.actualX.Select(d => d.ToString("N1")).ToArray());
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

            this.displayedY = this.frameProcessor.GetProcessedFrames(startIdx, endIdx).ToArray();

            this.dataPlot.Plot.Remove(this.signalPlot);
            this.signalPlot = this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX, this.displayedX.Select(d => d.ToString("N1")).ToArray());
            this.dataPlot.Render();
        }

#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }
}
