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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotSecondsBox)).BeginInit();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Goldenrod;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileButton.Location = new System.Drawing.Point(87, 28);
            this.fileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(181, 38);
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
            this.fileLabel.Location = new System.Drawing.Point(87, 22);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Padding = new System.Windows.Forms.Padding(4);
            this.fileLabel.Size = new System.Drawing.Size(181, 28);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "File name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(95, 44);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(1161, 496);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.TabIndex = 2;
            // 
            // savePlotBtn
            // 
            this.savePlotBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.savePlotBtn.Enabled = false;
            this.savePlotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlotBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savePlotBtn.Location = new System.Drawing.Point(126, 391);
            this.savePlotBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savePlotBtn.Name = "savePlotBtn";
            this.savePlotBtn.Size = new System.Drawing.Size(110, 38);
            this.savePlotBtn.TabIndex = 3;
            this.savePlotBtn.Text = "Save plot";
            this.savePlotBtn.UseVisualStyleBackColor = false;
            this.savePlotBtn.Click += new System.EventHandler(this.savePlotBtn_Click);
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.label1);
            this.playPanel.Controls.Add(this.currentLabel);
            this.playPanel.Controls.Add(this.durationLabel);
            this.playPanel.Controls.Add(this.fileLabel);
            this.playPanel.Controls.Add(this.stopButton);
            this.playPanel.Controls.Add(this.playButton);
            this.playPanel.Location = new System.Drawing.Point(3, 96);
            this.playPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(387, 250);
            this.playPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(168, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.currentLabel.Location = new System.Drawing.Point(106, 140);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(36, 20);
            this.currentLabel.TabIndex = 5;
            this.currentLabel.Text = "0:00";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.durationLabel.Location = new System.Drawing.Point(206, 140);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(36, 20);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "0:00";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Goldenrod;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stopButton.Location = new System.Drawing.Point(186, 80);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(82, 38);
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
            this.playButton.Location = new System.Drawing.Point(84, 80);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(82, 38);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // silenceCheckBox
            // 
            this.silenceCheckBox.AutoSize = true;
            this.silenceCheckBox.ForeColor = System.Drawing.Color.Black;
            this.silenceCheckBox.Location = new System.Drawing.Point(522, 38);
            this.silenceCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.silenceCheckBox.Name = "silenceCheckBox";
            this.silenceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.silenceCheckBox.TabIndex = 10;
            this.silenceCheckBox.UseVisualStyleBackColor = true;
            this.silenceCheckBox.CheckedChanged += new System.EventHandler(this.silenceCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(443, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Silence:";
            // 
            // plotSecondsBox
            // 
            this.plotSecondsBox.Location = new System.Drawing.Point(522, 10);
            this.plotSecondsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.plotSecondsBox.Size = new System.Drawing.Size(49, 23);
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
            this.label3.Location = new System.Drawing.Point(431, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seconds:";
            // 
            // analysisButton
            // 
            this.analysisButton.BackColor = System.Drawing.Color.Goldenrod;
            this.analysisButton.Enabled = false;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.analysisButton.Location = new System.Drawing.Point(620, 13);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(93, 31);
            this.analysisButton.TabIndex = 7;
            this.analysisButton.Text = "Analyze";
            this.analysisButton.UseVisualStyleBackColor = false;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.estimatedTimeLabel);
            this.loadingPanel.Controls.Add(this.label2);
            this.loadingPanel.Location = new System.Drawing.Point(107, 207);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(260, 100);
            this.loadingPanel.TabIndex = 3;
            this.loadingPanel.Visible = false;
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.estimatedTimeLabel.Location = new System.Drawing.Point(60, 56);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(126, 15);
            this.estimatedTimeLabel.TabIndex = 1;
            this.estimatedTimeLabel.Text = "Estimated time: 0m00s";
            this.estimatedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(80, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Processing data...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataPlot
            // 
            this.dataPlot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataPlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataPlot.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPlot.Location = new System.Drawing.Point(27, 62);
            this.dataPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataPlot.Name = "dataPlot";
            this.dataPlot.Size = new System.Drawing.Size(722, 432);
            this.dataPlot.TabIndex = 2;
            this.dataPlot.Visible = false;
            // 
            // plotComboBox
            // 
            this.plotComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plotComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plotComboBox.FormattingEnabled = true;
            this.plotComboBox.Location = new System.Drawing.Point(27, 19);
            this.plotComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plotComboBox.Name = "plotComboBox";
            this.plotComboBox.Size = new System.Drawing.Size(366, 27);
            this.plotComboBox.TabIndex = 1;
            this.plotComboBox.SelectedIndexChanged += new System.EventHandler(this.plotComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1333, 586);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "AudioCracker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotSecondsBox)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
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
    }
}