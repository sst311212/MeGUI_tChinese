﻿namespace MeGUI.core.gui
{
    partial class AudioEncodingTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.audioContainer = new System.Windows.Forms.ComboBox();
            this.audioContainerLabel = new System.Windows.Forms.Label();
            this.queueAudioButton = new System.Windows.Forms.Button();
            this.audioInputLabel = new System.Windows.Forms.Label();
            this.audioOutputLabel = new System.Windows.Forms.Label();
            this.deleteAudioButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.audioProfile = new MeGUI.core.gui.ConfigableProfilesControl();
            this.audioOutput = new MeGUI.FileBar();
            this.cuts = new MeGUI.FileBar();
            this.audioInput = new MeGUI.FileBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "剪切檔案";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // audioContainer
            // 
            this.audioContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioContainer.FormattingEnabled = true;
            this.audioContainer.Location = new System.Drawing.Point(95, 107);
            this.audioContainer.Name = "audioContainer";
            this.audioContainer.Size = new System.Drawing.Size(143, 20);
            this.audioContainer.TabIndex = 25;
            this.audioContainer.SelectedIndexChanged += new System.EventHandler(this.audioContainer_SelectedIndexChanged);
            // 
            // audioContainerLabel
            // 
            this.audioContainerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.audioContainerLabel.Location = new System.Drawing.Point(3, 104);
            this.audioContainerLabel.Name = "audioContainerLabel";
            this.audioContainerLabel.Size = new System.Drawing.Size(86, 26);
            this.audioContainerLabel.TabIndex = 24;
            this.audioContainerLabel.Text = "副檔名 ";
            this.audioContainerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // queueAudioButton
            // 
            this.queueAudioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.queueAudioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queueAudioButton.Location = new System.Drawing.Point(112, 3);
            this.queueAudioButton.Name = "queueAudioButton";
            this.queueAudioButton.Size = new System.Drawing.Size(60, 21);
            this.queueAudioButton.TabIndex = 27;
            this.queueAudioButton.Text = "佇列";
            this.queueAudioButton.Click += new System.EventHandler(this.queueAudioButton_Click);
            // 
            // audioInputLabel
            // 
            this.audioInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioInputLabel.Location = new System.Drawing.Point(3, 0);
            this.audioInputLabel.Name = "audioInputLabel";
            this.audioInputLabel.Size = new System.Drawing.Size(86, 26);
            this.audioInputLabel.TabIndex = 15;
            this.audioInputLabel.Text = "音訊輸入";
            this.audioInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // audioOutputLabel
            // 
            this.audioOutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioOutputLabel.Location = new System.Drawing.Point(3, 52);
            this.audioOutputLabel.Name = "audioOutputLabel";
            this.audioOutputLabel.Size = new System.Drawing.Size(86, 26);
            this.audioOutputLabel.TabIndex = 19;
            this.audioOutputLabel.Text = "音訊輸出";
            this.audioOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteAudioButton
            // 
            this.deleteAudioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteAudioButton.Location = new System.Drawing.Point(58, 3);
            this.deleteAudioButton.Name = "deleteAudioButton";
            this.deleteAudioButton.Size = new System.Drawing.Size(48, 21);
            this.deleteAudioButton.TabIndex = 26;
            this.deleteAudioButton.Text = "X";
            this.deleteAudioButton.Click += new System.EventHandler(this.deleteAudioButton_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(244, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "延遲";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delay
            // 
            this.delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delay.Location = new System.Drawing.Point(284, 107);
            this.delay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(143, 22);
            this.delay.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(433, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "毫秒";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "編碼器設定";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.audioInputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.audioContainer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.audioProfile, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.delay, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.audioOutputLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.audioContainerLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.audioOutput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cuts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.audioInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 160);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // audioProfile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.audioProfile, 4);
            this.audioProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioProfile.Location = new System.Drawing.Point(95, 81);
            this.audioProfile.Name = "audioProfile";
            this.audioProfile.ProfileSet = "Audio";
            this.audioProfile.Size = new System.Drawing.Size(358, 20);
            this.audioProfile.TabIndex = 31;
            this.audioProfile.SelectedProfileChanged += new System.EventHandler(this.audioProfile_SelectedProfileChanged);
            // 
            // audioOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.audioOutput, 4);
            this.audioOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioOutput.Filename = "";
            this.audioOutput.Filter = null;
            this.audioOutput.FilterIndex = 0;
            this.audioOutput.FolderMode = false;
            this.audioOutput.Location = new System.Drawing.Point(95, 55);
            this.audioOutput.Name = "audioOutput";
            this.audioOutput.ReadOnly = false;
            this.audioOutput.SaveMode = true;
            this.audioOutput.Size = new System.Drawing.Size(358, 20);
            this.audioOutput.TabIndex = 20;
            this.audioOutput.Title = "輸入輸出名稱";
            // 
            // cuts
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cuts, 4);
            this.cuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuts.Filename = "";
            this.cuts.Filter = "MeGUI 剪切檔案 (*.clt)|*.clt";
            this.cuts.FilterIndex = 0;
            this.cuts.FolderMode = false;
            this.cuts.Location = new System.Drawing.Point(95, 29);
            this.cuts.Name = "cuts";
            this.cuts.ReadOnly = true;
            this.cuts.SaveMode = false;
            this.cuts.Size = new System.Drawing.Size(358, 20);
            this.cuts.TabIndex = 18;
            this.cuts.Title = "選擇剪切檔案";
            // 
            // audioInput
            // 
            this.audioInput.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.audioInput, 4);
            this.audioInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioInput.Filename = "";
            this.audioInput.Filter = "所有檔案 (*.*)|*.*";
            this.audioInput.FilterIndex = 0;
            this.audioInput.FolderMode = false;
            this.audioInput.Location = new System.Drawing.Point(95, 3);
            this.audioInput.Name = "audioInput";
            this.audioInput.ReadOnly = true;
            this.audioInput.SaveMode = false;
            this.audioInput.Size = new System.Drawing.Size(358, 20);
            this.audioInput.TabIndex = 16;
            this.audioInput.Title = "選擇輸入音訊";
            this.audioInput.FileSelected += new MeGUI.FileBarEventHandler(this.audioInput_FileSelected);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.queueAudioButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteAudioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 130);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 30);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // AudioEncodingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AudioEncodingTab";
            this.Size = new System.Drawing.Size(456, 160);
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FileBar cuts;
        private System.Windows.Forms.Label label1;
        private FileBar audioOutput;
        private FileBar audioInput;
        private System.Windows.Forms.ComboBox audioContainer;
        private System.Windows.Forms.Label audioContainerLabel;
        private System.Windows.Forms.Button queueAudioButton;
        private System.Windows.Forms.Label audioInputLabel;
        private System.Windows.Forms.Label audioOutputLabel;
        private System.Windows.Forms.Button deleteAudioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delay;
        private System.Windows.Forms.Label label3;
        private ConfigableProfilesControl audioProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
