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

        public LoaderManager loaderManager;

        public FrameAnalyser currentAnalyser;

        public FrameMerger frameMerger;

        public IEnumerable<IEnumerable<float>> frames;

        public double[] processedFrames;

        public double[] processedFrame;
        public double[]? processedDomain;

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
            var maxies = this.frames.Select(f => f.Select(g => Math.Abs(g))).Select(f => f.Max());
        }

        public int GetFrameNumber()
        {
            return this.frames.Count();
        }

        public void SetAnalyser(FrameAnalyser analyser)
        {
            this.currentAnalyser = analyser;
        }

        public async Task StartAnalysis()
        {

            this.loaderManager.InitLoading();
            this.ConductEstimation();


            this.SetupFrames();


            this.loaderManager.StartLoading();

            await this.FreeLoading();
        }

        public async Task StartFrameAnalysis(int currentFrame)
        {
            this.loaderManager.InitLoading();

            this.SetupFrame();
            this.loaderManager.StartLoading();

            await this.FreeFrameLoading(currentFrame);
        }

        public void SetupFrames()
        {
            this.framesPerThread = this.frames.Count() / numOfThreads;
            if (this.frames.Count() > this.framesPerThread * numOfThreads)
            {
                this.framesPerThread++;
            }

            this.processedFrames = new double[this.frames.Count()];
        }

        public void SetupFrame()
        {
            this.processedFrame = new double[this.frames.ElementAt(0).Count()];

        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.processedFrames.Skip(startFrame).Take(endFrame - startFrame);
        }

        public IEnumerable<double> GetProcessedFrame()
        {
            return this.processedFrame;
        }

        public IEnumerable<double>? GetProcessedDomain()
        {
            return this.processedDomain;
        }

        public (double, double) GetRange()
        {
            return (this.processedFrames.Min(), this.processedFrames.Max());
        }

        public (double, double) GetSingleFrameRange()
        {
            return (this.processedFrame.Min(), this.processedFrame.Max());
        }

        public int GetEstimatedTime()
        {
            return estimatedTimeInSeconds;
        }

        private void ConductEstimation()
        {
            Stopwatch stopwatch = new Stopwatch();

            var frameEst = this.currentAnalyser.FrequencyDomain ? 10 : 500;
            var factor = 18;

            if (this.frames.Count() > 4 * frameEst)
            {
                stopwatch.Start();
                this.frames.Take(frameEst).Select(f => this.currentAnalyser.ConductAnalysis(f)).ToList();
                stopwatch.Stop();

                var estimatedTime = stopwatch.ElapsedMilliseconds * this.frames.Count() * factor / (frameEst * numOfThreads);

                this.estimatedTimeInSeconds = (int)(estimatedTime / 1000);
            }
            else
            {
                this.estimatedTimeInSeconds = 0;
            }
        }

        public bool ConductPartialAnalysis(int index)
        {
            var offset = index * this.framesPerThread;
            var batchFrames =  this.frames
                .Skip(offset)
                .Take(this.framesPerThread)
                .ToArray();
            
            var endCount = Math.Min(this.frames.Count() - offset, this.framesPerThread);

            for (int i = 0; i < endCount; i++)
            {
                this.processedFrames[offset + i] = this.currentAnalyser.ConductAnalysis(batchFrames[i]);
            }
            return true;
        }

        private async Task FreeLoading()
        {
            await Task.Run( async () => { await this.ConductAnalysis(); });
        }

        private async Task FreeFrameLoading(int currentFrame)
        {
            await Task.Run(async () => { await this.ConductFrameAnalysis(currentFrame); });
        }

        private async Task<bool> ConductAnalysis()
        {
            var tasks = Enumerable.Range(0, numOfThreads).Select(it => Task.Run(() =>
            {
                this.ConductPartialAnalysis(it);
            })).ToList();

            await Task.WhenAll(tasks);

 
            this.loaderManager.StopLoading();



            return true;
        }

        private async Task<bool> ConductFrameAnalysis(int currentFrame)
        {
            await Task.Run(() =>
            {
                var result = this.currentAnalyser.ConductFrameAnalysis(this.frames.ElementAt(currentFrame));
                this.processedFrame = new double[result.Item2.Count()];
                result.Item2.CopyTo(this.processedFrame, 0);
                if (result.Item1 != null)
                {
                    this.processedDomain = new double[result.Item1.Count()];
                    result.Item1.CopyTo(this.processedDomain, 0);
                }
                else
                {
                    this.processedDomain = null;
                }
                

            });

            this.loaderManager.StopLoading();

            return true;
        }
    }
}
