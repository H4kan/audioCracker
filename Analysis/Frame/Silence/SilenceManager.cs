using audioCracker.Controls;
using audioCracker.Decoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis
{
    public class SilenceManager
    {

        private FrameProcessor zcrProcessor;
        private FrameProcessor volumeProcessor;
        private PlotManager plotManager;

        private bool[] nonSilentFrames;

        private double volumeCond = 0.1;
        private double zcrCond = 0.1;

        public bool isLoaded = false;


        public SilenceManager(PlotManager plotManager, ControlManager controlManager)
        {
            this.zcrProcessor = new FrameProcessor(plotManager, controlManager);
            this.volumeProcessor = new FrameProcessor(plotManager, controlManager);
            this.zcrProcessor.SetAnalyser(new ZCRAnalyser());
            this.volumeProcessor.SetAnalyser(new VolumeAnalyser());
            this.plotManager = plotManager;
        }

        public void LoadFramesIntoSilencer(IEnumerable<IEnumerable<float>> frames)
        {
            this.zcrProcessor.frames = frames;
            this.volumeProcessor.frames = frames;
            this.nonSilentFrames = new bool[frames.Count()];
        }

        private bool IsNonSilent(double volume, double zcr)
        {
            return volume > volumeCond && zcr < zcrCond;
        }

        public void ConductSilenceAnalysis()
        {
            this.isLoaded = false;
            Task.Run(async () =>
            {
                var tasks = new List<Task>() {
                    this.zcrProcessor.StartAnalysis(),
                    this.volumeProcessor.StartAnalysis()
                };
                await Task.WhenAll(tasks);

                this.ProcessNonSilentFrames();
            });
        }

        private void ProcessNonSilentFrames()
        {
            for (int i = 0; i < this.nonSilentFrames.Length; i++)
            {
                this.nonSilentFrames[i] = IsNonSilent(this.volumeProcessor.processedFrames[i], this.zcrProcessor.processedFrames[i]);
            }
            this.isLoaded = true;
            this.plotManager.ShowPlot();
        }

        public IEnumerable<double> GetProcessedFrames(IEnumerable<double> processedFrames, int startFrame, int endFrame)
        {
            var procRange = processedFrames.Skip(startFrame).Take(endFrame - startFrame).ToArray();

            var nonSilentConst = procRange.Max() * 0.5;
            var silenceRange = nonSilentFrames.Skip(startFrame).Take(endFrame - startFrame).ToArray();
            for (int i = 0; i < procRange.Count(); i++)
            {
                yield return silenceRange[i] ? nonSilentConst : 0.0;
            }
        }

    }
}
