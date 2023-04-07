using audioCracker.Decoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Decoder
{
    public class FrameMerger
    {

        public static int frameLenInMs = 40;
        private const float frameOverLapPercentage = 0.1F;

        private WavDecoder decoder;

        public FrameMerger() { 
            this.decoder = new WavDecoder();
        }

        public IEnumerable<IEnumerable<float>> GetFrameDividedAmplitudes(string path, int durationInMs)
        {
            var amps = this.decoder.ReadAmplitudesFromFile(path);
            return this.DivideIntoFrames(Normalize(amps), durationInMs);
        }

        private IEnumerable<IEnumerable<float>> DivideIntoFrames(IEnumerable<float> amplitudes, int durationInMs)
        {
            int ampsPerMs = amplitudes.Count() / durationInMs;

            int ampsPerFrame = ampsPerMs * frameLenInMs;

            int frameLeap = (int)Math.Floor((1 - frameOverLapPercentage) * ampsPerFrame);
            
            int startIndex = 0;

            var frames = new List<IEnumerable<float>>();

            int boundaryIndex = amplitudes.Count() - ampsPerFrame;

            while (startIndex < boundaryIndex) {

                frames.Add(amplitudes.Skip(startIndex).Take(ampsPerFrame));
                startIndex += frameLeap;
            
            }

            return frames;

        }

        private IEnumerable<float> Normalize(IEnumerable<float> amplitudes)
        {
            var max = amplitudes.Select(a => Math.Abs(a)).Max();

            return amplitudes.Select(a => a / max);
        }

    }
}
