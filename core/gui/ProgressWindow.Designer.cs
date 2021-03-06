﻿namespace MeGUI
{
    partial class ProgressWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressWindow));
            this.currentVideoFrameLabel = new System.Windows.Forms.Label();
            this.currentVideoFrame = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.timeElapsed = new System.Windows.Forms.TextBox();
            this.timeElapsedLabel = new System.Windows.Forms.Label();
            this.fps = new System.Windows.Forms.TextBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.videoData = new System.Windows.Forms.TextBox();
            this.videoDataLabel = new System.Windows.Forms.Label();
            this.currentPositionLabel = new System.Windows.Forms.Label();
            this.positionInClip = new System.Windows.Forms.TextBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.jobNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpButton1 = new MeGUI.core.gui.HelpButton();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentVideoFrameLabel
            // 
            this.currentVideoFrameLabel.AutoSize = true;
            this.currentVideoFrameLabel.Location = new System.Drawing.Point(8, 44);
            this.currentVideoFrameLabel.Name = "currentVideoFrameLabel";
            this.currentVideoFrameLabel.Size = new System.Drawing.Size(105, 13);
            this.currentVideoFrameLabel.TabIndex = 2;
            this.currentVideoFrameLabel.Text = "目前 / 所有的影格:";
            // 
            // currentVideoFrame
            // 
            this.currentVideoFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.currentVideoFrame.Location = new System.Drawing.Point(173, 41);
            this.currentVideoFrame.Name = "currentVideoFrame";
            this.currentVideoFrame.ReadOnly = true;
            this.currentVideoFrame.Size = new System.Drawing.Size(130, 21);
            this.currentVideoFrame.TabIndex = 17;
            this.currentVideoFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.totalTime);
            this.groupBox1.Controls.Add(this.totalTimeLabel);
            this.groupBox1.Controls.Add(this.timeElapsed);
            this.groupBox1.Controls.Add(this.timeElapsedLabel);
            this.groupBox1.Controls.Add(this.fps);
            this.groupBox1.Controls.Add(this.fpsLabel);
            this.groupBox1.Controls.Add(this.videoData);
            this.groupBox1.Controls.Add(this.videoDataLabel);
            this.groupBox1.Controls.Add(this.currentPositionLabel);
            this.groupBox1.Controls.Add(this.currentVideoFrame);
            this.groupBox1.Controls.Add(this.currentVideoFrameLabel);
            this.groupBox1.Controls.Add(this.positionInClip);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // totalTime
            // 
            this.totalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTime.Location = new System.Drawing.Point(173, 149);
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            this.totalTime.Size = new System.Drawing.Size(130, 21);
            this.totalTime.TabIndex = 25;
            this.totalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(8, 152);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(59, 13);
            this.totalTimeLabel.TabIndex = 10;
            this.totalTimeLabel.Text = "剩餘時間:";
            // 
            // timeElapsed
            // 
            this.timeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timeElapsed.Location = new System.Drawing.Point(173, 122);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.ReadOnly = true;
            this.timeElapsed.Size = new System.Drawing.Size(130, 21);
            this.timeElapsed.TabIndex = 23;
            this.timeElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timeElapsedLabel
            // 
            this.timeElapsedLabel.AutoSize = true;
            this.timeElapsedLabel.Location = new System.Drawing.Point(8, 125);
            this.timeElapsedLabel.Name = "timeElapsedLabel";
            this.timeElapsedLabel.Size = new System.Drawing.Size(59, 13);
            this.timeElapsedLabel.TabIndex = 8;
            this.timeElapsedLabel.Text = "已過時間:";
            // 
            // fps
            // 
            this.fps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fps.Location = new System.Drawing.Point(173, 95);
            this.fps.Name = "fps";
            this.fps.ReadOnly = true;
            this.fps.Size = new System.Drawing.Size(130, 21);
            this.fps.TabIndex = 21;
            this.fps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(8, 98);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(71, 13);
            this.fpsLabel.TabIndex = 6;
            this.fpsLabel.Text = "處理百分比:";
            // 
            // videoData
            // 
            this.videoData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoData.Location = new System.Drawing.Point(173, 68);
            this.videoData.Name = "videoData";
            this.videoData.ReadOnly = true;
            this.videoData.Size = new System.Drawing.Size(130, 21);
            this.videoData.TabIndex = 19;
            this.videoData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // videoDataLabel
            // 
            this.videoDataLabel.AutoSize = true;
            this.videoDataLabel.Location = new System.Drawing.Point(8, 71);
            this.videoDataLabel.Name = "videoDataLabel";
            this.videoDataLabel.Size = new System.Drawing.Size(129, 13);
            this.videoDataLabel.TabIndex = 4;
            this.videoDataLabel.Text = "目前 / 全部的檔案大小:";
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.AutoSize = true;
            this.currentPositionLabel.Location = new System.Drawing.Point(8, 17);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(117, 13);
            this.currentPositionLabel.TabIndex = 0;
            this.currentPositionLabel.Text = "目前時間 / 全部長度:";
            // 
            // positionInClip
            // 
            this.positionInClip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.positionInClip.Location = new System.Drawing.Point(173, 14);
            this.positionInClip.Name = "positionInClip";
            this.positionInClip.ReadOnly = true;
            this.positionInClip.Size = new System.Drawing.Size(130, 21);
            this.positionInClip.TabIndex = 15;
            this.positionInClip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abortButton.Location = new System.Drawing.Point(239, 252);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 6;
            this.abortButton.Text = "中止";
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(12, 195);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(100, 15);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "進度";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(122, 191);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(195, 23);
            this.progress.TabIndex = 1;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Location = new System.Drawing.Point(12, 223);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(100, 15);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "優先度";
            // 
            // priority
            // 
            this.priority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority.Items.AddRange(new object[] {
            "低",
            "低於標準",
            "標準",
            "高於標準",
            "高"});
            this.priority.Location = new System.Drawing.Point(122, 220);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(122, 21);
            this.priority.TabIndex = 2;
            this.priority.SelectedIndexChanged += new System.EventHandler(this.priority_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobNameLabel,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(49, 18);
            this.jobNameLabel.Text = "[任務1]";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 18);
            this.statusLabel.Text = "狀態: ";
            // 
            // helpButton1
            // 
            this.helpButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpButton1.ArticleName = "Status Window";
            this.helpButton1.AutoSize = true;
            this.helpButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton1.Location = new System.Drawing.Point(12, 252);
            this.helpButton1.Name = "helpButton1";
            this.helpButton1.Size = new System.Drawing.Size(56, 23);
            this.helpButton1.TabIndex = 5;
            // 
            // ProgressWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.helpButton1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 330);
            this.Name = "ProgressWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "狀態";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public event AbortCallback Abort; // event fired if the abort button has been pressed
        public event PriorityChangedCallback PriorityChanged; // event fired if the priority dropdown has changed
        private System.Windows.Forms.Label currentVideoFrameLabel;
        private System.Windows.Forms.TextBox currentVideoFrame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Label videoDataLabel;
        private System.Windows.Forms.TextBox videoData;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TextBox fps;
        private System.Windows.Forms.Label timeElapsedLabel;
        private System.Windows.Forms.TextBox timeElapsed;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.TextBox totalTime;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.TextBox positionInClip;
        private System.Windows.Forms.Label currentPositionLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private MeGUI.core.gui.HelpButton helpButton1;
        private ITaskbarList3 taskbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel jobNameLabel;
    }
}