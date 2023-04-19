using audioCracker.Analysis;
using audioCracker.Controls;
using audioCracker.Decoder;
using audioCracker.Loading;
using audioCracker.Views;
using System.Media;
using System.Security;
using System.Windows.Forms;

namespace audioCracker
{
    public partial class Form1 : Form
    {
        private TimeViewLogic timeViewLogic;
        private FrequencyViewLogic frequencyViewLogic;

        private ViewLogic currentLogic;

        public Form1()
        {
            InitializeComponent();
            this.setupViews();
        }

        private void setupViews()
        {
            this.timeViewLogic = new TimeViewLogic();


            timeViewLogic.setupUIComponents(
                this, playButton, stopButton, fileButton,
                plotComboBox, loadingPanel, estimatedTimeLabel,
                analysisButton, dataPlot, plotSecondsBox,
                savePlotBtn, durationLabel, currentLabel,
                fileLabel, silenceCheckBox, bottomFreqRange, upFreqRange,
                freqRangePanel);

            this.frequencyViewLogic = new FrequencyViewLogic();

            frequencyViewLogic.setupUIComponents(
                this, new Button(), new Button(), fileButton2,
                plotComboBox2, loadingPanel2, estimatedTimeLabel2,
                analysisButton2, dataPlot2, new NumericUpDown(),
                savePlotBtn2, new Label(), new Label(),
                fileLabel2, new CheckBox(),
                new NumericUpDown(), new NumericUpDown(), new Panel());

            frequencyViewLogic.setupFrequencyViewLogic(frameUpDown, frameSlider, lengthUpDown);

            this.currentLogic = timeViewLogic;
        }


        private void fileButton_Click(object sender, EventArgs e)
        {
            this.fileButtonClick();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.playButtonClick();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.stopButtonClick();
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.analysisButtonClick();
        }

        private void plotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plotComboBoxSelectedIndexChange();
        }

        private void plotSecondsBox_ValueChanged(object sender, EventArgs e)
        {
            this.plotSecondsBoxValueChange();
        }

        private void silenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.silenceCheckBoxChange();
        }

        private void savePlotBtn_Click(object sender, EventArgs e)
        {
            this.savePlot();
        }

        private void fileButton2_Click(object sender, EventArgs e)
        {
            this.fileButtonClick();
        }

        private void savePlotBtn2_Click(object sender, EventArgs e)
        {
            this.savePlot();
        }

        private void analysisButton2_Click(object sender, EventArgs e)
        {
            this.analysisButtonClick();
        }

        private void plotComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plotComboBoxSelectedIndexChange();
        }

        private void fileButtonClick()
        {
            if (this.currentLogic.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.currentLogic.fileLabel.Text = this.currentLogic.openFileDialog.SafeFileName;
                    this.currentLogic.filePath = this.currentLogic.openFileDialog.FileName;
                    FrameMerger.frameLenInMs = (int)this.currentLogic.lengthUpDown.Value;
                    this.currentLogic.plotManager.framesPerSecond = 1000 / FrameMerger.frameLenInMs;

                    this.currentLogic.soundPlayer.Setup(this.currentLogic.openFileDialog.FileName);

                    this.currentLogic.controlManager.ResetPlot();
                    this.currentLogic.plotManager.LoadFile(this.currentLogic.openFileDialog.FileName,
                        this.currentLogic.soundPlayer.GetDurationInMs());

                    this.currentLogic.frameSlider.Enabled = true;
                    this.currentLogic.frameUpDown.Enabled = true;

                    this.currentLogic.frameControlManager.SetBoundary(this.currentLogic.plotManager.GetFrameLen());

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void playButtonClick()
        {
            this.currentLogic.soundPlayer.Play();
        }

        private void stopButtonClick()
        {
            this.currentLogic.soundPlayer.Stop();
        }

        private void analysisButtonClick()
        {
            this.currentLogic.soundPlayer.Stop();

            this.currentLogic.plotManager.StartAnalysis();
        }

        private void plotComboBoxSelectedIndexChange()
        {
            if (this.currentLogic.plotComboBox.SelectedIndex >= 0)
            {
                this.currentLogic.analysisButton.Enabled = true;
#pragma warning disable CS8604 // Possible null reference argument.
                this.currentLogic.analysisManager.ChangeAnalyser(this.currentLogic.plotComboBox.SelectedItem.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                if (this.currentLogic.plotComboBox.SelectedItem.ToString() == "Band Energy"
                    || this.currentLogic.plotComboBox.SelectedItem.ToString() == "Band Energy Ratio"
                    || this.currentLogic.plotComboBox.SelectedItem.ToString() == "Spectral Flatness Measure"
                    || this.currentLogic.plotComboBox.SelectedItem.ToString() == "Spectral Crest Factor")
                {
                    this.currentLogic.freqRangePanel.Visible = true;
                }
                else if (this.currentLogic.analysisManager.GetAnalyser().Item2 != null)
                {
                    this.currentLogic.silenceCheckBox.Checked = false;
                    this.currentLogic.silenceCheckBox.Enabled = false;
                    this.currentLogic.plotManager.EnableSilence(false);
                    this.currentLogic.freqRangePanel.Visible = false;
                }
                else
                {
                    this.currentLogic.silenceCheckBox.Enabled = true;
                    this.currentLogic.freqRangePanel.Visible = false;
                }
            }
        }

        private void plotSecondsBoxValueChange()
        {
            this.currentLogic.plotManager.ChangeSecondsOnPlot((int)this.currentLogic.plotSecondsBox.Value + 1);
        }

        private void silenceCheckBoxChange()
        {
            this.currentLogic.plotManager.EnableSilence(this.silenceCheckBox.Checked);
        }

        private void savePlot()
        {
            this.currentLogic.plotManager.SavePlot(this.currentLogic.filePath);
        }

        private void viewControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.viewControl.SelectedIndex)
            {
                case 0:
                    this.currentLogic = this.timeViewLogic;
                    break;
                case 1:
                    this.currentLogic = this.frequencyViewLogic;
                    break;

            }
        }

        private void frameSlider_Scroll(object sender, EventArgs e)
        {
            this.currentLogic.frameUpDown.Value = this.currentLogic.frameSlider.Value;
            this.currentLogic.plotManager.currentFrame = this.currentLogic.frameSlider.Value;
        }

        private void frameUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.currentLogic.frameSlider.Value = (int)this.currentLogic.frameUpDown.Value;
            this.currentLogic.plotManager.currentFrame = this.currentLogic.frameSlider.Value;
        }

        private void bottomFreqRange_ValueChanged(object sender, EventArgs e)
        {
            this.currentLogic.maxFreq.Minimum = this.currentLogic.minFreq.Value;
        }

        private void upFreqRange_ValueChanged(object sender, EventArgs e)
        {
            this.currentLogic.minFreq.Maximum = this.currentLogic.maxFreq.Value;
        }
    }
}