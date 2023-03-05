using audioCracker.Analysis;
using audioCracker.Controls;
using audioCracker.Loading;
using System.Media;
using System.Security;
using System.Windows.Forms;

namespace audioCracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.setupUIComponents();
        }

        private OpenFileDialog openFileDialog;
        private Wavplayer soundPlayer;
        private PlotManager plotManager;
        private TimeManager timeManager;
        private ControlManager controlManager;
        private AnalysisManager analysisManager;

        private void setupUIComponents()
        {
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*;";

            this.analysisManager = new AnalysisManager();
            this.controlManager = new ControlManager(
                this.analysisManager,
                this,
                this.playButton, 
                this.stopButton, this.fileButton, 
                this.plotComboBox, this.loadingPanel,
                this.estimatedTimeLabel,
                this.analysisButton,
                this.dataPlot,
                this.plotSecondsBox);

            this.timeManager = new TimeManager();

            this.plotManager = new PlotManager(this.dataPlot, this.timeManager, this.controlManager, this.analysisManager);

            this.soundPlayer = new Wavplayer(this.playButton, this.stopButton, 
                this.durationLabel, this.currentLabel, this.timeManager, this.controlManager, this.plotManager);

            this.plotManager.ChangeSecondsOnPlot((int)this.plotSecondsBox.Value + 1);
            
            this.controlManager.InitializeControls();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.fileLabel.Text = openFileDialog.SafeFileName;
                    this.soundPlayer.Setup(openFileDialog.FileName);
                    this.controlManager.ResetPlot();
                    this.plotManager.LoadFile(openFileDialog.FileName, this.soundPlayer.GetDurationInMs());

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.soundPlayer.Play();
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.soundPlayer.Stop();
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.soundPlayer.Stop();

            this.plotManager.StartAnalysis();
        }

        private void plotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.plotComboBox.SelectedIndex >= 0)
            {
                this.analysisButton.Enabled = true;
#pragma warning disable CS8604 // Possible null reference argument.
                this.analysisManager.ChangeAnalyser(this.plotComboBox.SelectedItem.ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                if (this.analysisManager.GetAnalyser().Item2 != null)
                {
                    this.silenceCheckBox.Checked = false;
                    this.silenceCheckBox.Enabled = false;
                    this.plotManager.EnableSilence(false);
                }
                else
                {
                    this.silenceCheckBox.Enabled = true;
                }
            }
        }

        private void plotSecondsBox_ValueChanged(object sender, EventArgs e)
        {
            this.plotManager.ChangeSecondsOnPlot((int)this.plotSecondsBox.Value + 1);
        }

        private void silenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.plotManager.EnableSilence(this.silenceCheckBox.Checked);
        }
    }
}