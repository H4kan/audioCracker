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
            this.playPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.dataPlot = new ScottPlot.FormsPlot();
            this.plotComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.playPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.BackColor = System.Drawing.Color.Goldenrod;
            this.fileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.fileButton.Location = new System.Drawing.Point(99, 38);
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
            this.fileLabel.Padding = new System.Windows.Forms.Padding(5);
            this.fileLabel.Size = new System.Drawing.Size(207, 37);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "File name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(109, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.playPanel);
            this.splitContainer1.Panel1.Controls.Add(this.fileButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataPlot);
            this.splitContainer1.Panel2.Controls.Add(this.plotComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1327, 662);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 2;
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.label1);
            this.playPanel.Controls.Add(this.currentLabel);
            this.playPanel.Controls.Add(this.durationLabel);
            this.playPanel.Controls.Add(this.fileLabel);
            this.playPanel.Controls.Add(this.stopButton);
            this.playPanel.Controls.Add(this.playButton);
            this.playPanel.Location = new System.Drawing.Point(3, 128);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(442, 333);
            this.playPanel.TabIndex = 0;
            this.playPanel.Visible = false;
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
            this.stopButton.Location = new System.Drawing.Point(212, 106);
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
            this.playButton.Location = new System.Drawing.Point(96, 106);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(94, 51);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // dataPlot
            // 
            this.dataPlot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dataPlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataPlot.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataPlot.Location = new System.Drawing.Point(31, 82);
            this.dataPlot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataPlot.Name = "dataPlot";
            this.dataPlot.Size = new System.Drawing.Size(825, 576);
            this.dataPlot.TabIndex = 2;
            // 
            // plotComboBox
            // 
            this.plotComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.plotComboBox.Enabled = false;
            this.plotComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plotComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plotComboBox.FormattingEnabled = true;
            this.plotComboBox.Location = new System.Drawing.Point(138, 38);
            this.plotComboBox.Name = "plotComboBox";
            this.plotComboBox.Size = new System.Drawing.Size(653, 33);
            this.plotComboBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1523, 781);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "AudioCracker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
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
    }
}