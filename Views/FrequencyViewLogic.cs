using audioCracker.Analysis;
using audioCracker.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Views
{
    public class FrequencyViewLogic : ViewLogic
    {
  

        public override void setupUIComponents(Form form, Button playButton,
            Button stopButton, Button fileButton,
            ComboBox plotComboBox, Panel loadingPanel,
            Label estimatedTimeLabel, Button analysisButton,
            ScottPlot.FormsPlot dataPlot,
            NumericUpDown plotSecondsBox,
            Button savePlotBtn,
            Label durationLabel, Label currentLabel,
            Label fileLabel, CheckBox silenceCheckBox)
            
        {
            this.analysisManager = new FrameAnalysisManager();

            base.setupUIComponents(form, playButton, stopButton,fileButton, plotComboBox, loadingPanel,
                estimatedTimeLabel, analysisButton, dataPlot, plotSecondsBox, savePlotBtn, durationLabel, currentLabel, 
                fileLabel, silenceCheckBox);
         
        }

        public void setupFrequencyViewLogic(NumericUpDown frameUpDown, TrackBar frameSlider, NumericUpDown lengthUpDown)
        {
            this.frameSlider = frameSlider;
            this.frameUpDown = frameUpDown;
            this.frameControlManager = new FrameControlManager(frameUpDown, frameSlider);
            this.plotManager.currentFrame = 0;
            this.lengthUpDown = lengthUpDown;
        }

    }
}
