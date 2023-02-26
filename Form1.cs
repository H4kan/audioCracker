using audioCracker.Controls;
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

        private void setupUIComponents()
        {
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*;";
            this.soundPlayer = new Wavplayer(this.playButton, this.stopButton, this.durationLabel, this.currentLabel, this.playPanel);
        
            
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.fileLabel.Text = openFileDialog.SafeFileName;
                    this.soundPlayer.Setup(openFileDialog.FileName);

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

    }
}