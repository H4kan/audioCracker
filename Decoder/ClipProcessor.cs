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
    public class ClipProcessor
    {

        private LoaderManager loaderManager;

        private IClipAnalyser currentAnalyser;

        private FrameProcessor frameProcessor;

        private double[] processedClips;

        private IEnumerable<IGrouping<int, double>> clips;

        public int framesPerClip = 25;

        private int numberOfClips;

        private int estimatedTimeInSeconds;

        private int numOfThreads = 8;

        private int clipsPerThread;

        public ClipProcessor(FrameProcessor frameProcessor) {
            this.loaderManager = frameProcessor.loaderManager;
            this.frameProcessor = frameProcessor;
        }


        public void SetAnalyser(IClipAnalyser analyser)
        {
            this.currentAnalyser = analyser;
        }

        public void StartAnalysis()
        {
            this.loaderManager.InitLoading();

            this.frameProcessor.SetupFrames();
            this.numberOfClips = this.frameProcessor.frames.Count() / framesPerClip;
            if (this.frameProcessor.frames.Count() > this.numberOfClips * framesPerClip)
            {
                this.numberOfClips++;
            }
            this.clipsPerThread = numberOfClips / numOfThreads;
            if (numberOfClips > this.clipsPerThread * numOfThreads)
            {
                this.clipsPerThread++;
            }

            this.ConductEstimation();

            this.processedClips = new double[numberOfClips];

            this.loaderManager.StartLoading();
            this.FreeLoading();
        }

        public IEnumerable<double> GetProcessedFrames(int startFrame, int endFrame)
        {
            return this.processedClips.Skip(startFrame).Take(endFrame - startFrame);
        }

        public (double, double) GetRange()
        {
            return (this.processedClips.Min(), this.processedClips.Max());
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

            if (numberOfClips > 4 * frameEst)
            {
                stopwatch.Start();

                var eFrames = this.frameProcessor.frames.Take(frameEst)
                    .Select(f => this.frameProcessor.currentAnalyser.ConductAnalysis(f)).ToList();
                var clips = eFrames.Select((f, i) => new { f, i }).GroupBy(g => g.i / this.framesPerClip, g => g.f);

                var procClips = clips.Select(g => this.currentAnalyser.ConductAnalysis(g)).ToList();


                stopwatch.Stop();

                var estimatedTime = stopwatch.ElapsedMilliseconds * numberOfClips * factor / (frameEst * numOfThreads);

                this.estimatedTimeInSeconds = (int)(estimatedTime / 1000);
            }
            else
            {
                this.estimatedTimeInSeconds = 0;
            }
        }

        private bool ConductPartialAnalysis(int index)
        {
            var offset = index * this.clipsPerThread;
            var batchClips =  this.clips
                .Skip(offset)
                .Take(this.clipsPerThread)
                .ToArray();
            

            var endCount = Math.Min(this.clips.Count() - offset, this.clipsPerThread);

            for (int i = 0; i < endCount; i++)
            {
                this.processedClips[offset + i] = this.currentAnalyser.ConductAnalysis(batchClips[i]);
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
                this.frameProcessor.ConductPartialAnalysis(it);
            }));
            await Task.WhenAll(tasks);

            this.clips = this.frameProcessor.processedFrames
                .Select((f, i) => new { f, i }).GroupBy(g => g.i / this.framesPerClip, g => g.f);
            var tasks2 = Enumerable.Range(0, numOfThreads).Select(it => Task.Run(() =>
            {
                this.ConductPartialAnalysis(it);
            }));
            await Task.WhenAll(tasks2);

            this.loaderManager.StopLoading();
        }
    }
}
