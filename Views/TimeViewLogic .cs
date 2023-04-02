using audioCracker.Analysis;
using audioCracker.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Views
{
    public class TimeViewLogic : ViewLogic
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
            base.setupUIComponents(form, playButton, stopButton,fileButton, plotComboBox, loadingPanel,
                estimatedTimeLabel, analysisButton, dataPlot, plotSecondsBox, savePlotBtn, durationLabel, currentLabel, 
                fileLabel, silenceCheckBox);


        }
    }
}
