using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.Frame.Helpers
{
    public static class Helpers
    {
        private static float voicingThreshold = 0.3f;


        public static bool IsVoicedFrame(List<float> frame)
        {
            return frame.Where(f => f > voicingThreshold).Any();
        }

        public static int FloorPower2(int num)
        {
            num--;
            num |= num >> 1;
            num |= num >> 2;
            num |= num >> 4;
            num |= num >> 8;
            num |= num >> 16;
            num++;
            return num / 2;
        }
    }
}
