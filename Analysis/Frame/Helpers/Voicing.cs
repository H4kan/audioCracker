using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.Frame.Helpers
{
    public static class Voicing
    {
        private static float voicingThreshold = 0.3f;


        public static bool IsVoicedFrame(List<float> frame)
        {
            return frame.Where(f => f > voicingThreshold).Any();
        }
    }
}
