using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audioCracker.Controls
{
    public class ControlManager
    {
        public Form form;
        private Button playButton;
        private Button stopButton;
        private Button fileButton;
        private ComboBox plotComboBox;
        private Panel loadingPanel;
        private Label estimatedTimeLabel;

        private string estimatedLabelTemplate = "Estimated time: {0:D2}m{1:D2}s";

        public ControlManager(
            Form form,
            Button playButton, 
            Button stopButton, 
            Button fileButton, 
            ComboBox plotComboBox, 
            Panel loadingPanel,
            Label estimatedTimeLabel) {
            this.form = form;
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

        public void ShowInitialLoadingPanel(bool show = true)
        {
            this.loadingPanel.Visible = show;
            if (show)
            {
                this.estimatedTimeLabel.Text = "Estimated time: ......";
                this.form.Invalidate();
                this.form.Update();
                this.form.Refresh();
                Application.DoEvents();
            }
        }

        public void ShowLoadingPanel(bool show = true, int estimatedTime = 0)
        {
            this.loadingPanel.Visible = show;
            if (show)
            {
                var minutes = (estimatedTime / 60);
                var seconds = (estimatedTime % 60);
                this.estimatedTimeLabel.Text = string.Format(estimatedLabelTemplate, minutes, seconds);
                this.form.Invalidate();
                this.form.Update();
                this.form.Refresh();
                Application.DoEvents();
            }
        }
    }
}
