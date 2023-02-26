using audioCracker.Analysis;
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
        private IAnalyser analyser;
        private TimeManager timeManager;

        private double[] displayedX;
        private double[] actualX;
        private double[] displayedY;

        private SignalPlot signalPlot;

        public PlotManager(FormsPlot dataPlot, TimeManager timeManager) {
            this.dataPlot = dataPlot;
            this.analyser = new VolumeAnalyser();
            this.timeManager = timeManager;


            this.timeManager.perSecondTimer.Tick += new EventHandler(this.RefreshPlotEvent);


            this.dataPlot.Plot.XLabel("Time");
            this.dataPlot.Plot.YLabel("Volume");
        }

        public void ShowPlot()
        {
            this.displayedX = Enumerable.Range(0, 10).Select(n => (double)n).ToArray();
            this.actualX = Enumerable.Range(0, 10).Select(n => (double)n).ToArray();
            this.displayedY = this.analyser.ConductAnalysis(this.displayedX).ToArray();
            this.signalPlot = this.dataPlot.Plot.AddSignal(
                displayedY,
                1
                );
            this.dataPlot.Plot.XAxis.ManualTickPositions(this.actualX, this.displayedX.Select(d => d.ToString("N1")).ToArray());
            this.dataPlot.Refresh();
        }

        private void RefreshPlotEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < this.displayedX.Length; i++)
            {
                this.displayedX[i] = this.displayedX[i] + 1;
            }

            var newData = this.analyser.ConductAnalysis(this.displayedX).ToList();
            
            for (int i = 0; i < this.displayedY.Length; i++)
            {
                this.displayedY[i] = newData[i];
            }
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
