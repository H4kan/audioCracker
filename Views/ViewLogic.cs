using audioCracker.Analysis;
using audioCracker.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Views
{
    public class ViewLogic
    {
        public OpenFileDialog openFileDialog;
    
        public PlotManager plotManager;
        public TimeManager timeManager;
        public ControlManager controlManager;
        public AnalysisManager analysisManager;

        public Wavplayer soundPlayer;

        public string filePath = "";

        public Label fileLabel;
        public ComboBox plotComboBox;
        public Button analysisButton;
        public CheckBox silenceCheckBox;
        public NumericUpDown plotSecondsBox;

        public NumericUpDown frameUpDown = new NumericUpDown();
        public TrackBar frameSlider = new TrackBar();

        public FrameControlManager frameControlManager;

        public NumericUpDown lengthUpDown = new NumericUpDown();

        public NumericUpDown minFreq;
        public NumericUpDown maxFreq;

        public Panel freqRangePanel;

        public virtual void setupUIComponents(Form form, Button playButton,
            Button stopButton, Button fileButton,
            ComboBox plotComboBox, Panel loadingPanel,
            Label estimatedTimeLabel, Button analysisButton,
            ScottPlot.FormsPlot dataPlot,
            NumericUpDown plotSecondsBox,
            Button savePlotBtn,
            Label durationLabel, Label currentLabel,
            Label fileLabel, CheckBox silenceCheckBox,
            NumericUpDown minFreq, NumericUpDown maxFreq,
            Panel freqRangePanel)
        {

            this.fileLabel = fileLabel;
            this.plotComboBox = plotComboBox;
            this.analysisButton = analysisButton;
            this.silenceCheckBox = silenceCheckBox;
            this.plotSecondsBox = plotSecondsBox;
            this.plotSecondsBox.Value = 4;


            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*;";

            this.minFreq = minFreq;
            this.maxFreq = maxFreq;

            if (this.analysisManager == null)
            {
                this.analysisManager = new AnalysisManager(minFreq, maxFreq);
            }

            this.controlManager = new ControlManager(
                this.analysisManager,
                form,
                playButton,
                stopButton, fileButton,
                plotComboBox, loadingPanel,
                estimatedTimeLabel,
                analysisButton,
                dataPlot,
                plotSecondsBox,
                savePlotBtn);

            this.timeManager = new TimeManager();

            this.plotManager = new PlotManager(dataPlot, timeManager, this.controlManager, this.analysisManager, savePlotBtn);


            this.soundPlayer = new Wavplayer(playButton, stopButton,
                durationLabel, currentLabel, this.timeManager, this.controlManager, this.plotManager);

            this.plotManager.ChangeSecondsOnPlot((int)plotSecondsBox.Value + 1);

            this.controlManager.InitializeControls();

            this.frameControlManager = new FrameControlManager(this.frameUpDown, this.frameSlider);

            this.lengthUpDown.Value = 40;
            this.freqRangePanel = freqRangePanel;

    }
    }
}
