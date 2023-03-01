using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Controls
{
    public class ControlManager
    {

        private Button playButton;
        private Button stopButton;
        private Button fileButton;
        private ComboBox plotComboBox;
        private Panel loadingPanel;
        private Label estimatedTimeLabel;

        private const string estimatedLabelTemplate = "Estimated time: {0}m{0}s";

        public ControlManager(Button playButton, 
            Button stopButton, 
            Button fileButton, 
            ComboBox plotComboBox, 
            Panel loadingPanel,
            Label estimatedTimeLabel) { 
            this.playButton = playButton;
            this.stopButton = stopButton;
            this.fileButton = fileButton;
            this.plotComboBox = plotComboBox;
            this.loadingPanel = loadingPanel;
            this.estimatedTimeLabel = estimatedTimeLabel;
        }

        public void EnableControls(bool enabled = true)
        {
            this.playButton.Enabled = enabled;
            this.stopButton.Enabled = enabled;
            this.fileButton.Enabled = enabled;
            this.plotComboBox.Enabled = enabled;
        }

        public void ShowLoadingPanel(bool show = true, int estimatedTime = 0)
        {
            this.loadingPanel.Visible = show;
            if (show)
            {
                var minutes = (estimatedTime / 60).ToString("N2");
                var seconds = (estimatedTime % 60).ToString("N2");
                this.estimatedTimeLabel.Text = string.Format(estimatedLabelTemplate, minutes, seconds);
            }
        }
    }
}
