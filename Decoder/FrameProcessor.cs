using audioCracker.Analysis;
using audioCracker.Controls;
using audioCracker.Loading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace audioCracker.Decoder
{
    public class FrameProcessor
    {

        private LoaderManager loaderManager;

        private IFrameAnalyser currentAnalyser;

        private FrameMerger frameMerger;

        private IEnumerable<IEnumerable<float>> frames;

        private double[] processedFrames;

        private int estimatedTimeInSeconds;

        private const int numOfThreads = 8;

        private int framesPerThread;

        public FrameProcessor(PlotManager plotManager, ControlManager controlManager) { 
            this.frameMerger = new FrameMerger();
            this.loaderManager = new LoaderManager(this, plotManager, controlManager);
        }

        public void LoadFramesFromFile(string filename, int durationInMs)
        {
            this.frames = this.frameMerger.GetFrameDividedAmplitudes(filename, durationInMs);
        }


        public void SetAnalyser(IFrameAnalyser analyser)
        {
            this.currentAnalyser = analyser;

            this.loaderManager.InitLoading();
            this.ConductEstimation();

            this.framesPerThread = this.frames.Count() / numOfThreads;
            if (this.frames.Count() > this.framesPerThread * numOfThreads)
            {
                this.framesPerThread++;
            }

            this.processedFrames = new double[this.frames.Count()];
            
            
            this.loaderManager.StartLoading();
            this.FreeLoading();
        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.processedFrames.Skip(startFrame).Take(endFrame - startFrame);
        }

        public (double, double) GetRange()
        {
            return (this.processedFrames.Min(), this.processedFrames.Max());
        }

        public int GetEstimatedTime()
        {
            return estimatedTimeInSeconds;
        }

        private void ConductEstimation()
        {
            Stopwatch stopwatch = new Stopwatch();

            var frameEst = 500;
            var factor = 18;

            stopwatch.Start();
            this.frames.Take(frameEst).Select(f => this.currentAnalyser.ConductAnalysis(f)).ToList();
            stopwatch.Stop();

            var estimatedTime = stopwatch.ElapsedMilliseconds * this.frames.Count() * factor / (frameEst * numOfThreads);

            this.estimatedTimeInSeconds = (int)(estimatedTime / 1000);
        }

        private bool ConductPartialAnalysis(int index)
        {
            var offset = index * this.framesPerThread;
            var batchFrames =  this.frames
                .Skip(offset)
                .Take(this.framesPerThread)
                .ToArray();
            
            var endCount = Math.Min(this.frames.Count() - offset, this.framesPerThread);

            for (int i = 0; i < endCount; i++)
            {
                this.processedFrames[offset + i] = Math.Sqrt(batchFrames[i].Average(d => d * d));
            }
            return true;
        }

        private void FreeLoading()
        {
            var childThRef = new ThreadStart(this.ConductAnalysis);

            var childThread = new Thread(childThRef);
            childThread.Start();


        }

        private async void ConductAnalysis()
        {
            var tasks = Enumerable.Range(0, numOfThreads).Select(it => Task.Run(() =>
            {
                this.ConductPartialAnalysis(it);
            }));

            await Task.WhenAll(tasks);

            this.loaderManager.StopLoading();
        }
    }
}
