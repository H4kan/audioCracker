namespace audioCracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileButton = new Button();
            fileLabel = new Label();
            splitContainer1 = new SplitContainer();
            savePlotBtn = new Button();
            playPanel = new Panel();
            label1 = new Label();
            currentLabel = new Label();
            durationLabel = new Label();
            stopButton = new Button();
            playButton = new Button();
            silenceCheckBox = new CheckBox();
            label4 = new Label();
            plotSecondsBox = new NumericUpDown();
            label3 = new Label();
            analysisButton = new Button();
            loadingPanel = new Panel();
            estimatedTimeLabel = new Label();
            label2 = new Label();
            dataPlot = new ScottPlot.FormsPlot();
            plotComboBox = new ComboBox();
            viewControl = new TabControl();
            timePage = new TabPage();
            frequencyPage = new TabPage();
            splitContainer2 = new SplitContainer();
            label5 = new Label();
            lengthUpDown = new NumericUpDown();
            savePlotBtn2 = new Button();
            panel1 = new Panel();
            frameUpDown = new NumericUpDown();
            frameLabel = new Label();
            frameSlider = new TrackBar();
            fileLabel2 = new Label();
            fileButton2 = new Button();
            loadingPanel2 = new Panel();
            estimatedTimeLabel2 = new Label();
            label6 = new Label();
            analysisButton2 = new Button();
            dataPlot2 = new ScottPlot.FormsPlot();
            plotComboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plotSecondsBox).BeginInit();
            loadingPanel.SuspendLayout();
            viewControl.SuspendLayout();
            timePage.SuspendLayout();
            frequencyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lengthUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frameUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameSlider).BeginInit();
            loadingPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // fileButton
            // 
            fileButton.BackColor = Color.Goldenrod;
            fileButton.FlatStyle = FlatStyle.Flat;
            fileButton.ForeColor = SystemColors.HighlightText;
            fileButton.Location = new Point(87, 28);
            fileButton.Margin = new Padding(3, 2, 3, 2);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(181, 38);
            fileButton.TabIndex = 0;
            fileButton.Text = "Select file";
            fileButton.UseVisualStyleBackColor = false;
            fileButton.Click += fileButton_Click;
            // 
            // fileLabel
            // 
            fileLabel.BackColor = SystemColors.HighlightText;
            fileLabel.BorderStyle = BorderStyle.FixedSingle;
            fileLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            fileLabel.ForeColor = SystemColors.ControlText;
            fileLabel.Location = new Point(87, 22);
            fileLabel.Name = "fileLabel";
            fileLabel.Padding = new Padding(4);
            fileLabel.Size = new Size(181, 28);
            fileLabel.TabIndex = 1;
            fileLabel.Text = "File name";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(24, 14);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(savePlotBtn);
            splitContainer1.Panel1.Controls.Add(playPanel);
            splitContainer1.Panel1.Controls.Add(fileButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(silenceCheckBox);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(plotSecondsBox);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(analysisButton);
            splitContainer1.Panel2.Controls.Add(loadingPanel);
            splitContainer1.Panel2.Controls.Add(dataPlot);
            splitContainer1.Panel2.Controls.Add(plotComboBox);
            splitContainer1.Size = new Size(1161, 496);
            splitContainer1.SplitterDistance = 387;
            splitContainer1.TabIndex = 2;
            // 
            // savePlotBtn
            // 
            savePlotBtn.BackColor = Color.Goldenrod;
            savePlotBtn.Enabled = false;
            savePlotBtn.FlatStyle = FlatStyle.Flat;
            savePlotBtn.ForeColor = SystemColors.HighlightText;
            savePlotBtn.Location = new Point(126, 391);
            savePlotBtn.Margin = new Padding(3, 2, 3, 2);
            savePlotBtn.Name = "savePlotBtn";
            savePlotBtn.Size = new Size(110, 38);
            savePlotBtn.TabIndex = 3;
            savePlotBtn.Text = "Save plot";
            savePlotBtn.UseVisualStyleBackColor = false;
            savePlotBtn.Click += savePlotBtn_Click;
            // 
            // playPanel
            // 
            playPanel.Controls.Add(label1);
            playPanel.Controls.Add(currentLabel);
            playPanel.Controls.Add(durationLabel);
            playPanel.Controls.Add(fileLabel);
            playPanel.Controls.Add(stopButton);
            playPanel.Controls.Add(playButton);
            playPanel.Location = new Point(3, 96);
            playPanel.Margin = new Padding(3, 2, 3, 2);
            playPanel.Name = "playPanel";
            playPanel.Size = new Size(387, 250);
            playPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(168, 140);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 6;
            label1.Text = "/";
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            currentLabel.ForeColor = SystemColors.HighlightText;
            currentLabel.Location = new Point(106, 140);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(36, 20);
            currentLabel.TabIndex = 5;
            currentLabel.Text = "0:00";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            durationLabel.ForeColor = SystemColors.HighlightText;
            durationLabel.Location = new Point(206, 140);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(36, 20);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "0:00";
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.Goldenrod;
            stopButton.FlatStyle = FlatStyle.Flat;
            stopButton.ForeColor = SystemColors.HighlightText;
            stopButton.Location = new Point(186, 80);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(82, 38);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Goldenrod;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.ForeColor = SystemColors.HighlightText;
            playButton.Location = new Point(84, 80);
            playButton.Margin = new Padding(3, 2, 3, 2);
            playButton.Name = "playButton";
            playButton.Size = new Size(82, 38);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // silenceCheckBox
            // 
            silenceCheckBox.AutoSize = true;
            silenceCheckBox.ForeColor = Color.Black;
            silenceCheckBox.Location = new Point(522, 38);
            silenceCheckBox.Margin = new Padding(3, 2, 3, 2);
            silenceCheckBox.Name = "silenceCheckBox";
            silenceCheckBox.Size = new Size(15, 14);
            silenceCheckBox.TabIndex = 10;
            silenceCheckBox.UseVisualStyleBackColor = true;
            silenceCheckBox.CheckedChanged += silenceCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(443, 36);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 9;
            label4.Text = "Silence:";
            // 
            // plotSecondsBox
            // 
            plotSecondsBox.Location = new Point(522, 10);
            plotSecondsBox.Margin = new Padding(3, 2, 3, 2);
            plotSecondsBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            plotSecondsBox.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            plotSecondsBox.Name = "plotSecondsBox";
            plotSecondsBox.Size = new Size(49, 23);
            plotSecondsBox.TabIndex = 8;
            plotSecondsBox.Value = new decimal(new int[] { 4, 0, 0, 0 });
            plotSecondsBox.ValueChanged += plotSecondsBox_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(431, 8);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Seconds:";
            // 
            // analysisButton
            // 
            analysisButton.BackColor = Color.Goldenrod;
            analysisButton.Enabled = false;
            analysisButton.FlatStyle = FlatStyle.Flat;
            analysisButton.ForeColor = SystemColors.HighlightText;
            analysisButton.Location = new Point(620, 13);
            analysisButton.Margin = new Padding(3, 2, 3, 2);
            analysisButton.Name = "analysisButton";
            analysisButton.Size = new Size(93, 31);
            analysisButton.TabIndex = 7;
            analysisButton.Text = "Analyze";
            analysisButton.UseVisualStyleBackColor = false;
            analysisButton.Click += analysisButton_Click;
            // 
            // loadingPanel
            // 
            loadingPanel.Controls.Add(estimatedTimeLabel);
            loadingPanel.Controls.Add(label2);
            loadingPanel.Location = new Point(107, 207);
            loadingPanel.Name = "loadingPanel";
            loadingPanel.Size = new Size(260, 100);
            loadingPanel.TabIndex = 3;
            loadingPanel.Visible = false;
            // 
            // estimatedTimeLabel
            // 
            estimatedTimeLabel.AutoSize = true;
            estimatedTimeLabel.ForeColor = SystemColors.HighlightText;
            estimatedTimeLabel.Location = new Point(60, 56);
            estimatedTimeLabel.Name = "estimatedTimeLabel";
            estimatedTimeLabel.Size = new Size(126, 15);
            estimatedTimeLabel.TabIndex = 1;
            estimatedTimeLabel.Text = "Estimated time: 0m00s";
            estimatedTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(80, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Processing data...";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataPlot
            // 
            dataPlot.BackColor = SystemColors.HighlightText;
            dataPlot.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataPlot.ForeColor = SystemColors.AppWorkspace;
            dataPlot.Location = new Point(27, 62);
            dataPlot.Margin = new Padding(4, 3, 4, 3);
            dataPlot.Name = "dataPlot";
            dataPlot.Size = new Size(722, 432);
            dataPlot.TabIndex = 2;
            dataPlot.Visible = false;
            // 
            // plotComboBox
            // 
            plotComboBox.BackColor = SystemColors.HighlightText;
            plotComboBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            plotComboBox.ForeColor = SystemColors.ControlText;
            plotComboBox.FormattingEnabled = true;
            plotComboBox.Location = new Point(27, 19);
            plotComboBox.Margin = new Padding(3, 2, 3, 2);
            plotComboBox.Name = "plotComboBox";
            plotComboBox.Size = new Size(366, 27);
            plotComboBox.TabIndex = 1;
            plotComboBox.SelectedIndexChanged += plotComboBox_SelectedIndexChanged;
            // 
            // viewControl
            // 
            viewControl.Controls.Add(timePage);
            viewControl.Controls.Add(frequencyPage);
            viewControl.Location = new Point(63, 17);
            viewControl.Margin = new Padding(3, 2, 3, 2);
            viewControl.Name = "viewControl";
            viewControl.SelectedIndex = 0;
            viewControl.Size = new Size(1230, 548);
            viewControl.TabIndex = 3;
            viewControl.SelectedIndexChanged += viewControl_SelectedIndexChanged;
            // 
            // timePage
            // 
            timePage.BackColor = Color.Black;
            timePage.Controls.Add(splitContainer1);
            timePage.Location = new Point(4, 24);
            timePage.Margin = new Padding(3, 2, 3, 2);
            timePage.Name = "timePage";
            timePage.Padding = new Padding(3, 2, 3, 2);
            timePage.Size = new Size(1222, 520);
            timePage.TabIndex = 0;
            timePage.Text = "Time";
            // 
            // frequencyPage
            // 
            frequencyPage.BackColor = Color.Black;
            frequencyPage.Controls.Add(splitContainer2);
            frequencyPage.Location = new Point(4, 24);
            frequencyPage.Margin = new Padding(3, 2, 3, 2);
            frequencyPage.Name = "frequencyPage";
            frequencyPage.Padding = new Padding(3, 2, 3, 2);
            frequencyPage.Size = new Size(1222, 520);
            frequencyPage.TabIndex = 1;
            frequencyPage.Text = "Frame";
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(32, 14);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(lengthUpDown);
            splitContainer2.Panel1.Controls.Add(savePlotBtn2);
            splitContainer2.Panel1.Controls.Add(panel1);
            splitContainer2.Panel1.Controls.Add(fileButton2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(loadingPanel2);
            splitContainer2.Panel2.Controls.Add(analysisButton2);
            splitContainer2.Panel2.Controls.Add(dataPlot2);
            splitContainer2.Panel2.Controls.Add(plotComboBox2);
            splitContainer2.Size = new Size(1161, 496);
            splitContainer2.SplitterDistance = 387;
            splitContainer2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(25, 23);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 6;
            label5.Text = "Frame length (ms):";
            // 
            // lengthUpDown
            // 
            lengthUpDown.Location = new Point(171, 23);
            lengthUpDown.Margin = new Padding(3, 2, 3, 2);
            lengthUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            lengthUpDown.Name = "lengthUpDown";
            lengthUpDown.Size = new Size(131, 23);
            lengthUpDown.TabIndex = 5;
            lengthUpDown.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // savePlotBtn2
            // 
            savePlotBtn2.BackColor = Color.Goldenrod;
            savePlotBtn2.Enabled = false;
            savePlotBtn2.FlatStyle = FlatStyle.Flat;
            savePlotBtn2.ForeColor = SystemColors.HighlightText;
            savePlotBtn2.Location = new Point(126, 391);
            savePlotBtn2.Margin = new Padding(3, 2, 3, 2);
            savePlotBtn2.Name = "savePlotBtn2";
            savePlotBtn2.Size = new Size(110, 38);
            savePlotBtn2.TabIndex = 3;
            savePlotBtn2.Text = "Save plot";
            savePlotBtn2.UseVisualStyleBackColor = false;
            savePlotBtn2.Click += savePlotBtn2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(frameUpDown);
            panel1.Controls.Add(frameLabel);
            panel1.Controls.Add(frameSlider);
            panel1.Controls.Add(fileLabel2);
            panel1.Location = new Point(3, 157);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 189);
            panel1.TabIndex = 0;
            // 
            // frameUpDown
            // 
            frameUpDown.Enabled = false;
            frameUpDown.Location = new Point(168, 79);
            frameUpDown.Margin = new Padding(3, 2, 3, 2);
            frameUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            frameUpDown.Name = "frameUpDown";
            frameUpDown.Size = new Size(131, 23);
            frameUpDown.TabIndex = 4;
            frameUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            frameUpDown.ValueChanged += frameUpDown_ValueChanged;
            // 
            // frameLabel
            // 
            frameLabel.AutoSize = true;
            frameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            frameLabel.ForeColor = SystemColors.Control;
            frameLabel.Location = new Point(98, 79);
            frameLabel.Name = "frameLabel";
            frameLabel.Size = new Size(57, 21);
            frameLabel.TabIndex = 3;
            frameLabel.Text = "Frame:";
            // 
            // frameSlider
            // 
            frameSlider.Enabled = false;
            frameSlider.Location = new Point(38, 118);
            frameSlider.Margin = new Padding(3, 2, 3, 2);
            frameSlider.Maximum = 100;
            frameSlider.Minimum = 1;
            frameSlider.Name = "frameSlider";
            frameSlider.Size = new Size(312, 45);
            frameSlider.TabIndex = 2;
            frameSlider.Value = 1;
            frameSlider.Scroll += frameSlider_Scroll;
            // 
            // fileLabel2
            // 
            fileLabel2.BackColor = SystemColors.HighlightText;
            fileLabel2.BorderStyle = BorderStyle.FixedSingle;
            fileLabel2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            fileLabel2.ForeColor = SystemColors.ControlText;
            fileLabel2.Location = new Point(98, 28);
            fileLabel2.Name = "fileLabel2";
            fileLabel2.Padding = new Padding(4);
            fileLabel2.Size = new Size(181, 28);
            fileLabel2.TabIndex = 1;
            fileLabel2.Text = "File name";
            // 
            // fileButton2
            // 
            fileButton2.BackColor = Color.Goldenrod;
            fileButton2.FlatStyle = FlatStyle.Flat;
            fileButton2.ForeColor = SystemColors.HighlightText;
            fileButton2.Location = new Point(101, 80);
            fileButton2.Margin = new Padding(3, 2, 3, 2);
            fileButton2.Name = "fileButton2";
            fileButton2.Size = new Size(181, 38);
            fileButton2.TabIndex = 0;
            fileButton2.Text = "Select file";
            fileButton2.UseVisualStyleBackColor = false;
            fileButton2.Click += fileButton2_Click;
            // 
            // loadingPanel2
            // 
            loadingPanel2.Controls.Add(estimatedTimeLabel2);
            loadingPanel2.Controls.Add(label6);
            loadingPanel2.Location = new Point(112, 207);
            loadingPanel2.Name = "loadingPanel2";
            loadingPanel2.Size = new Size(260, 100);
            loadingPanel2.TabIndex = 8;
            loadingPanel2.Visible = false;
            // 
            // estimatedTimeLabel2
            // 
            estimatedTimeLabel2.AutoSize = true;
            estimatedTimeLabel2.ForeColor = SystemColors.HighlightText;
            estimatedTimeLabel2.Location = new Point(60, 56);
            estimatedTimeLabel2.Name = "estimatedTimeLabel2";
            estimatedTimeLabel2.Size = new Size(126, 15);
            estimatedTimeLabel2.TabIndex = 1;
            estimatedTimeLabel2.Text = "Estimated time: 0m00s";
            estimatedTimeLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(80, 29);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 0;
            label6.Text = "Processing data...";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // analysisButton2
            // 
            analysisButton2.BackColor = Color.Goldenrod;
            analysisButton2.Enabled = false;
            analysisButton2.FlatStyle = FlatStyle.Flat;
            analysisButton2.ForeColor = SystemColors.HighlightText;
            analysisButton2.Location = new Point(620, 13);
            analysisButton2.Margin = new Padding(3, 2, 3, 2);
            analysisButton2.Name = "analysisButton2";
            analysisButton2.Size = new Size(93, 31);
            analysisButton2.TabIndex = 7;
            analysisButton2.Text = "Analyze";
            analysisButton2.UseVisualStyleBackColor = false;
            analysisButton2.Click += analysisButton2_Click;
            // 
            // dataPlot2
            // 
            dataPlot2.BackColor = SystemColors.HighlightText;
            dataPlot2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataPlot2.ForeColor = SystemColors.AppWorkspace;
            dataPlot2.Location = new Point(27, 62);
            dataPlot2.Margin = new Padding(4, 3, 4, 3);
            dataPlot2.Name = "dataPlot2";
            dataPlot2.Size = new Size(722, 432);
            dataPlot2.TabIndex = 2;
            dataPlot2.Visible = false;
            // 
            // plotComboBox2
            // 
            plotComboBox2.BackColor = SystemColors.HighlightText;
            plotComboBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            plotComboBox2.ForeColor = SystemColors.ControlText;
            plotComboBox2.FormattingEnabled = true;
            plotComboBox2.Location = new Point(27, 19);
            plotComboBox2.Margin = new Padding(3, 2, 3, 2);
            plotComboBox2.Name = "plotComboBox2";
            plotComboBox2.Size = new Size(366, 27);
            plotComboBox2.TabIndex = 1;
            plotComboBox2.SelectedIndexChanged += plotComboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1333, 586);
            Controls.Add(viewControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "AudioCracker";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            playPanel.ResumeLayout(false);
            playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plotSecondsBox).EndInit();
            loadingPanel.ResumeLayout(false);
            loadingPanel.PerformLayout();
            viewControl.ResumeLayout(false);
            timePage.ResumeLayout(false);
            frequencyPage.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lengthUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frameUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)frameSlider).EndInit();
            loadingPanel2.ResumeLayout(false);
            loadingPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button fileButton;
        private Label fileLabel;
        private SplitContainer splitContainer1;
        private Button playButton;
        private Button stopButton;
        private Panel playPanel;
        private Label durationLabel;
        private Label currentLabel;
        private Label label1;
        private ComboBox plotComboBox;
        private ScottPlot.FormsPlot dataPlot;
        private Panel loadingPanel;
        private Label estimatedTimeLabel;
        private Label label2;
        private Button analysisButton;
        private NumericUpDown plotSecondsBox;
        private Label label3;
        private CheckBox silenceCheckBox;
        private Label label4;
        private Button savePlotBtn;
        private TabControl viewControl;
        private TabPage timePage;
        private TabPage frequencyPage;
        private SplitContainer splitContainer2;
        private Button savePlotBtn2;
        private Panel panel1;
        private Label fileLabel2;
        private Button fileButton2;
        private Button analysisButton2;
        private ScottPlot.FormsPlot dataPlot2;
        private ComboBox plotComboBox2;
        private NumericUpDown frameUpDown;
        private Label frameLabel;
        private TrackBar frameSlider;
        private Panel loadingPanel2;
        private Label estimatedTimeLabel2;
        private Label label6;
        private Label label5;
        private NumericUpDown lengthUpDown;
    }
}