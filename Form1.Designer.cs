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
            this.fileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.savePlotBtn = new System.Windows.Forms.Button();
            this.playPanel = new System.Windows.Forms.Panel();
            this.freqRangePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bottomFreqRange = new System.Windows.Forms.NumericUpDown();
            this.upFreqRange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.silenceCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plotSecondsBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.analysisButton = new System.Windows.Forms.Button();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.estimatedTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPlot = new ScottPlot.FormsPlot();
            this.plotComboBox = new System.Windows.Forms.ComboBox();
            this.viewControl = new System.Windows.Forms.TabControl();
            this.timePage = new System.Windows.Forms.TabPage();
            this.frequencyPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.savePlotBtn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frameUpDown = new System.Windows.Forms.NumericUpDown();
            this.frameLabel = new System.Windows.Forms.Label();
            this.frameSlider = new System.Windows.Forms.TrackBar();
            this.fileLabel2 = new System.Windows.Forms.Label();
            this.fileButton2 = new System.Windows.Forms.Button();
            this.loadingPanel2 = new System.Windows.Forms.Panel();
            this.estimatedTimeLabel2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.analysisButton2 = new System.Windows.Forms.Button();
            this.dataPlot2 = new ScottPlot.FormsPlot();
            this.plotComboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.playPanel.SuspendLayout();
            this.freqRangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomFreqRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upFreqRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotSecondsBox)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.viewControl.SuspendLayout();
            this.timePage.SuspendLayout();
            this.frequencyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSlider)).BeginInit();
            this.loadingPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Goldenrod;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileButton.Location = new System.Drawing.Point(99, 37);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(207, 51);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Select file";
            this.fileButton.UseVisualStyleBackColor = false;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileLabel.Location = new System.Drawing.Point(99, 29);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fileLabel.Size = new System.Drawing.Size(207, 37);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "File name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(27, 19);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.savePlotBtn);
            this.splitContainer1.Panel1.Controls.Add(this.playPanel);
            this.splitContainer1.Panel1.Controls.Add(this.fileButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.silenceCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.plotSecondsBox);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.analysisButton);
            this.splitContainer1.Panel2.Controls.Add(this.loadingPanel);
            this.splitContainer1.Panel2.Controls.Add(this.dataPlot);
            this.splitContainer1.Panel2.Controls.Add(this.plotComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1327, 661);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // savePlotBtn
            // 
            this.savePlotBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.savePlotBtn.Enabled = false;
            this.savePlotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlotBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savePlotBtn.Location = new System.Drawing.Point(144, 585);
            this.savePlotBtn.Name = "savePlotBtn";
            this.savePlotBtn.Size = new System.Drawing.Size(126, 51);
            this.savePlotBtn.TabIndex = 3;
            this.savePlotBtn.Text = "Save plot";
            this.savePlotBtn.UseVisualStyleBackColor = false;
            this.savePlotBtn.Click += new System.EventHandler(this.savePlotBtn_Click);
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.freqRangePanel);
            this.playPanel.Controls.Add(this.label1);
            this.playPanel.Controls.Add(this.currentLabel);
            this.playPanel.Controls.Add(this.durationLabel);
            this.playPanel.Controls.Add(this.fileLabel);
            this.playPanel.Controls.Add(this.stopButton);
            this.playPanel.Controls.Add(this.playButton);
            this.playPanel.Location = new System.Drawing.Point(3, 128);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(442, 412);
            this.playPanel.TabIndex = 0;
            // 
            // freqRangePanel
            // 
            this.freqRangePanel.Controls.Add(this.label8);
            this.freqRangePanel.Controls.Add(this.label7);
            this.freqRangePanel.Controls.Add(this.bottomFreqRange);
            this.freqRangePanel.Controls.Add(this.upFreqRange);
            this.freqRangePanel.Location = new System.Drawing.Point(14, 259);
            this.freqRangePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.freqRangePanel.Name = "freqRangePanel";
            this.freqRangePanel.Size = new System.Drawing.Size(410, 91);
            this.freqRangePanel.TabIndex = 10;
            this.freqRangePanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(189, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(109, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Frequency range (Hz):";
            // 
            // bottomFreqRange
            // 
            this.bottomFreqRange.Location = new System.Drawing.Point(26, 57);
            this.bottomFreqRange.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.bottomFreqRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomFreqRange.Name = "bottomFreqRange";
            this.bottomFreqRange.Size = new System.Drawing.Size(150, 27);
            this.bottomFreqRange.TabIndex = 5;
            this.bottomFreqRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bottomFreqRange.ValueChanged += new System.EventHandler(this.bottomFreqRange_ValueChanged);
            // 
            // upFreqRange
            // 
            this.upFreqRange.Location = new System.Drawing.Point(214, 57);
            this.upFreqRange.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.upFreqRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upFreqRange.Name = "upFreqRange";
            this.upFreqRange.Size = new System.Drawing.Size(150, 27);
            this.upFreqRange.TabIndex = 6;
            this.upFreqRange.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.upFreqRange.ValueChanged += new System.EventHandler(this.upFreqRange_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(192, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.currentLabel.Location = new System.Drawing.Point(121, 187);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(46, 25);
            this.currentLabel.TabIndex = 5;
            this.currentLabel.Text = "0:00";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.durationLabel.Location = new System.Drawing.Point(235, 187);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(46, 25);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "0:00";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Goldenrod;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stopButton.Location = new System.Drawing.Point(213, 107);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(94, 51);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Goldenrod;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.playButton.Location = new System.Drawing.Point(96, 107);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(94, 51);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // silenceCheckBox
            // 
            this.silenceCheckBox.AutoSize = true;
            this.silenceCheckBox.ForeColor = System.Drawing.Color.Black;
            this.silenceCheckBox.Location = new System.Drawing.Point(597, 51);
            this.silenceCheckBox.Name = "silenceCheckBox";
            this.silenceCheckBox.Size = new System.Drawing.Size(18, 17);
            this.silenceCheckBox.TabIndex = 10;
            this.silenceCheckBox.UseVisualStyleBackColor = true;
            this.silenceCheckBox.CheckedChanged += new System.EventHandler(this.silenceCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(506, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Silence:";
            // 
            // plotSecondsBox
            // 
            this.plotSecondsBox.Location = new System.Drawing.Point(597, 13);
            this.plotSecondsBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.plotSecondsBox.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.plotSecondsBox.Name = "plotSecondsBox";
            this.plotSecondsBox.Size = new System.Drawing.Size(56, 27);
            this.plotSecondsBox.TabIndex = 8;
            this.plotSecondsBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.plotSecondsBox.ValueChanged += new System.EventHandler(this.plotSecondsBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(493, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seconds:";
            // 
            // analysisButton
            // 
            this.analysisButton.BackColor = System.Drawing.Color.Goldenrod;
            this.analysisButton.Enabled = false;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.analysisButton.Location = new System.Drawing.Point(709, 17);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(106, 41);
            this.analysisButton.TabIndex = 7;
            this.analysisButton.Text = "Analyze";
            this.analysisButton.UseVisualStyleBackColor = false;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.estimatedTimeLabel);
            this.loadingPanel.Controls.Add(this.label2);
            this.loadingPanel.Location = new System.Drawing.Point(122, 276);
            this.loadingPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(297, 133);
            this.loadingPanel.TabIndex = 3;
            this.loadingPanel.Visible = false;
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.estimatedTimeLabel.Location = new System.Drawing.Point(69, 75);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(159, 20);
            this.estimatedTimeLabel.TabIndex = 1;
            this.estimatedTimeLabel.Text = "Estimated time: 0m00s";
            this.estimatedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(91, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Processing data...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataPlot
            // 
            this.dataPlot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataPlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataPlot.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPlot.Location = new System.Drawing.Point(31, 83);
            this.dataPlot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataPlot.Name = "dataPlot";
            this.dataPlot.Size = new System.Drawing.Size(825, 576);
            this.dataPlot.TabIndex = 2;
            this.dataPlot.Visible = false;
            // 
            // plotComboBox
            // 
            this.plotComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plotComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plotComboBox.FormattingEnabled = true;
            this.plotComboBox.Location = new System.Drawing.Point(31, 25);
            this.plotComboBox.Name = "plotComboBox";
            this.plotComboBox.Size = new System.Drawing.Size(418, 33);
            this.plotComboBox.TabIndex = 1;
            this.plotComboBox.SelectedIndexChanged += new System.EventHandler(this.plotComboBox_SelectedIndexChanged);
            // 
            // viewControl
            // 
            this.viewControl.Controls.Add(this.timePage);
            this.viewControl.Controls.Add(this.frequencyPage);
            this.viewControl.Location = new System.Drawing.Point(72, 23);
            this.viewControl.Name = "viewControl";
            this.viewControl.SelectedIndex = 0;
            this.viewControl.Size = new System.Drawing.Size(1406, 731);
            this.viewControl.TabIndex = 3;
            this.viewControl.SelectedIndexChanged += new System.EventHandler(this.viewControl_SelectedIndexChanged);
            // 
            // timePage
            // 
            this.timePage.BackColor = System.Drawing.Color.Black;
            this.timePage.Controls.Add(this.splitContainer1);
            this.timePage.Location = new System.Drawing.Point(4, 29);
            this.timePage.Name = "timePage";
            this.timePage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.timePage.Size = new System.Drawing.Size(1398, 698);
            this.timePage.TabIndex = 0;
            this.timePage.Text = "Time";
            // 
            // frequencyPage
            // 
            this.frequencyPage.BackColor = System.Drawing.Color.Black;
            this.frequencyPage.Controls.Add(this.splitContainer2);
            this.frequencyPage.Location = new System.Drawing.Point(4, 29);
            this.frequencyPage.Name = "frequencyPage";
            this.frequencyPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.frequencyPage.Size = new System.Drawing.Size(1398, 698);
            this.frequencyPage.TabIndex = 1;
            this.frequencyPage.Text = "Frame";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(37, 19);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.lengthUpDown);
            this.splitContainer2.Panel1.Controls.Add(this.savePlotBtn2);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.fileButton2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.loadingPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.analysisButton2);
            this.splitContainer2.Panel2.Controls.Add(this.dataPlot2);
            this.splitContainer2.Panel2.Controls.Add(this.plotComboBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1327, 661);
            this.splitContainer2.SplitterDistance = 442;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(29, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Frame length (ms):";
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(218, 32);
            this.lengthUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(150, 27);
            this.lengthUpDown.TabIndex = 5;
            this.lengthUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // savePlotBtn2
            // 
            this.savePlotBtn2.BackColor = System.Drawing.Color.Goldenrod;
            this.savePlotBtn2.Enabled = false;
            this.savePlotBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlotBtn2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savePlotBtn2.Location = new System.Drawing.Point(138, 577);
            this.savePlotBtn2.Name = "savePlotBtn2";
            this.savePlotBtn2.Size = new System.Drawing.Size(126, 51);
            this.savePlotBtn2.TabIndex = 3;
            this.savePlotBtn2.Text = "Save plot";
            this.savePlotBtn2.UseVisualStyleBackColor = false;
            this.savePlotBtn2.Click += new System.EventHandler(this.savePlotBtn2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.frameUpDown);
            this.panel1.Controls.Add(this.frameLabel);
            this.panel1.Controls.Add(this.frameSlider);
            this.panel1.Controls.Add(this.fileLabel2);
            this.panel1.Location = new System.Drawing.Point(3, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 324);
            this.panel1.TabIndex = 0;
            // 
            // frameUpDown
            // 
            this.frameUpDown.Enabled = false;
            this.frameUpDown.Location = new System.Drawing.Point(192, 105);
            this.frameUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameUpDown.Name = "frameUpDown";
            this.frameUpDown.Size = new System.Drawing.Size(150, 27);
            this.frameUpDown.TabIndex = 4;
            this.frameUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameUpDown.ValueChanged += new System.EventHandler(this.frameUpDown_ValueChanged);
            // 
            // frameLabel
            // 
            this.frameLabel.AutoSize = true;
            this.frameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.frameLabel.Location = new System.Drawing.Point(112, 105);
            this.frameLabel.Name = "frameLabel";
            this.frameLabel.Size = new System.Drawing.Size(70, 28);
            this.frameLabel.TabIndex = 3;
            this.frameLabel.Text = "Frame:";
            // 
            // frameSlider
            // 
            this.frameSlider.Enabled = false;
            this.frameSlider.Location = new System.Drawing.Point(43, 157);
            this.frameSlider.Maximum = 100;
            this.frameSlider.Minimum = 1;
            this.frameSlider.Name = "frameSlider";
            this.frameSlider.Size = new System.Drawing.Size(357, 56);
            this.frameSlider.TabIndex = 2;
            this.frameSlider.Value = 1;
            this.frameSlider.Scroll += new System.EventHandler(this.frameSlider_Scroll);
            // 
            // fileLabel2
            // 
            this.fileLabel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fileLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileLabel2.Location = new System.Drawing.Point(112, 37);
            this.fileLabel2.Name = "fileLabel2";
            this.fileLabel2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fileLabel2.Size = new System.Drawing.Size(207, 37);
            this.fileLabel2.TabIndex = 1;
            this.fileLabel2.Text = "File name";
            // 
            // fileButton2
            // 
            this.fileButton2.BackColor = System.Drawing.Color.Goldenrod;
            this.fileButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileButton2.Location = new System.Drawing.Point(115, 107);
            this.fileButton2.Name = "fileButton2";
            this.fileButton2.Size = new System.Drawing.Size(207, 51);
            this.fileButton2.TabIndex = 0;
            this.fileButton2.Text = "Select file";
            this.fileButton2.UseVisualStyleBackColor = false;
            this.fileButton2.Click += new System.EventHandler(this.fileButton2_Click);
            // 
            // loadingPanel2
            // 
            this.loadingPanel2.Controls.Add(this.estimatedTimeLabel2);
            this.loadingPanel2.Controls.Add(this.label6);
            this.loadingPanel2.Location = new System.Drawing.Point(128, 276);
            this.loadingPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingPanel2.Name = "loadingPanel2";
            this.loadingPanel2.Size = new System.Drawing.Size(297, 133);
            this.loadingPanel2.TabIndex = 8;
            this.loadingPanel2.Visible = false;
            // 
            // estimatedTimeLabel2
            // 
            this.estimatedTimeLabel2.AutoSize = true;
            this.estimatedTimeLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.estimatedTimeLabel2.Location = new System.Drawing.Point(69, 75);
            this.estimatedTimeLabel2.Name = "estimatedTimeLabel2";
            this.estimatedTimeLabel2.Size = new System.Drawing.Size(159, 20);
            this.estimatedTimeLabel2.TabIndex = 1;
            this.estimatedTimeLabel2.Text = "Estimated time: 0m00s";
            this.estimatedTimeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(91, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Processing data...";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // analysisButton2
            // 
            this.analysisButton2.BackColor = System.Drawing.Color.Goldenrod;
            this.analysisButton2.Enabled = false;
            this.analysisButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.analysisButton2.Location = new System.Drawing.Point(709, 17);
            this.analysisButton2.Name = "analysisButton2";
            this.analysisButton2.Size = new System.Drawing.Size(106, 41);
            this.analysisButton2.TabIndex = 7;
            this.analysisButton2.Text = "Analyze";
            this.analysisButton2.UseVisualStyleBackColor = false;
            this.analysisButton2.Click += new System.EventHandler(this.analysisButton2_Click);
            // 
            // dataPlot2
            // 
            this.dataPlot2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataPlot2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataPlot2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPlot2.Location = new System.Drawing.Point(31, 83);
            this.dataPlot2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataPlot2.Name = "dataPlot2";
            this.dataPlot2.Size = new System.Drawing.Size(825, 576);
            this.dataPlot2.TabIndex = 2;
            this.dataPlot2.Visible = false;
            // 
            // plotComboBox2
            // 
            this.plotComboBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotComboBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plotComboBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plotComboBox2.FormattingEnabled = true;
            this.plotComboBox2.Location = new System.Drawing.Point(31, 25);
            this.plotComboBox2.Name = "plotComboBox2";
            this.plotComboBox2.Size = new System.Drawing.Size(418, 33);
            this.plotComboBox2.TabIndex = 1;
            this.plotComboBox2.SelectedIndexChanged += new System.EventHandler(this.plotComboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1523, 781);
            this.Controls.Add(this.viewControl);
            this.Name = "Form1";
            this.Text = "AudioCracker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            this.freqRangePanel.ResumeLayout(false);
            this.freqRangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomFreqRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upFreqRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotSecondsBox)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.viewControl.ResumeLayout(false);
            this.timePage.ResumeLayout(false);
            this.frequencyPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSlider)).EndInit();
            this.loadingPanel2.ResumeLayout(false);
            this.loadingPanel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel freqRangePanel;
        private Label label8;
        private Label label7;
        private NumericUpDown bottomFreqRange;
        private NumericUpDown upFreqRange;
    }
}