using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Analysis.Frequency
{
    public class MaxFrequencyResolver
    {

        private NumericUpDown maxFrequencyUpDown;

        public MaxFrequencyResolver(NumericUpDown maxFrequencyUpDown)
        {
            this.maxFrequencyUpDown = maxFrequencyUpDown;
        }

        public double GetMaxFrequency()
        {
            return (double)this.maxFrequencyUpDown.Value;
        }

    }
}
