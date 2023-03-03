using audioCracker.Analysis;
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
        private Button analysisButton;
        private ComboBox plotComboBox;
        private Panel loadingPanel;
        private Label estimatedTimeLabel;
        public ScottPlot.FormsPlot plot;

        private AnalysisManager analysisManager;

        private string estimatedLabelTemplate = "Estimated time: {0:D2}m{1:D2}s";

        public ControlManager(
            AnalysisManager analysisManager,
            Form form,
            Button playButton, 
            Button stopButton, 
            Button fileButton, 
            ComboBox plotComboBox, 
            Panel loadingPanel,
            Label estimatedTimeLabel,
            Button analysisButton,
            ScottPlot.FormsPlot plot) {
            this.analysisManager = analysisManager;
            this.form = form;
            this.playButton = playButton;
            this.stopButton = stopButton;
            this.fileButton = fileButton;
            this.plotComboBox = plotComboBox;
            this.loadingPanel = loadingPanel;
            this.estimatedTimeLabel = estimatedTimeLabel;
            this.analysisButton = analysisButton;
            this.plot = plot;
        }

        public void ResetPlot()
        {
            this.plot.Visible = false;
            this.analysisButton.Enabled = false;
            this.plotComboBox.SelectedIndex = -1;
        }

        public void InitializeControls()
        {
            this.EnableControls(false);
            this.fileButton.Enabled = true;
            this.plotComboBox.Items.AddRange(this.analysisManager.GetAnalysersNames().ToArray());
        }

        public void EnableControls(bool enabled = true)
        {
            this.playButton.Enabled = enabled;
            this.stopButton.Enabled = enabled;
            this.fileButton.Enabled = enabled;
            this.plotComboBox.Enabled = enabled;
            this.analysisButton.Enabled = this.plotComboBox.SelectedIndex >= 0 && enabled;  
        }

        public void EnableNonPlayControls(bool enabled = true)
        {
            this.fileButton.Enabled = enabled;
            this.plotComboBox.Enabled = enabled;
            this.analysisButton.Enabled = this.plotComboBox.SelectedIndex >= 0 && enabled; ;
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
            if (show && estimatedTime > 0)
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
