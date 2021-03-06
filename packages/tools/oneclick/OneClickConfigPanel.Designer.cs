﻿// ****************************************************************************
// 
// Copyright (C) 2005-2014 Doom9 & al
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
// 
// ****************************************************************************

namespace MeGUI.packages.tools.oneclick
{
    partial class OneClickConfigPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            this.otherGroupBox = new System.Windows.Forms.GroupBox();
            this.keepInputResolution = new System.Windows.Forms.CheckBox();
            this.autoCrop = new System.Windows.Forms.CheckBox();
            this.preprocessVideo = new System.Windows.Forms.CheckBox();
            this.autoDeint = new System.Windows.Forms.CheckBox();
            this.signalAR = new System.Windows.Forms.CheckBox();
            this.horizontalResolution = new System.Windows.Forms.NumericUpDown();
            this.outputResolutionLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkDontEncodeVideo = new System.Windows.Forms.CheckBox();
            this.usechaptersmarks = new System.Windows.Forms.CheckBox();
            this.videoCodecLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.extraGroupbox = new System.Windows.Forms.GroupBox();
            this.audioTab = new System.Windows.Forms.TabControl();
            this.audioPage0 = new System.Windows.Forms.TabPage();
            this.audioPageAdd = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filesizeLabel = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.containerTypeList = new System.Windows.Forms.CheckedListBox();
            this.containerFormatLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbUnknownLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLanguageSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubtitleDown = new System.Windows.Forms.Button();
            this.btnSubtitleUp = new System.Windows.Forms.Button();
            this.btnRemoveSubtitle = new System.Windows.Forms.Button();
            this.btnAddSubtitle = new System.Windows.Forms.Button();
            this.lbNonDefaultSubtitle = new System.Windows.Forms.ListBox();
            this.lbDefaultSubtitle = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAudioDown = new System.Windows.Forms.Button();
            this.btnAudioUp = new System.Windows.Forms.Button();
            this.btnRemoveAudio = new System.Windows.Forms.Button();
            this.btnAddAudio = new System.Windows.Forms.Button();
            this.lbNonDefaultAudio = new System.Windows.Forms.ListBox();
            this.lbDefaultAudio = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkDisableIntermediateMKV = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteWorking = new System.Windows.Forms.Button();
            this.deleteOutput = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.workingDirectoryLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeadingName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkingNameReplaceWith = new System.Windows.Forms.TextBox();
            this.txtWorkingNameDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIndexerDown = new System.Windows.Forms.Button();
            this.btnIndexerUp = new System.Windows.Forms.Button();
            this.lbIndexerPriority = new System.Windows.Forms.ListBox();
            this.audioMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.audioAddTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.audioRemoveTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.avsProfile = new MeGUI.core.gui.ConfigableProfilesControl();
            this.videoProfile = new MeGUI.core.gui.ConfigableProfilesControl();
            this.oneClickAudioControl1 = new MeGUI.OneClickAudioControl();
            this.splitSize = new MeGUI.core.gui.TargetSizeSCBox();
            this.fileSize = new MeGUI.core.gui.TargetSizeSCBox();
            this.outputDirectory = new MeGUI.FileBar();
            this.workingDirectory = new MeGUI.FileBar();
            label3 = new System.Windows.Forms.Label();
            this.otherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.extraGroupbox.SuspendLayout();
            this.audioTab.SuspendLayout();
            this.audioPage0.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.audioMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 12);
            label3.TabIndex = 40;
            label3.Text = "Avisynth 設定檔";
            // 
            // otherGroupBox
            // 
            this.otherGroupBox.Controls.Add(this.keepInputResolution);
            this.otherGroupBox.Controls.Add(this.autoCrop);
            this.otherGroupBox.Controls.Add(label3);
            this.otherGroupBox.Controls.Add(this.avsProfile);
            this.otherGroupBox.Controls.Add(this.preprocessVideo);
            this.otherGroupBox.Controls.Add(this.autoDeint);
            this.otherGroupBox.Controls.Add(this.signalAR);
            this.otherGroupBox.Controls.Add(this.horizontalResolution);
            this.otherGroupBox.Controls.Add(this.outputResolutionLabel);
            this.otherGroupBox.Location = new System.Drawing.Point(6, 91);
            this.otherGroupBox.Name = "otherGroupBox";
            this.otherGroupBox.Size = new System.Drawing.Size(416, 140);
            this.otherGroupBox.TabIndex = 38;
            this.otherGroupBox.TabStop = false;
            this.otherGroupBox.Text = " 檔案大小與 Avisynth 設定 ";
            // 
            // keepInputResolution
            // 
            this.keepInputResolution.AutoSize = true;
            this.keepInputResolution.Location = new System.Drawing.Point(109, 42);
            this.keepInputResolution.Name = "keepInputResolution";
            this.keepInputResolution.Size = new System.Drawing.Size(242, 16);
            this.keepInputResolution.TabIndex = 42;
            this.keepInputResolution.Text = "維持輸入的解析度 (禁用裁切 && 調整大小)";
            this.keepInputResolution.UseVisualStyleBackColor = true;
            this.keepInputResolution.CheckedChanged += new System.EventHandler(this.keepInputResolution_CheckedChanged);
            // 
            // autoCrop
            // 
            this.autoCrop.AutoSize = true;
            this.autoCrop.Checked = true;
            this.autoCrop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCrop.Location = new System.Drawing.Point(188, 19);
            this.autoCrop.Name = "autoCrop";
            this.autoCrop.Size = new System.Drawing.Size(72, 16);
            this.autoCrop.TabIndex = 41;
            this.autoCrop.Text = "自動裁切";
            this.autoCrop.UseVisualStyleBackColor = true;
            // 
            // preprocessVideo
            // 
            this.preprocessVideo.AutoSize = true;
            this.preprocessVideo.Location = new System.Drawing.Point(109, 109);
            this.preprocessVideo.Name = "preprocessVideo";
            this.preprocessVideo.Size = new System.Drawing.Size(96, 16);
            this.preprocessVideo.TabIndex = 37;
            this.preprocessVideo.Text = "預先渲染視訊";
            this.preprocessVideo.UseVisualStyleBackColor = true;
            // 
            // autoDeint
            // 
            this.autoDeint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoDeint.AutoSize = true;
            this.autoDeint.Location = new System.Drawing.Point(273, 109);
            this.autoDeint.Name = "autoDeint";
            this.autoDeint.Size = new System.Drawing.Size(96, 16);
            this.autoDeint.TabIndex = 35;
            this.autoDeint.Text = "自動化去交錯";
            this.autoDeint.UseVisualStyleBackColor = true;
            // 
            // signalAR
            // 
            this.signalAR.AutoSize = true;
            this.signalAR.Location = new System.Drawing.Point(272, 19);
            this.signalAR.Name = "signalAR";
            this.signalAR.Size = new System.Drawing.Size(84, 16);
            this.signalAR.TabIndex = 32;
            this.signalAR.Text = "無組態輸出";
            this.signalAR.UseVisualStyleBackColor = true;
            // 
            // horizontalResolution
            // 
            this.horizontalResolution.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.horizontalResolution.Location = new System.Drawing.Point(109, 18);
            this.horizontalResolution.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.horizontalResolution.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.horizontalResolution.Name = "horizontalResolution";
            this.horizontalResolution.Size = new System.Drawing.Size(64, 22);
            this.horizontalResolution.TabIndex = 27;
            this.horizontalResolution.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // outputResolutionLabel
            // 
            this.outputResolutionLabel.Location = new System.Drawing.Point(6, 15);
            this.outputResolutionLabel.Name = "outputResolutionLabel";
            this.outputResolutionLabel.Size = new System.Drawing.Size(100, 24);
            this.outputResolutionLabel.TabIndex = 30;
            this.outputResolutionLabel.Text = "      輸出解析度\r\n     (最大. 寬度)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 258);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.otherGroupBox);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "視訊";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkDontEncodeVideo);
            this.groupBox6.Controls.Add(this.usechaptersmarks);
            this.groupBox6.Controls.Add(this.videoProfile);
            this.groupBox6.Controls.Add(this.videoCodecLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(416, 80);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " 視訊設定 ";
            // 
            // chkDontEncodeVideo
            // 
            this.chkDontEncodeVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDontEncodeVideo.AutoSize = true;
            this.chkDontEncodeVideo.Location = new System.Drawing.Point(82, 20);
            this.chkDontEncodeVideo.Name = "chkDontEncodeVideo";
            this.chkDontEncodeVideo.Size = new System.Drawing.Size(96, 16);
            this.chkDontEncodeVideo.TabIndex = 42;
            this.chkDontEncodeVideo.Text = "不要編碼視訊";
            // 
            // usechaptersmarks
            // 
            this.usechaptersmarks.AutoSize = true;
            this.usechaptersmarks.Location = new System.Drawing.Point(202, 20);
            this.usechaptersmarks.Name = "usechaptersmarks";
            this.usechaptersmarks.Size = new System.Drawing.Size(180, 16);
            this.usechaptersmarks.TabIndex = 41;
            this.usechaptersmarks.Text = "強制使用關鍵影格給章節標記";
            this.usechaptersmarks.UseVisualStyleBackColor = true;
            // 
            // videoCodecLabel
            // 
            this.videoCodecLabel.Location = new System.Drawing.Point(6, 47);
            this.videoCodecLabel.Name = "videoCodecLabel";
            this.videoCodecLabel.Size = new System.Drawing.Size(41, 12);
            this.videoCodecLabel.TabIndex = 18;
            this.videoCodecLabel.Text = "編碼器";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.extraGroupbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 232);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "音訊";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // extraGroupbox
            // 
            this.extraGroupbox.Controls.Add(this.audioTab);
            this.extraGroupbox.Location = new System.Drawing.Point(3, 6);
            this.extraGroupbox.Name = "extraGroupbox";
            this.extraGroupbox.Size = new System.Drawing.Size(419, 223);
            this.extraGroupbox.TabIndex = 40;
            this.extraGroupbox.TabStop = false;
            this.extraGroupbox.Text = " 音訊設定 (指定語言的音訊設定) ";
            // 
            // audioTab
            // 
            this.audioTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.audioTab.Controls.Add(this.audioPage0);
            this.audioTab.Controls.Add(this.audioPageAdd);
            this.audioTab.Location = new System.Drawing.Point(6, 28);
            this.audioTab.Name = "audioTab";
            this.audioTab.SelectedIndex = 0;
            this.audioTab.Size = new System.Drawing.Size(407, 138);
            this.audioTab.TabIndex = 44;
            this.audioTab.SelectedIndexChanged += new System.EventHandler(this.audioTab_SelectedIndexChanged);
            this.audioTab.VisibleChanged += new System.EventHandler(this.audioTab_VisibleChanged);
            this.audioTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.audioTab_KeyUp);
            this.audioTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.audioTab_MouseClick);
            this.audioTab.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.audioTab_MouseDoubleClick);
            // 
            // audioPage0
            // 
            this.audioPage0.Controls.Add(this.oneClickAudioControl1);
            this.audioPage0.Location = new System.Drawing.Point(4, 22);
            this.audioPage0.Name = "audioPage0";
            this.audioPage0.Size = new System.Drawing.Size(399, 112);
            this.audioPage0.TabIndex = 2;
            this.audioPage0.Text = "預設";
            this.audioPage0.UseVisualStyleBackColor = true;
            // 
            // audioPageAdd
            // 
            this.audioPageAdd.Location = new System.Drawing.Point(4, 22);
            this.audioPageAdd.Name = "audioPageAdd";
            this.audioPageAdd.Size = new System.Drawing.Size(399, 112);
            this.audioPageAdd.TabIndex = 3;
            this.audioPageAdd.Text = "   +";
            this.audioPageAdd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "輸出";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.splitSize);
            this.groupBox8.Controls.Add(this.fileSize);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.filesizeLabel);
            this.groupBox8.Location = new System.Drawing.Point(3, 137);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(416, 92);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = " 檔案 ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "檔案分割";
            // 
            // filesizeLabel
            // 
            this.filesizeLabel.Location = new System.Drawing.Point(8, 29);
            this.filesizeLabel.Name = "filesizeLabel";
            this.filesizeLabel.Size = new System.Drawing.Size(90, 12);
            this.filesizeLabel.TabIndex = 40;
            this.filesizeLabel.Text = "檔案大小";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.containerTypeList);
            this.groupBox7.Controls.Add(this.containerFormatLabel);
            this.groupBox7.Location = new System.Drawing.Point(3, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(419, 125);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = " 包裝器 ";
            // 
            // containerTypeList
            // 
            this.containerTypeList.CheckOnClick = true;
            this.containerTypeList.Location = new System.Drawing.Point(6, 15);
            this.containerTypeList.Name = "containerTypeList";
            this.containerTypeList.Size = new System.Drawing.Size(171, 89);
            this.containerTypeList.TabIndex = 21;
            // 
            // containerFormatLabel
            // 
            this.containerFormatLabel.Location = new System.Drawing.Point(183, 15);
            this.containerFormatLabel.Name = "containerFormatLabel";
            this.containerFormatLabel.Size = new System.Drawing.Size(223, 101);
            this.containerFormatLabel.TabIndex = 18;
            this.containerFormatLabel.Text = "Text change later for resource behavior reasons";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbUnknownLanguage);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.cbLanguageSelect);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(425, 232);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "語言";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbUnknownLanguage
            // 
            this.cbUnknownLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnknownLanguage.FormattingEnabled = true;
            this.cbUnknownLanguage.Location = new System.Drawing.Point(268, 186);
            this.cbUnknownLanguage.Name = "cbUnknownLanguage";
            this.cbUnknownLanguage.Size = new System.Drawing.Size(130, 20);
            this.cbUnknownLanguage.Sorted = true;
            this.cbUnknownLanguage.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "無法定義的語言設定: ";
            // 
            // cbLanguageSelect
            // 
            this.cbLanguageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguageSelect.FormattingEnabled = true;
            this.cbLanguageSelect.Items.AddRange(new object[] {
            "all",
            "none"});
            this.cbLanguageSelect.Location = new System.Drawing.Point(268, 210);
            this.cbLanguageSelect.Name = "cbLanguageSelect";
            this.cbLanguageSelect.Size = new System.Drawing.Size(130, 20);
            this.cbLanguageSelect.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "無法匹配的語言選擇: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubtitleDown);
            this.groupBox2.Controls.Add(this.btnSubtitleUp);
            this.groupBox2.Controls.Add(this.btnRemoveSubtitle);
            this.groupBox2.Controls.Add(this.btnAddSubtitle);
            this.groupBox2.Controls.Add(this.lbNonDefaultSubtitle);
            this.groupBox2.Controls.Add(this.lbDefaultSubtitle);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 預設字幕語言 (這個語言的軌道會預先選取) ";
            // 
            // btnSubtitleDown
            // 
            this.btnSubtitleDown.Location = new System.Drawing.Point(151, 63);
            this.btnSubtitleDown.Name = "btnSubtitleDown";
            this.btnSubtitleDown.Size = new System.Drawing.Size(29, 18);
            this.btnSubtitleDown.TabIndex = 6;
            this.btnSubtitleDown.Text = "-";
            this.btnSubtitleDown.UseVisualStyleBackColor = true;
            this.btnSubtitleDown.Click += new System.EventHandler(this.btnSubtitleDown_Click);
            // 
            // btnSubtitleUp
            // 
            this.btnSubtitleUp.Location = new System.Drawing.Point(151, 17);
            this.btnSubtitleUp.Name = "btnSubtitleUp";
            this.btnSubtitleUp.Size = new System.Drawing.Size(29, 18);
            this.btnSubtitleUp.TabIndex = 5;
            this.btnSubtitleUp.Text = "+";
            this.btnSubtitleUp.UseVisualStyleBackColor = true;
            this.btnSubtitleUp.Click += new System.EventHandler(this.btnSubtitleUp_Click);
            // 
            // btnRemoveSubtitle
            // 
            this.btnRemoveSubtitle.Location = new System.Drawing.Point(151, 40);
            this.btnRemoveSubtitle.Name = "btnRemoveSubtitle";
            this.btnRemoveSubtitle.Size = new System.Drawing.Size(29, 18);
            this.btnRemoveSubtitle.TabIndex = 4;
            this.btnRemoveSubtitle.Text = ">>";
            this.btnRemoveSubtitle.UseVisualStyleBackColor = true;
            this.btnRemoveSubtitle.Click += new System.EventHandler(this.btnRemoveSubtitle_Click);
            // 
            // btnAddSubtitle
            // 
            this.btnAddSubtitle.Location = new System.Drawing.Point(227, 40);
            this.btnAddSubtitle.Name = "btnAddSubtitle";
            this.btnAddSubtitle.Size = new System.Drawing.Size(29, 18);
            this.btnAddSubtitle.TabIndex = 3;
            this.btnAddSubtitle.Text = "<<";
            this.btnAddSubtitle.UseVisualStyleBackColor = true;
            this.btnAddSubtitle.Click += new System.EventHandler(this.btnAddSubtitle_Click);
            // 
            // lbNonDefaultSubtitle
            // 
            this.lbNonDefaultSubtitle.FormattingEnabled = true;
            this.lbNonDefaultSubtitle.ItemHeight = 12;
            this.lbNonDefaultSubtitle.Location = new System.Drawing.Point(262, 17);
            this.lbNonDefaultSubtitle.Name = "lbNonDefaultSubtitle";
            this.lbNonDefaultSubtitle.Size = new System.Drawing.Size(130, 64);
            this.lbNonDefaultSubtitle.Sorted = true;
            this.lbNonDefaultSubtitle.TabIndex = 2;
            this.lbNonDefaultSubtitle.SelectedIndexChanged += new System.EventHandler(this.lbNonDefaultSubtitle_SelectedIndexChanged);
            // 
            // lbDefaultSubtitle
            // 
            this.lbDefaultSubtitle.FormattingEnabled = true;
            this.lbDefaultSubtitle.ItemHeight = 12;
            this.lbDefaultSubtitle.Location = new System.Drawing.Point(15, 17);
            this.lbDefaultSubtitle.Name = "lbDefaultSubtitle";
            this.lbDefaultSubtitle.Size = new System.Drawing.Size(130, 64);
            this.lbDefaultSubtitle.TabIndex = 1;
            this.lbDefaultSubtitle.SelectedIndexChanged += new System.EventHandler(this.lbDefaultSubtitle_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAudioDown);
            this.groupBox1.Controls.Add(this.btnAudioUp);
            this.groupBox1.Controls.Add(this.btnRemoveAudio);
            this.groupBox1.Controls.Add(this.btnAddAudio);
            this.groupBox1.Controls.Add(this.lbNonDefaultAudio);
            this.groupBox1.Controls.Add(this.lbDefaultAudio);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 預設音訊語言 (這個語言的軌道會預先選取) ";
            // 
            // btnAudioDown
            // 
            this.btnAudioDown.Location = new System.Drawing.Point(151, 63);
            this.btnAudioDown.Name = "btnAudioDown";
            this.btnAudioDown.Size = new System.Drawing.Size(29, 18);
            this.btnAudioDown.TabIndex = 6;
            this.btnAudioDown.Text = "-";
            this.btnAudioDown.UseVisualStyleBackColor = true;
            this.btnAudioDown.Click += new System.EventHandler(this.btnAudioDown_Click);
            // 
            // btnAudioUp
            // 
            this.btnAudioUp.Location = new System.Drawing.Point(151, 17);
            this.btnAudioUp.Name = "btnAudioUp";
            this.btnAudioUp.Size = new System.Drawing.Size(29, 18);
            this.btnAudioUp.TabIndex = 5;
            this.btnAudioUp.Text = "+";
            this.btnAudioUp.UseVisualStyleBackColor = true;
            this.btnAudioUp.Click += new System.EventHandler(this.btnAudioUp_Click);
            // 
            // btnRemoveAudio
            // 
            this.btnRemoveAudio.Location = new System.Drawing.Point(151, 40);
            this.btnRemoveAudio.Name = "btnRemoveAudio";
            this.btnRemoveAudio.Size = new System.Drawing.Size(29, 18);
            this.btnRemoveAudio.TabIndex = 4;
            this.btnRemoveAudio.Text = ">>";
            this.btnRemoveAudio.UseVisualStyleBackColor = true;
            this.btnRemoveAudio.Click += new System.EventHandler(this.btnRemoveAudio_Click);
            // 
            // btnAddAudio
            // 
            this.btnAddAudio.Location = new System.Drawing.Point(227, 40);
            this.btnAddAudio.Name = "btnAddAudio";
            this.btnAddAudio.Size = new System.Drawing.Size(29, 18);
            this.btnAddAudio.TabIndex = 3;
            this.btnAddAudio.Text = "<<";
            this.btnAddAudio.UseVisualStyleBackColor = true;
            this.btnAddAudio.Click += new System.EventHandler(this.btnAddAudio_Click);
            // 
            // lbNonDefaultAudio
            // 
            this.lbNonDefaultAudio.FormattingEnabled = true;
            this.lbNonDefaultAudio.ItemHeight = 12;
            this.lbNonDefaultAudio.Location = new System.Drawing.Point(262, 17);
            this.lbNonDefaultAudio.Name = "lbNonDefaultAudio";
            this.lbNonDefaultAudio.Size = new System.Drawing.Size(130, 64);
            this.lbNonDefaultAudio.Sorted = true;
            this.lbNonDefaultAudio.TabIndex = 2;
            this.lbNonDefaultAudio.SelectedIndexChanged += new System.EventHandler(this.lbNonDefaultAudio_SelectedIndexChanged);
            // 
            // lbDefaultAudio
            // 
            this.lbDefaultAudio.FormattingEnabled = true;
            this.lbDefaultAudio.ItemHeight = 12;
            this.lbDefaultAudio.Location = new System.Drawing.Point(15, 18);
            this.lbDefaultAudio.Name = "lbDefaultAudio";
            this.lbDefaultAudio.Size = new System.Drawing.Size(130, 64);
            this.lbDefaultAudio.TabIndex = 1;
            this.lbDefaultAudio.SelectedIndexChanged += new System.EventHandler(this.lbDefaultAudio_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkDisableIntermediateMKV);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(425, 232);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "其他";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkDisableIntermediateMKV
            // 
            this.chkDisableIntermediateMKV.AutoSize = true;
            this.chkDisableIntermediateMKV.Location = new System.Drawing.Point(15, 204);
            this.chkDisableIntermediateMKV.Name = "chkDisableIntermediateMKV";
            this.chkDisableIntermediateMKV.Size = new System.Drawing.Size(164, 16);
            this.chkDisableIntermediateMKV.TabIndex = 45;
            this.chkDisableIntermediateMKV.Text = "禁用 MKV 檔案內部的檔案";
            this.chkDisableIntermediateMKV.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteWorking);
            this.groupBox5.Controls.Add(this.deleteOutput);
            this.groupBox5.Controls.Add(this.outputDirectory);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.workingDirectory);
            this.groupBox5.Controls.Add(this.workingDirectoryLabel);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 78);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " 預設目錄 ";
            // 
            // deleteWorking
            // 
            this.deleteWorking.Location = new System.Drawing.Point(370, 48);
            this.deleteWorking.Name = "deleteWorking";
            this.deleteWorking.Size = new System.Drawing.Size(28, 21);
            this.deleteWorking.TabIndex = 46;
            this.deleteWorking.Text = "X";
            this.deleteWorking.UseVisualStyleBackColor = true;
            this.deleteWorking.Click += new System.EventHandler(this.deleteWorking_Click);
            // 
            // deleteOutput
            // 
            this.deleteOutput.Location = new System.Drawing.Point(370, 18);
            this.deleteOutput.Name = "deleteOutput";
            this.deleteOutput.Size = new System.Drawing.Size(28, 21);
            this.deleteOutput.TabIndex = 45;
            this.deleteOutput.Text = "X";
            this.deleteOutput.UseVisualStyleBackColor = true;
            this.deleteOutput.Click += new System.EventHandler(this.deleteOutput_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "輸出";
            // 
            // workingDirectoryLabel
            // 
            this.workingDirectoryLabel.Location = new System.Drawing.Point(6, 52);
            this.workingDirectoryLabel.Name = "workingDirectoryLabel";
            this.workingDirectoryLabel.Size = new System.Drawing.Size(108, 12);
            this.workingDirectoryLabel.TabIndex = 41;
            this.workingDirectoryLabel.Text = "工作目錄";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtLeadingName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtWorkingNameReplaceWith);
            this.groupBox4.Controls.Add(this.txtWorkingNameDelete);
            this.groupBox4.Location = new System.Drawing.Point(212, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 102);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " 專案名稱 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "優先";
            // 
            // txtLeadingName
            // 
            this.txtLeadingName.Location = new System.Drawing.Point(60, 26);
            this.txtLeadingName.Name = "txtLeadingName";
            this.txtLeadingName.Size = new System.Drawing.Size(121, 22);
            this.txtLeadingName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "成為";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "替換";
            // 
            // txtWorkingNameReplaceWith
            // 
            this.txtWorkingNameReplaceWith.Location = new System.Drawing.Point(60, 74);
            this.txtWorkingNameReplaceWith.Name = "txtWorkingNameReplaceWith";
            this.txtWorkingNameReplaceWith.Size = new System.Drawing.Size(121, 22);
            this.txtWorkingNameReplaceWith.TabIndex = 1;
            // 
            // txtWorkingNameDelete
            // 
            this.txtWorkingNameDelete.Location = new System.Drawing.Point(60, 50);
            this.txtWorkingNameDelete.Name = "txtWorkingNameDelete";
            this.txtWorkingNameDelete.Size = new System.Drawing.Size(121, 22);
            this.txtWorkingNameDelete.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIndexerDown);
            this.groupBox3.Controls.Add(this.btnIndexerUp);
            this.groupBox3.Controls.Add(this.lbIndexerPriority);
            this.groupBox3.Location = new System.Drawing.Point(6, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 102);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 索引 / 開啟優先度 ";
            // 
            // btnIndexerDown
            // 
            this.btnIndexerDown.Enabled = false;
            this.btnIndexerDown.Location = new System.Drawing.Point(145, 59);
            this.btnIndexerDown.Name = "btnIndexerDown";
            this.btnIndexerDown.Size = new System.Drawing.Size(29, 21);
            this.btnIndexerDown.TabIndex = 44;
            this.btnIndexerDown.Text = "-";
            this.btnIndexerDown.UseVisualStyleBackColor = true;
            this.btnIndexerDown.Click += new System.EventHandler(this.btnIndexerDown_Click);
            // 
            // btnIndexerUp
            // 
            this.btnIndexerUp.Enabled = false;
            this.btnIndexerUp.Location = new System.Drawing.Point(145, 30);
            this.btnIndexerUp.Name = "btnIndexerUp";
            this.btnIndexerUp.Size = new System.Drawing.Size(29, 21);
            this.btnIndexerUp.TabIndex = 43;
            this.btnIndexerUp.Text = "+";
            this.btnIndexerUp.UseVisualStyleBackColor = true;
            this.btnIndexerUp.Click += new System.EventHandler(this.btnIndexerUp_Click);
            // 
            // lbIndexerPriority
            // 
            this.lbIndexerPriority.FormattingEnabled = true;
            this.lbIndexerPriority.ItemHeight = 12;
            this.lbIndexerPriority.Location = new System.Drawing.Point(33, 17);
            this.lbIndexerPriority.Name = "lbIndexerPriority";
            this.lbIndexerPriority.Size = new System.Drawing.Size(106, 76);
            this.lbIndexerPriority.TabIndex = 42;
            this.lbIndexerPriority.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbIndexerPriority_MouseClick);
            // 
            // audioMenu
            // 
            this.audioMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioAddTrack,
            this.audioRemoveTrack});
            this.audioMenu.Name = "audioMenu";
            this.audioMenu.Size = new System.Drawing.Size(125, 48);
            this.audioMenu.Opening += new System.ComponentModel.CancelEventHandler(this.audioMenu_Opening);
            // 
            // audioAddTrack
            // 
            this.audioAddTrack.Name = "audioAddTrack";
            this.audioAddTrack.Size = new System.Drawing.Size(124, 22);
            this.audioAddTrack.Text = "加入欄位";
            this.audioAddTrack.Click += new System.EventHandler(this.audioAddTrack_Click);
            // 
            // audioRemoveTrack
            // 
            this.audioRemoveTrack.Name = "audioRemoveTrack";
            this.audioRemoveTrack.Size = new System.Drawing.Size(124, 22);
            this.audioRemoveTrack.Text = "移除欄位";
            this.audioRemoveTrack.Click += new System.EventHandler(this.audioRemoveTrack_Click);
            // 
            // avsProfile
            // 
            this.avsProfile.Location = new System.Drawing.Point(109, 83);
            this.avsProfile.Name = "avsProfile";
            this.avsProfile.ProfileSet = "AviSynth";
            this.avsProfile.Size = new System.Drawing.Size(298, 20);
            this.avsProfile.TabIndex = 39;
            // 
            // videoProfile
            // 
            this.videoProfile.Location = new System.Drawing.Point(77, 43);
            this.videoProfile.Name = "videoProfile";
            this.videoProfile.ProfileSet = "Video";
            this.videoProfile.Size = new System.Drawing.Size(330, 20);
            this.videoProfile.TabIndex = 40;
            // 
            // oneClickAudioControl1
            // 
            this.oneClickAudioControl1.Location = new System.Drawing.Point(6, 8);
            this.oneClickAudioControl1.Name = "oneClickAudioControl1";
            this.oneClickAudioControl1.Size = new System.Drawing.Size(386, 105);
            this.oneClickAudioControl1.TabIndex = 0;
            // 
            // splitSize
            // 
            this.splitSize.CustomSizes = new MeGUI.core.util.FileSize[0];
            this.splitSize.Location = new System.Drawing.Point(69, 45);
            this.splitSize.MaximumSize = new System.Drawing.Size(1000, 27);
            this.splitSize.MinimumSize = new System.Drawing.Size(64, 27);
            this.splitSize.Name = "splitSize";
            this.splitSize.NullString = "Dont split";
            this.splitSize.SaveCustomValues = false;
            this.splitSize.SelectedIndex = 0;
            this.splitSize.Size = new System.Drawing.Size(340, 27);
            this.splitSize.TabIndex = 41;
            // 
            // fileSize
            // 
            this.fileSize.CustomSizes = new MeGUI.core.util.FileSize[0];
            this.fileSize.Location = new System.Drawing.Point(69, 21);
            this.fileSize.MaximumSize = new System.Drawing.Size(1000, 27);
            this.fileSize.MinimumSize = new System.Drawing.Size(64, 27);
            this.fileSize.Name = "fileSize";
            this.fileSize.NullString = "Don\'t care";
            this.fileSize.SaveCustomValues = false;
            this.fileSize.SelectedIndex = 0;
            this.fileSize.Size = new System.Drawing.Size(340, 27);
            this.fileSize.TabIndex = 42;
            // 
            // outputDirectory
            // 
            this.outputDirectory.Filename = "";
            this.outputDirectory.Filter = null;
            this.outputDirectory.FilterIndex = 0;
            this.outputDirectory.FolderMode = true;
            this.outputDirectory.Location = new System.Drawing.Point(64, 18);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.ReadOnly = true;
            this.outputDirectory.SaveMode = false;
            this.outputDirectory.Size = new System.Drawing.Size(300, 24);
            this.outputDirectory.TabIndex = 43;
            this.outputDirectory.Title = null;
            // 
            // workingDirectory
            // 
            this.workingDirectory.Filename = "";
            this.workingDirectory.Filter = null;
            this.workingDirectory.FilterIndex = 0;
            this.workingDirectory.FolderMode = true;
            this.workingDirectory.Location = new System.Drawing.Point(64, 47);
            this.workingDirectory.Name = "workingDirectory";
            this.workingDirectory.ReadOnly = true;
            this.workingDirectory.SaveMode = false;
            this.workingDirectory.Size = new System.Drawing.Size(300, 24);
            this.workingDirectory.TabIndex = 42;
            this.workingDirectory.Title = null;
            // 
            // OneClickConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "OneClickConfigPanel";
            this.Size = new System.Drawing.Size(433, 258);
            this.otherGroupBox.ResumeLayout(false);
            this.otherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalResolution)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.extraGroupbox.ResumeLayout(false);
            this.audioTab.ResumeLayout(false);
            this.audioPage0.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.audioMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox otherGroupBox;
        private System.Windows.Forms.CheckBox autoDeint;
        private System.Windows.Forms.CheckBox signalAR;
        private System.Windows.Forms.NumericUpDown horizontalResolution;
        private System.Windows.Forms.Label outputResolutionLabel;
        private System.Windows.Forms.CheckBox preprocessVideo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MeGUI.core.gui.ConfigableProfilesControl avsProfile;
        private System.Windows.Forms.CheckBox autoCrop;
        private System.Windows.Forms.CheckBox keepInputResolution;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox extraGroupbox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDefaultAudio;
        private System.Windows.Forms.ListBox lbNonDefaultAudio;
        private System.Windows.Forms.Button btnAudioDown;
        private System.Windows.Forms.Button btnAudioUp;
        private System.Windows.Forms.Button btnRemoveAudio;
        private System.Windows.Forms.Button btnAddAudio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubtitleDown;
        private System.Windows.Forms.Button btnSubtitleUp;
        private System.Windows.Forms.Button btnRemoveSubtitle;
        private System.Windows.Forms.Button btnAddSubtitle;
        private System.Windows.Forms.ListBox lbNonDefaultSubtitle;
        private System.Windows.Forms.ListBox lbDefaultSubtitle;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbIndexerPriority;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWorkingNameReplaceWith;
        private System.Windows.Forms.TextBox txtWorkingNameDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLanguageSelect;
        private System.Windows.Forms.GroupBox groupBox5;
        private FileBar outputDirectory;
        private System.Windows.Forms.Label label8;
        private FileBar workingDirectory;
        private System.Windows.Forms.Label workingDirectoryLabel;
        private System.Windows.Forms.Button btnIndexerDown;
        private System.Windows.Forms.Button btnIndexerUp;
        private System.Windows.Forms.TabControl audioTab;
        private System.Windows.Forms.TabPage audioPage0;
        private OneClickAudioControl oneClickAudioControl1;
        private System.Windows.Forms.ContextMenuStrip audioMenu;
        private System.Windows.Forms.ToolStripMenuItem audioAddTrack;
        private System.Windows.Forms.ToolStripMenuItem audioRemoveTrack;
        private System.Windows.Forms.TabPage audioPageAdd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkDontEncodeVideo;
        private System.Windows.Forms.CheckBox usechaptersmarks;
        private core.gui.ConfigableProfilesControl videoProfile;
        private System.Windows.Forms.Label videoCodecLabel;
        private System.Windows.Forms.GroupBox groupBox8;
        private core.gui.TargetSizeSCBox splitSize;
        private core.gui.TargetSizeSCBox fileSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filesizeLabel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckedListBox containerTypeList;
        private System.Windows.Forms.Label containerFormatLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeadingName;
        private System.Windows.Forms.Button deleteWorking;
        private System.Windows.Forms.Button deleteOutput;
        private System.Windows.Forms.CheckBox chkDisableIntermediateMKV;
        private System.Windows.Forms.ComboBox cbUnknownLanguage;
        private System.Windows.Forms.Label label4;
    }
}
