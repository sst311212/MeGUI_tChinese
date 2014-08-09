// ****************************************************************************
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


namespace MeGUI
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.rbCloseMeGUI = new System.Windows.Forms.RadioButton();
            this.command = new System.Windows.Forms.TextBox();
            this.runCommand = new System.Windows.Forms.RadioButton();
            this.shutdown = new System.Windows.Forms.RadioButton();
            this.donothing = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.otherGroupBox = new System.Windows.Forms.GroupBox();
            this.cbUseIncludedAviSynth = new System.Windows.Forms.CheckBox();
            this.cbOpenAVSinThread = new System.Windows.Forms.CheckBox();
            this.cbUseITUValues = new System.Windows.Forms.CheckBox();
            this.cbAutoStartQueueStartup = new System.Windows.Forms.CheckBox();
            this.acceptableFPSError = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.resetDialogs = new System.Windows.Forms.Button();
            this.configSourceDetector = new System.Windows.Forms.Button();
            this.openProgressWindow = new System.Windows.Forms.CheckBox();
            this.deleteIntermediateFiles = new System.Windows.Forms.CheckBox();
            this.deleteAbortedOutput = new System.Windows.Forms.CheckBox();
            this.deleteCompletedJobs = new System.Windows.Forms.CheckBox();
            this.openScript = new System.Windows.Forms.CheckBox();
            this.autostartQueue = new System.Windows.Forms.CheckBox();
            this.priority = new System.Windows.Forms.ComboBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.openExecutableDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.defaultLanguage2 = new System.Windows.Forms.ComboBox();
            this.defaultLanguage1 = new System.Windows.Forms.ComboBox();
            this.gbDefaultOutput = new System.Windows.Forms.GroupBox();
            this.btnClearOutputDirecoty = new System.Windows.Forms.Button();
            this.clearDefaultOutputDir = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHttpProxyMode = new System.Windows.Forms.ComboBox();
            this.txt_httpproxyport = new System.Windows.Forms.TextBox();
            this.txt_httpproxypwd = new System.Windows.Forms.TextBox();
            this.txt_httpproxyuid = new System.Windows.Forms.TextBox();
            this.txt_httpproxyaddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbVideoPreview = new System.Windows.Forms.GroupBox();
            this.chkEnsureCorrectPlaybackSpeed = new System.Windows.Forms.CheckBox();
            this.cbAddTimePos = new System.Windows.Forms.CheckBox();
            this.chAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.autoUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.cbAutoUpdateServerSubList = new System.Windows.Forms.ComboBox();
            this.backupfiles = new System.Windows.Forms.CheckBox();
            this.configureServersButton = new System.Windows.Forms.Button();
            this.useAutoUpdateCheckbox = new System.Windows.Forms.CheckBox();
            this.outputExtensions = new System.Windows.Forms.GroupBox();
            this.videoExtension = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.audioExtension = new System.Windows.Forms.TextBox();
            this.autoModeGroupbox = new System.Windows.Forms.GroupBox();
            this.chkAlwaysMuxMKV = new System.Windows.Forms.CheckBox();
            this.configAutoEncodeDefaults = new System.Windows.Forms.Button();
            this.keep2ndPassLogFile = new System.Windows.Forms.CheckBox();
            this.keep2ndPassOutput = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nbPasses = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.useX265 = new System.Windows.Forms.CheckBox();
            this.chx264ExternalMuxer = new System.Windows.Forms.CheckBox();
            this.useQAAC = new System.Windows.Forms.CheckBox();
            this.lblForcedName = new System.Windows.Forms.Label();
            this.txtForcedName = new System.Windows.Forms.TextBox();
            this.lblffmsThreads = new System.Windows.Forms.Label();
            this.ffmsThreads = new System.Windows.Forms.NumericUpDown();
            this.chkSelectHDTracks = new System.Windows.Forms.CheckBox();
            this.chkEnable64bitX264 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.useNeroAacEnc = new System.Windows.Forms.CheckBox();
            this.lblNero = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearMP4TempDirectory = new System.Windows.Forms.Button();
            this.vobGroupBox = new System.Windows.Forms.GroupBox();
            this.useDGIndexNV = new System.Windows.Forms.CheckBox();
            this.cbAutoLoadDG = new System.Windows.Forms.CheckBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.forceFilmPercentage = new System.Windows.Forms.NumericUpDown();
            this.autoForceFilm = new System.Windows.Forms.CheckBox();
            this.audioExtLabel = new System.Windows.Forms.Label();
            this.videoExtLabel = new System.Windows.Forms.Label();
            this.autoEncodeDefaultsButton = new System.Windows.Forms.Button();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.helpButton1 = new MeGUI.core.gui.HelpButton();
            this.targetSizeSCBox1 = new MeGUI.core.gui.TargetSizeSCBox();
            this.defaultOutputDir = new MeGUI.FileBar();
            this.neroaacencLocation = new MeGUI.FileBar();
            this.tempDirMP4 = new MeGUI.FileBar();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.otherGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptableFPSError)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDefaultOutput.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbVideoPreview.SuspendLayout();
            this.autoUpdateGroupBox.SuspendLayout();
            this.outputExtensions.SuspendLayout();
            this.autoModeGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPasses)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ffmsThreads)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.vobGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forceFilmPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.rbCloseMeGUI);
            groupBox1.Controls.Add(this.command);
            groupBox1.Controls.Add(this.runCommand);
            groupBox1.Controls.Add(this.shutdown);
            groupBox1.Controls.Add(this.donothing);
            groupBox1.Location = new System.Drawing.Point(4, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(217, 95);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " 編碼完成後... ";
            // 
            // rbCloseMeGUI
            // 
            this.rbCloseMeGUI.AutoSize = true;
            this.rbCloseMeGUI.Location = new System.Drawing.Point(123, 43);
            this.rbCloseMeGUI.Name = "rbCloseMeGUI";
            this.rbCloseMeGUI.Size = new System.Drawing.Size(84, 17);
            this.rbCloseMeGUI.TabIndex = 4;
            this.rbCloseMeGUI.TabStop = true;
            this.rbCloseMeGUI.Text = "關閉 MeGUI";
            this.rbCloseMeGUI.UseVisualStyleBackColor = true;
            // 
            // command
            // 
            this.command.Enabled = false;
            this.command.Location = new System.Drawing.Point(10, 64);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(197, 21);
            this.command.TabIndex = 3;
            // 
            // runCommand
            // 
            this.runCommand.AutoSize = true;
            this.runCommand.Location = new System.Drawing.Point(11, 43);
            this.runCommand.Name = "runCommand";
            this.runCommand.Size = new System.Drawing.Size(77, 17);
            this.runCommand.TabIndex = 2;
            this.runCommand.Text = "執行命令:";
            this.runCommand.UseVisualStyleBackColor = true;
            this.runCommand.CheckedChanged += new System.EventHandler(this.runCommand_CheckedChanged);
            // 
            // shutdown
            // 
            this.shutdown.AutoSize = true;
            this.shutdown.Location = new System.Drawing.Point(123, 21);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(73, 17);
            this.shutdown.TabIndex = 1;
            this.shutdown.Text = "電腦關機";
            this.shutdown.UseVisualStyleBackColor = true;
            // 
            // donothing
            // 
            this.donothing.AutoSize = true;
            this.donothing.Checked = true;
            this.donothing.Location = new System.Drawing.Point(11, 20);
            this.donothing.Name = "donothing";
            this.donothing.Size = new System.Drawing.Size(61, 17);
            this.donothing.TabIndex = 0;
            this.donothing.TabStop = true;
            this.donothing.Text = "無動作";
            this.donothing.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(359, 418);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(48, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "儲存";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(430, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(48, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "取消";
            // 
            // otherGroupBox
            // 
            this.otherGroupBox.Controls.Add(this.cbUseIncludedAviSynth);
            this.otherGroupBox.Controls.Add(this.cbOpenAVSinThread);
            this.otherGroupBox.Controls.Add(this.cbUseITUValues);
            this.otherGroupBox.Controls.Add(this.cbAutoStartQueueStartup);
            this.otherGroupBox.Controls.Add(this.acceptableFPSError);
            this.otherGroupBox.Controls.Add(this.label15);
            this.otherGroupBox.Controls.Add(this.resetDialogs);
            this.otherGroupBox.Controls.Add(this.configSourceDetector);
            this.otherGroupBox.Controls.Add(this.openProgressWindow);
            this.otherGroupBox.Controls.Add(this.deleteIntermediateFiles);
            this.otherGroupBox.Controls.Add(this.deleteAbortedOutput);
            this.otherGroupBox.Controls.Add(this.deleteCompletedJobs);
            this.otherGroupBox.Controls.Add(this.openScript);
            this.otherGroupBox.Controls.Add(this.autostartQueue);
            this.otherGroupBox.Controls.Add(this.priority);
            this.otherGroupBox.Controls.Add(this.priorityLabel);
            this.otherGroupBox.Location = new System.Drawing.Point(2, 6);
            this.otherGroupBox.Name = "otherGroupBox";
            this.otherGroupBox.Size = new System.Drawing.Size(467, 275);
            this.otherGroupBox.TabIndex = 1;
            this.otherGroupBox.TabStop = false;
            this.otherGroupBox.Tag = "";
            this.otherGroupBox.Text = " 主要設定 ";
            // 
            // cbUseIncludedAviSynth
            // 
            this.cbUseIncludedAviSynth.Location = new System.Drawing.Point(13, 27);
            this.cbUseIncludedAviSynth.Name = "cbUseIncludedAviSynth";
            this.cbUseIncludedAviSynth.Size = new System.Drawing.Size(203, 17);
            this.cbUseIncludedAviSynth.TabIndex = 22;
            this.cbUseIncludedAviSynth.Text = "永遠使用內建的 AviSynth";
            this.cbUseIncludedAviSynth.CheckedChanged += new System.EventHandler(this.cbUseIncludedAviSynth_CheckedChanged);
            // 
            // cbOpenAVSinThread
            // 
            this.cbOpenAVSinThread.Checked = true;
            this.cbOpenAVSinThread.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenAVSinThread.Location = new System.Drawing.Point(309, 50);
            this.cbOpenAVSinThread.Name = "cbOpenAVSinThread";
            this.cbOpenAVSinThread.Size = new System.Drawing.Size(144, 17);
            this.cbOpenAVSinThread.TabIndex = 21;
            this.cbOpenAVSinThread.Text = "改善 AVS 開啟";
            // 
            // cbUseITUValues
            // 
            this.cbUseITUValues.Checked = true;
            this.cbUseITUValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseITUValues.Location = new System.Drawing.Point(309, 27);
            this.cbUseITUValues.Name = "cbUseITUValues";
            this.cbUseITUValues.Size = new System.Drawing.Size(144, 17);
            this.cbUseITUValues.TabIndex = 20;
            this.cbUseITUValues.Text = "使用 ITU 長寬比";
            // 
            // cbAutoStartQueueStartup
            // 
            this.cbAutoStartQueueStartup.AutoSize = true;
            this.cbAutoStartQueueStartup.Location = new System.Drawing.Point(13, 96);
            this.cbAutoStartQueueStartup.Name = "cbAutoStartQueueStartup";
            this.cbAutoStartQueueStartup.Size = new System.Drawing.Size(182, 17);
            this.cbAutoStartQueueStartup.TabIndex = 19;
            this.cbAutoStartQueueStartup.Text = "程式執行時開始佇列中的任務";
            this.cbAutoStartQueueStartup.UseVisualStyleBackColor = true;
            // 
            // acceptableFPSError
            // 
            this.acceptableFPSError.DecimalPlaces = 3;
            this.acceptableFPSError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.acceptableFPSError.Location = new System.Drawing.Point(151, 197);
            this.acceptableFPSError.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.acceptableFPSError.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.acceptableFPSError.Name = "acceptableFPSError";
            this.acceptableFPSError.Size = new System.Drawing.Size(79, 21);
            this.acceptableFPSError.TabIndex = 7;
            this.acceptableFPSError.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(10, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 32);
            this.label15.TabIndex = 6;
            this.label15.Text = "可接受的 FPS 錯誤\r\n    (位元率計算)";
            // 
            // resetDialogs
            // 
            this.resetDialogs.Location = new System.Drawing.Point(300, 164);
            this.resetDialogs.Name = "resetDialogs";
            this.resetDialogs.Size = new System.Drawing.Size(154, 23);
            this.resetDialogs.TabIndex = 16;
            this.resetDialogs.Text = "重設所有對話框";
            this.resetDialogs.UseVisualStyleBackColor = true;
            this.resetDialogs.Click += new System.EventHandler(this.resetDialogs_Click);
            // 
            // configSourceDetector
            // 
            this.configSourceDetector.Location = new System.Drawing.Point(300, 197);
            this.configSourceDetector.Name = "configSourceDetector";
            this.configSourceDetector.Size = new System.Drawing.Size(154, 23);
            this.configSourceDetector.TabIndex = 17;
            this.configSourceDetector.Text = "設定來源檢測器";
            this.configSourceDetector.UseVisualStyleBackColor = true;
            this.configSourceDetector.Click += new System.EventHandler(this.configSourceDetector_Click);
            // 
            // openProgressWindow
            // 
            this.openProgressWindow.Checked = true;
            this.openProgressWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openProgressWindow.Location = new System.Drawing.Point(309, 119);
            this.openProgressWindow.Name = "openProgressWindow";
            this.openProgressWindow.Size = new System.Drawing.Size(144, 17);
            this.openProgressWindow.TabIndex = 15;
            this.openProgressWindow.Text = "顯示進度視窗";
            // 
            // deleteIntermediateFiles
            // 
            this.deleteIntermediateFiles.Checked = true;
            this.deleteIntermediateFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteIntermediateFiles.Location = new System.Drawing.Point(309, 96);
            this.deleteIntermediateFiles.Name = "deleteIntermediateFiles";
            this.deleteIntermediateFiles.Size = new System.Drawing.Size(152, 17);
            this.deleteIntermediateFiles.TabIndex = 13;
            this.deleteIntermediateFiles.Text = "刪除媒體內部檔案";
            // 
            // deleteAbortedOutput
            // 
            this.deleteAbortedOutput.Checked = true;
            this.deleteAbortedOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteAbortedOutput.Location = new System.Drawing.Point(13, 50);
            this.deleteAbortedOutput.Name = "deleteAbortedOutput";
            this.deleteAbortedOutput.Size = new System.Drawing.Size(184, 17);
            this.deleteAbortedOutput.TabIndex = 12;
            this.deleteAbortedOutput.Text = "刪除中止任務的輸出檔案";
            // 
            // deleteCompletedJobs
            // 
            this.deleteCompletedJobs.Location = new System.Drawing.Point(309, 73);
            this.deleteCompletedJobs.Name = "deleteCompletedJobs";
            this.deleteCompletedJobs.Size = new System.Drawing.Size(144, 17);
            this.deleteCompletedJobs.TabIndex = 11;
            this.deleteCompletedJobs.Text = "刪除已完成任務";
            // 
            // openScript
            // 
            this.openScript.Checked = true;
            this.openScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openScript.Location = new System.Drawing.Point(13, 119);
            this.openScript.Name = "openScript";
            this.openScript.Size = new System.Drawing.Size(277, 17);
            this.openScript.TabIndex = 10;
            this.openScript.Text = "選擇 AviSynth 腳本後顯示視訊預覽";
            // 
            // autostartQueue
            // 
            this.autostartQueue.Checked = true;
            this.autostartQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autostartQueue.Location = new System.Drawing.Point(13, 73);
            this.autostartQueue.Name = "autostartQueue";
            this.autostartQueue.Size = new System.Drawing.Size(224, 17);
            this.autostartQueue.TabIndex = 9;
            this.autostartQueue.Text = "立即開始在佇列中的新任務";
            // 
            // priority
            // 
            this.priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority.Items.AddRange(new object[] {
            "低",
            "低於正常",
            "正常",
            "高於正常",
            "高"});
            this.priority.Location = new System.Drawing.Point(151, 166);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(80, 21);
            this.priority.TabIndex = 1;
            // 
            // priorityLabel
            // 
            this.priorityLabel.Location = new System.Drawing.Point(9, 169);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(88, 13);
            this.priorityLabel.TabIndex = 0;
            this.priorityLabel.Text = "預設優先度";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.gbDefaultOutput);
            this.tabPage1.Controls.Add(this.otherGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主要設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.defaultLanguage2);
            this.groupBox3.Controls.Add(this.defaultLanguage1);
            this.groupBox3.Location = new System.Drawing.Point(2, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 92);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 預設語言 ";
            // 
            // defaultLanguage2
            // 
            this.defaultLanguage2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultLanguage2.Location = new System.Drawing.Point(13, 56);
            this.defaultLanguage2.Name = "defaultLanguage2";
            this.defaultLanguage2.Size = new System.Drawing.Size(152, 21);
            this.defaultLanguage2.Sorted = true;
            this.defaultLanguage2.TabIndex = 7;
            // 
            // defaultLanguage1
            // 
            this.defaultLanguage1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultLanguage1.Location = new System.Drawing.Point(13, 29);
            this.defaultLanguage1.Name = "defaultLanguage1";
            this.defaultLanguage1.Size = new System.Drawing.Size(152, 21);
            this.defaultLanguage1.Sorted = true;
            this.defaultLanguage1.TabIndex = 2;
            // 
            // gbDefaultOutput
            // 
            this.gbDefaultOutput.Controls.Add(this.targetSizeSCBox1);
            this.gbDefaultOutput.Controls.Add(this.btnClearOutputDirecoty);
            this.gbDefaultOutput.Controls.Add(this.clearDefaultOutputDir);
            this.gbDefaultOutput.Controls.Add(this.defaultOutputDir);
            this.gbDefaultOutput.Location = new System.Drawing.Point(182, 287);
            this.gbDefaultOutput.Name = "gbDefaultOutput";
            this.gbDefaultOutput.Size = new System.Drawing.Size(287, 92);
            this.gbDefaultOutput.TabIndex = 7;
            this.gbDefaultOutput.TabStop = false;
            this.gbDefaultOutput.Text = " 預設輸出目錄 + 自訂義檔案大小數值 ";
            this.gbDefaultOutput.UseWaitCursor = true;
            // 
            // btnClearOutputDirecoty
            // 
            this.btnClearOutputDirecoty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearOutputDirecoty.Location = new System.Drawing.Point(257, 25);
            this.btnClearOutputDirecoty.Name = "btnClearOutputDirecoty";
            this.btnClearOutputDirecoty.Size = new System.Drawing.Size(24, 23);
            this.btnClearOutputDirecoty.TabIndex = 43;
            this.btnClearOutputDirecoty.Text = "x";
            this.btnClearOutputDirecoty.UseWaitCursor = true;
            this.btnClearOutputDirecoty.Click += new System.EventHandler(this.btnClearOutputDirecoty_Click);
            // 
            // clearDefaultOutputDir
            // 
            this.clearDefaultOutputDir.Location = new System.Drawing.Point(430, 29);
            this.clearDefaultOutputDir.Name = "clearDefaultOutputDir";
            this.clearDefaultOutputDir.Size = new System.Drawing.Size(24, 26);
            this.clearDefaultOutputDir.TabIndex = 41;
            this.clearDefaultOutputDir.Text = "x";
            this.clearDefaultOutputDir.UseWaitCursor = true;
            this.clearDefaultOutputDir.Click += new System.EventHandler(this.clearDefaultOutputDir_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.gbVideoPreview);
            this.tabPage3.Controls.Add(groupBox1);
            this.tabPage3.Controls.Add(this.autoUpdateGroupBox);
            this.tabPage3.Controls.Add(this.outputExtensions);
            this.tabPage3.Controls.Add(this.autoModeGroupbox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(475, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "額外設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbHttpProxyMode);
            this.groupBox2.Controls.Add(this.txt_httpproxyport);
            this.groupBox2.Controls.Add(this.txt_httpproxypwd);
            this.groupBox2.Controls.Add(this.txt_httpproxyuid);
            this.groupBox2.Controls.Add(this.txt_httpproxyaddress);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(227, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 自動更新 Http 代理伺服器 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "使用:";
            // 
            // cbHttpProxyMode
            // 
            this.cbHttpProxyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHttpProxyMode.FormattingEnabled = true;
            this.cbHttpProxyMode.Items.AddRange(new object[] {
            "無",
            "系統代理伺服器",
            "自訂義代理伺服器",
            "登入自訂義代理伺服器"});
            this.cbHttpProxyMode.Location = new System.Drawing.Point(55, 25);
            this.cbHttpProxyMode.Name = "cbHttpProxyMode";
            this.cbHttpProxyMode.Size = new System.Drawing.Size(179, 21);
            this.cbHttpProxyMode.TabIndex = 9;
            this.cbHttpProxyMode.SelectedIndexChanged += new System.EventHandler(this.cbHttpProxyMode_SelectedIndexChanged);
            // 
            // txt_httpproxyport
            // 
            this.txt_httpproxyport.Enabled = false;
            this.txt_httpproxyport.Location = new System.Drawing.Point(191, 52);
            this.txt_httpproxyport.Name = "txt_httpproxyport";
            this.txt_httpproxyport.Size = new System.Drawing.Size(43, 21);
            this.txt_httpproxyport.TabIndex = 6;
            // 
            // txt_httpproxypwd
            // 
            this.txt_httpproxypwd.Enabled = false;
            this.txt_httpproxypwd.Location = new System.Drawing.Point(55, 106);
            this.txt_httpproxypwd.Name = "txt_httpproxypwd";
            this.txt_httpproxypwd.PasswordChar = '*';
            this.txt_httpproxypwd.Size = new System.Drawing.Size(179, 21);
            this.txt_httpproxypwd.TabIndex = 8;
            // 
            // txt_httpproxyuid
            // 
            this.txt_httpproxyuid.Enabled = false;
            this.txt_httpproxyuid.Location = new System.Drawing.Point(55, 79);
            this.txt_httpproxyuid.Name = "txt_httpproxyuid";
            this.txt_httpproxyuid.Size = new System.Drawing.Size(179, 21);
            this.txt_httpproxyuid.TabIndex = 7;
            // 
            // txt_httpproxyaddress
            // 
            this.txt_httpproxyaddress.Enabled = false;
            this.txt_httpproxyaddress.Location = new System.Drawing.Point(55, 52);
            this.txt_httpproxyaddress.Name = "txt_httpproxyaddress";
            this.txt_httpproxyaddress.Size = new System.Drawing.Size(103, 21);
            this.txt_httpproxyaddress.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "密碼:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "帳號:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(164, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "埠:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "伺服器:";
            // 
            // gbVideoPreview
            // 
            this.gbVideoPreview.Controls.Add(this.chkEnsureCorrectPlaybackSpeed);
            this.gbVideoPreview.Controls.Add(this.cbAddTimePos);
            this.gbVideoPreview.Controls.Add(this.chAlwaysOnTop);
            this.gbVideoPreview.Location = new System.Drawing.Point(4, 288);
            this.gbVideoPreview.Name = "gbVideoPreview";
            this.gbVideoPreview.Size = new System.Drawing.Size(217, 90);
            this.gbVideoPreview.TabIndex = 4;
            this.gbVideoPreview.TabStop = false;
            this.gbVideoPreview.Text = " 視訊預覽 ";
            // 
            // chkEnsureCorrectPlaybackSpeed
            // 
            this.chkEnsureCorrectPlaybackSpeed.AutoSize = true;
            this.chkEnsureCorrectPlaybackSpeed.Location = new System.Drawing.Point(8, 63);
            this.chkEnsureCorrectPlaybackSpeed.Name = "chkEnsureCorrectPlaybackSpeed";
            this.chkEnsureCorrectPlaybackSpeed.Size = new System.Drawing.Size(134, 17);
            this.chkEnsureCorrectPlaybackSpeed.TabIndex = 2;
            this.chkEnsureCorrectPlaybackSpeed.Text = "確認正確的播放速度";
            this.chkEnsureCorrectPlaybackSpeed.UseVisualStyleBackColor = true;
            // 
            // cbAddTimePos
            // 
            this.cbAddTimePos.AutoSize = true;
            this.cbAddTimePos.Location = new System.Drawing.Point(8, 40);
            this.cbAddTimePos.Name = "cbAddTimePos";
            this.cbAddTimePos.Size = new System.Drawing.Size(98, 17);
            this.cbAddTimePos.TabIndex = 1;
            this.cbAddTimePos.Text = "加入時間位置";
            this.cbAddTimePos.UseVisualStyleBackColor = true;
            // 
            // chAlwaysOnTop
            // 
            this.chAlwaysOnTop.AutoSize = true;
            this.chAlwaysOnTop.Location = new System.Drawing.Point(8, 17);
            this.chAlwaysOnTop.Name = "chAlwaysOnTop";
            this.chAlwaysOnTop.Size = new System.Drawing.Size(133, 17);
            this.chAlwaysOnTop.TabIndex = 0;
            this.chAlwaysOnTop.Text = "設定表單 \"永遠在上\"";
            this.chAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // autoUpdateGroupBox
            // 
            this.autoUpdateGroupBox.Controls.Add(this.cbAutoUpdateServerSubList);
            this.autoUpdateGroupBox.Controls.Add(this.backupfiles);
            this.autoUpdateGroupBox.Controls.Add(this.configureServersButton);
            this.autoUpdateGroupBox.Controls.Add(this.useAutoUpdateCheckbox);
            this.autoUpdateGroupBox.Location = new System.Drawing.Point(227, 104);
            this.autoUpdateGroupBox.Name = "autoUpdateGroupBox";
            this.autoUpdateGroupBox.Size = new System.Drawing.Size(240, 133);
            this.autoUpdateGroupBox.TabIndex = 3;
            this.autoUpdateGroupBox.TabStop = false;
            this.autoUpdateGroupBox.Text = " 自動更新 ";
            // 
            // cbAutoUpdateServerSubList
            // 
            this.cbAutoUpdateServerSubList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutoUpdateServerSubList.FormattingEnabled = true;
            this.cbAutoUpdateServerSubList.Items.AddRange(new object[] {
            "使用穩定的更新伺服器",
            "使用開發的更新伺服器",
            "使用自訂的更新伺服器"});
            this.cbAutoUpdateServerSubList.Location = new System.Drawing.Point(9, 47);
            this.cbAutoUpdateServerSubList.Name = "cbAutoUpdateServerSubList";
            this.cbAutoUpdateServerSubList.Size = new System.Drawing.Size(225, 21);
            this.cbAutoUpdateServerSubList.TabIndex = 5;
            this.cbAutoUpdateServerSubList.SelectedIndexChanged += new System.EventHandler(this.cbAutoUpdateServerSubList_SelectedIndexChanged);
            // 
            // backupfiles
            // 
            this.backupfiles.AutoSize = true;
            this.backupfiles.Checked = true;
            this.backupfiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupfiles.Location = new System.Drawing.Point(9, 103);
            this.backupfiles.Name = "backupfiles";
            this.backupfiles.Size = new System.Drawing.Size(146, 17);
            this.backupfiles.TabIndex = 4;
            this.backupfiles.Text = "永遠在需要時備份檔案";
            this.backupfiles.UseVisualStyleBackColor = true;
            this.backupfiles.CheckedChanged += new System.EventHandler(this.backupfiles_CheckedChanged);
            // 
            // configureServersButton
            // 
            this.configureServersButton.AutoSize = true;
            this.configureServersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configureServersButton.Enabled = false;
            this.configureServersButton.Location = new System.Drawing.Point(9, 74);
            this.configureServersButton.Name = "configureServersButton";
            this.configureServersButton.Size = new System.Drawing.Size(125, 23);
            this.configureServersButton.TabIndex = 1;
            this.configureServersButton.Text = "設定自訂義伺服器...";
            this.configureServersButton.UseVisualStyleBackColor = true;
            this.configureServersButton.Click += new System.EventHandler(this.configureServersButton_Click);
            // 
            // useAutoUpdateCheckbox
            // 
            this.useAutoUpdateCheckbox.AutoSize = true;
            this.useAutoUpdateCheckbox.Location = new System.Drawing.Point(9, 22);
            this.useAutoUpdateCheckbox.Name = "useAutoUpdateCheckbox";
            this.useAutoUpdateCheckbox.Size = new System.Drawing.Size(98, 17);
            this.useAutoUpdateCheckbox.TabIndex = 0;
            this.useAutoUpdateCheckbox.Text = "使用自動更新";
            this.useAutoUpdateCheckbox.UseVisualStyleBackColor = true;
            // 
            // outputExtensions
            // 
            this.outputExtensions.Controls.Add(this.videoExtension);
            this.outputExtensions.Controls.Add(this.label11);
            this.outputExtensions.Controls.Add(this.label12);
            this.outputExtensions.Controls.Add(this.audioExtension);
            this.outputExtensions.Location = new System.Drawing.Point(3, 104);
            this.outputExtensions.Name = "outputExtensions";
            this.outputExtensions.Size = new System.Drawing.Size(218, 77);
            this.outputExtensions.TabIndex = 1;
            this.outputExtensions.TabStop = false;
            this.outputExtensions.Text = " 可選的輸出副檔名 ";
            // 
            // videoExtension
            // 
            this.videoExtension.Location = new System.Drawing.Point(11, 20);
            this.videoExtension.Name = "videoExtension";
            this.videoExtension.Size = new System.Drawing.Size(120, 21);
            this.videoExtension.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "音訊";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "視訊";
            // 
            // audioExtension
            // 
            this.audioExtension.Location = new System.Drawing.Point(11, 48);
            this.audioExtension.Name = "audioExtension";
            this.audioExtension.Size = new System.Drawing.Size(120, 21);
            this.audioExtension.TabIndex = 2;
            // 
            // autoModeGroupbox
            // 
            this.autoModeGroupbox.Controls.Add(this.chkAlwaysMuxMKV);
            this.autoModeGroupbox.Controls.Add(this.configAutoEncodeDefaults);
            this.autoModeGroupbox.Controls.Add(this.keep2ndPassLogFile);
            this.autoModeGroupbox.Controls.Add(this.keep2ndPassOutput);
            this.autoModeGroupbox.Controls.Add(this.label13);
            this.autoModeGroupbox.Controls.Add(this.nbPasses);
            this.autoModeGroupbox.Location = new System.Drawing.Point(4, 3);
            this.autoModeGroupbox.Name = "autoModeGroupbox";
            this.autoModeGroupbox.Size = new System.Drawing.Size(463, 95);
            this.autoModeGroupbox.TabIndex = 0;
            this.autoModeGroupbox.TabStop = false;
            this.autoModeGroupbox.Text = " 自動編碼 ";
            // 
            // chkAlwaysMuxMKV
            // 
            this.chkAlwaysMuxMKV.AutoSize = true;
            this.chkAlwaysMuxMKV.Checked = true;
            this.chkAlwaysMuxMKV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysMuxMKV.Location = new System.Drawing.Point(232, 70);
            this.chkAlwaysMuxMKV.Name = "chkAlwaysMuxMKV";
            this.chkAlwaysMuxMKV.Size = new System.Drawing.Size(175, 17);
            this.chkAlwaysMuxMKV.TabIndex = 21;
            this.chkAlwaysMuxMKV.Text = "永遠使用 mkvmerge 合成 mkv";
            this.chkAlwaysMuxMKV.UseVisualStyleBackColor = true;
            // 
            // configAutoEncodeDefaults
            // 
            this.configAutoEncodeDefaults.AutoSize = true;
            this.configAutoEncodeDefaults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configAutoEncodeDefaults.Location = new System.Drawing.Point(14, 47);
            this.configAutoEncodeDefaults.Name = "configAutoEncodeDefaults";
            this.configAutoEncodeDefaults.Size = new System.Drawing.Size(137, 23);
            this.configAutoEncodeDefaults.TabIndex = 5;
            this.configAutoEncodeDefaults.Text = "設定自動編碼預設值...";
            this.configAutoEncodeDefaults.UseVisualStyleBackColor = true;
            this.configAutoEncodeDefaults.Click += new System.EventHandler(this.autoEncodeDefaultsButton_Click);
            // 
            // keep2ndPassLogFile
            // 
            this.keep2ndPassLogFile.AutoSize = true;
            this.keep2ndPassLogFile.Checked = true;
            this.keep2ndPassLogFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keep2ndPassLogFile.Location = new System.Drawing.Point(232, 22);
            this.keep2ndPassLogFile.Name = "keep2ndPassLogFile";
            this.keep2ndPassLogFile.Size = new System.Drawing.Size(162, 17);
            this.keep2ndPassLogFile.TabIndex = 4;
            this.keep2ndPassLogFile.Text = "3 次編碼時複寫 Stats 檔案";
            this.keep2ndPassLogFile.UseVisualStyleBackColor = true;
            // 
            // keep2ndPassOutput
            // 
            this.keep2ndPassOutput.AutoSize = true;
            this.keep2ndPassOutput.Checked = true;
            this.keep2ndPassOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keep2ndPassOutput.Location = new System.Drawing.Point(232, 47);
            this.keep2ndPassOutput.Name = "keep2ndPassOutput";
            this.keep2ndPassOutput.Size = new System.Drawing.Size(218, 17);
            this.keep2ndPassOutput.TabIndex = 3;
            this.keep2ndPassOutput.Text = "在 3 次編碼模式下保持 2 次編碼輸出";
            this.keep2ndPassOutput.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(11, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "編碼次數";
            // 
            // nbPasses
            // 
            this.nbPasses.Location = new System.Drawing.Point(117, 20);
            this.nbPasses.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nbPasses.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nbPasses.Name = "nbPasses";
            this.nbPasses.Size = new System.Drawing.Size(40, 21);
            this.nbPasses.TabIndex = 1;
            this.nbPasses.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.vobGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "外部程式設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.useX265);
            this.groupBox6.Controls.Add(this.chx264ExternalMuxer);
            this.groupBox6.Controls.Add(this.useQAAC);
            this.groupBox6.Controls.Add(this.lblForcedName);
            this.groupBox6.Controls.Add(this.txtForcedName);
            this.groupBox6.Controls.Add(this.lblffmsThreads);
            this.groupBox6.Controls.Add(this.ffmsThreads);
            this.groupBox6.Controls.Add(this.chkSelectHDTracks);
            this.groupBox6.Controls.Add(this.chkEnable64bitX264);
            this.groupBox6.Location = new System.Drawing.Point(4, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(467, 155);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " 雜項 ";
            // 
            // useX265
            // 
            this.useX265.AutoSize = true;
            this.useX265.Location = new System.Drawing.Point(12, 43);
            this.useX265.Name = "useX265";
            this.useX265.Size = new System.Drawing.Size(77, 17);
            this.useX265.TabIndex = 50;
            this.useX265.Text = "啟用 x265";
            this.useX265.UseVisualStyleBackColor = true;
            this.useX265.CheckedChanged += new System.EventHandler(this.useX265_CheckedChanged);
            // 
            // chx264ExternalMuxer
            // 
            this.chx264ExternalMuxer.AutoSize = true;
            this.chx264ExternalMuxer.Checked = true;
            this.chx264ExternalMuxer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chx264ExternalMuxer.Location = new System.Drawing.Point(225, 43);
            this.chx264ExternalMuxer.Name = "chx264ExternalMuxer";
            this.chx264ExternalMuxer.Size = new System.Drawing.Size(227, 17);
            this.chx264ExternalMuxer.TabIndex = 49;
            this.chx264ExternalMuxer.Text = "x264/x265: 使用外部合成器 (MKV, MP4)";
            this.chx264ExternalMuxer.UseVisualStyleBackColor = true;
            // 
            // useQAAC
            // 
            this.useQAAC.AutoSize = true;
            this.useQAAC.Location = new System.Drawing.Point(12, 20);
            this.useQAAC.Name = "useQAAC";
            this.useQAAC.Size = new System.Drawing.Size(82, 17);
            this.useQAAC.TabIndex = 48;
            this.useQAAC.Text = "啟用 QAAC";
            this.useQAAC.UseVisualStyleBackColor = true;
            this.useQAAC.CheckedChanged += new System.EventHandler(this.useQAAC_CheckedChanged);
            // 
            // lblForcedName
            // 
            this.lblForcedName.AutoSize = true;
            this.lblForcedName.Location = new System.Drawing.Point(11, 103);
            this.lblForcedName.Name = "lblForcedName";
            this.lblForcedName.Size = new System.Drawing.Size(134, 13);
            this.lblForcedName.TabIndex = 33;
            this.lblForcedName.Text = "加入文字道強制軌名稱: ";
            // 
            // txtForcedName
            // 
            this.txtForcedName.Location = new System.Drawing.Point(180, 100);
            this.txtForcedName.Name = "txtForcedName";
            this.txtForcedName.Size = new System.Drawing.Size(281, 21);
            this.txtForcedName.TabIndex = 32;
            // 
            // lblffmsThreads
            // 
            this.lblffmsThreads.AutoSize = true;
            this.lblffmsThreads.Location = new System.Drawing.Point(11, 66);
            this.lblffmsThreads.Name = "lblffmsThreads";
            this.lblffmsThreads.Size = new System.Drawing.Size(88, 13);
            this.lblffmsThreads.TabIndex = 31;
            this.lblffmsThreads.Text = "FFMS 線程數量:";
            // 
            // ffmsThreads
            // 
            this.ffmsThreads.Location = new System.Drawing.Point(123, 64);
            this.ffmsThreads.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ffmsThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ffmsThreads.Name = "ffmsThreads";
            this.ffmsThreads.Size = new System.Drawing.Size(38, 21);
            this.ffmsThreads.TabIndex = 30;
            this.ffmsThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkSelectHDTracks
            // 
            this.chkSelectHDTracks.AutoSize = true;
            this.chkSelectHDTracks.Checked = true;
            this.chkSelectHDTracks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelectHDTracks.Location = new System.Drawing.Point(225, 66);
            this.chkSelectHDTracks.Name = "chkSelectHDTracks";
            this.chkSelectHDTracks.Size = new System.Drawing.Size(158, 17);
            this.chkSelectHDTracks.TabIndex = 29;
            this.chkSelectHDTracks.Text = "HD 檔案提取: 選擇預設軌";
            this.chkSelectHDTracks.UseVisualStyleBackColor = true;
            // 
            // chkEnable64bitX264
            // 
            this.chkEnable64bitX264.AutoSize = true;
            this.chkEnable64bitX264.Checked = true;
            this.chkEnable64bitX264.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnable64bitX264.Location = new System.Drawing.Point(225, 20);
            this.chkEnable64bitX264.Name = "chkEnable64bitX264";
            this.chkEnable64bitX264.Size = new System.Drawing.Size(147, 17);
            this.chkEnable64bitX264.TabIndex = 28;
            this.chkEnable64bitX264.Text = "x264: 啟用 64 位元模式";
            this.chkEnable64bitX264.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.useNeroAacEnc);
            this.groupBox5.Controls.Add(this.lblNero);
            this.groupBox5.Controls.Add(this.neroaacencLocation);
            this.groupBox5.Location = new System.Drawing.Point(4, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(467, 70);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "                                        ";
            // 
            // useNeroAacEnc
            // 
            this.useNeroAacEnc.AutoSize = true;
            this.useNeroAacEnc.Location = new System.Drawing.Point(12, -1);
            this.useNeroAacEnc.Name = "useNeroAacEnc";
            this.useNeroAacEnc.Size = new System.Drawing.Size(111, 17);
            this.useNeroAacEnc.TabIndex = 46;
            this.useNeroAacEnc.Text = "啟用 NeroAacEnc";
            this.useNeroAacEnc.UseVisualStyleBackColor = true;
            this.useNeroAacEnc.CheckedChanged += new System.EventHandler(this.useNeroAacEnc_CheckedChanged);
            // 
            // lblNero
            // 
            this.lblNero.AutoSize = true;
            this.lblNero.Enabled = false;
            this.lblNero.Location = new System.Drawing.Point(11, 31);
            this.lblNero.Name = "lblNero";
            this.lblNero.Size = new System.Drawing.Size(31, 13);
            this.lblNero.TabIndex = 45;
            this.lblNero.Text = "位置";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearMP4TempDirectory);
            this.groupBox4.Controls.Add(this.tempDirMP4);
            this.groupBox4.Location = new System.Drawing.Point(5, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 54);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MP4 合成器暫存目錄";
            // 
            // btnClearMP4TempDirectory
            // 
            this.btnClearMP4TempDirectory.Location = new System.Drawing.Point(433, 21);
            this.btnClearMP4TempDirectory.Name = "btnClearMP4TempDirectory";
            this.btnClearMP4TempDirectory.Size = new System.Drawing.Size(24, 23);
            this.btnClearMP4TempDirectory.TabIndex = 42;
            this.btnClearMP4TempDirectory.Text = "x";
            this.btnClearMP4TempDirectory.Click += new System.EventHandler(this.btnClearMP4TempDirectory_Click);
            // 
            // vobGroupBox
            // 
            this.vobGroupBox.Controls.Add(this.useDGIndexNV);
            this.vobGroupBox.Controls.Add(this.cbAutoLoadDG);
            this.vobGroupBox.Controls.Add(this.percentLabel);
            this.vobGroupBox.Controls.Add(this.forceFilmPercentage);
            this.vobGroupBox.Controls.Add(this.autoForceFilm);
            this.vobGroupBox.Location = new System.Drawing.Point(4, 84);
            this.vobGroupBox.Name = "vobGroupBox";
            this.vobGroupBox.Size = new System.Drawing.Size(467, 76);
            this.vobGroupBox.TabIndex = 29;
            this.vobGroupBox.TabStop = false;
            this.vobGroupBox.Text = " DGIndex 工具";
            // 
            // useDGIndexNV
            // 
            this.useDGIndexNV.AutoSize = true;
            this.useDGIndexNV.Location = new System.Drawing.Point(12, 24);
            this.useDGIndexNV.Name = "useDGIndexNV";
            this.useDGIndexNV.Size = new System.Drawing.Size(108, 17);
            this.useDGIndexNV.TabIndex = 47;
            this.useDGIndexNV.Text = "啟用 DGIndexNV";
            this.useDGIndexNV.UseVisualStyleBackColor = true;
            this.useDGIndexNV.CheckedChanged += new System.EventHandler(this.useDGIndexNV_CheckedChanged);
            // 
            // cbAutoLoadDG
            // 
            this.cbAutoLoadDG.AutoSize = true;
            this.cbAutoLoadDG.Location = new System.Drawing.Point(225, 51);
            this.cbAutoLoadDG.Name = "cbAutoLoadDG";
            this.cbAutoLoadDG.Size = new System.Drawing.Size(148, 17);
            this.cbAutoLoadDG.TabIndex = 7;
            this.cbAutoLoadDG.Text = "自動讀取 VOB 增益檔案";
            this.cbAutoLoadDG.UseVisualStyleBackColor = true;
            // 
            // percentLabel
            // 
            this.percentLabel.Location = new System.Drawing.Point(397, 28);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(3);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(50, 13);
            this.percentLabel.TabIndex = 4;
            this.percentLabel.Text = "百分比";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // forceFilmPercentage
            // 
            this.forceFilmPercentage.Location = new System.Drawing.Point(351, 24);
            this.forceFilmPercentage.Name = "forceFilmPercentage";
            this.forceFilmPercentage.Size = new System.Drawing.Size(40, 21);
            this.forceFilmPercentage.TabIndex = 3;
            this.forceFilmPercentage.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // autoForceFilm
            // 
            this.autoForceFilm.Location = new System.Drawing.Point(225, 24);
            this.autoForceFilm.Name = "autoForceFilm";
            this.autoForceFilm.Size = new System.Drawing.Size(120, 17);
            this.autoForceFilm.TabIndex = 2;
            this.autoForceFilm.Text = "自動強制 Film 在";
            // 
            // audioExtLabel
            // 
            this.audioExtLabel.AutoSize = true;
            this.audioExtLabel.Location = new System.Drawing.Point(137, 51);
            this.audioExtLabel.Name = "audioExtLabel";
            this.audioExtLabel.Size = new System.Drawing.Size(34, 13);
            this.audioExtLabel.TabIndex = 24;
            this.audioExtLabel.Text = "音訊";
            // 
            // videoExtLabel
            // 
            this.videoExtLabel.AutoSize = true;
            this.videoExtLabel.Location = new System.Drawing.Point(137, 24);
            this.videoExtLabel.Name = "videoExtLabel";
            this.videoExtLabel.Size = new System.Drawing.Size(34, 13);
            this.videoExtLabel.TabIndex = 23;
            this.videoExtLabel.Text = "視訊";
            // 
            // autoEncodeDefaultsButton
            // 
            this.autoEncodeDefaultsButton.Location = new System.Drawing.Point(11, 51);
            this.autoEncodeDefaultsButton.Name = "autoEncodeDefaultsButton";
            this.autoEncodeDefaultsButton.Size = new System.Drawing.Size(114, 23);
            this.autoEncodeDefaultsButton.TabIndex = 4;
            this.autoEncodeDefaultsButton.Text = "設定預設值";
            this.autoEncodeDefaultsButton.UseVisualStyleBackColor = true;
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutoPopDelay = 30000;
            this.toolTipHelp.InitialDelay = 500;
            this.toolTipHelp.IsBalloon = true;
            this.toolTipHelp.ReshowDelay = 100;
            this.toolTipHelp.ShowAlways = true;
            // 
            // helpButton1
            // 
            this.helpButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton1.ArticleName = "Settings";
            this.helpButton1.AutoSize = true;
            this.helpButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton1.Location = new System.Drawing.Point(3, 418);
            this.helpButton1.Name = "helpButton1";
            this.helpButton1.Size = new System.Drawing.Size(56, 23);
            this.helpButton1.TabIndex = 1;
            // 
            // targetSizeSCBox1
            // 
            this.targetSizeSCBox1.CustomSizes = new MeGUI.core.util.FileSize[0];
            this.targetSizeSCBox1.Location = new System.Drawing.Point(8, 56);
            this.targetSizeSCBox1.MaximumSize = new System.Drawing.Size(1000, 28);
            this.targetSizeSCBox1.MinimumSize = new System.Drawing.Size(64, 28);
            this.targetSizeSCBox1.Name = "targetSizeSCBox1";
            this.targetSizeSCBox1.NullString = "修改自訂義檔案大小數值";
            this.targetSizeSCBox1.SaveCustomValues = true;
            this.targetSizeSCBox1.SelectedIndex = 0;
            this.targetSizeSCBox1.Size = new System.Drawing.Size(273, 28);
            this.targetSizeSCBox1.TabIndex = 44;
            this.targetSizeSCBox1.UseWaitCursor = true;
            // 
            // defaultOutputDir
            // 
            this.defaultOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultOutputDir.Filename = "";
            this.defaultOutputDir.Filter = null;
            this.defaultOutputDir.FilterIndex = 0;
            this.defaultOutputDir.FolderMode = true;
            this.defaultOutputDir.Location = new System.Drawing.Point(8, 24);
            this.defaultOutputDir.Name = "defaultOutputDir";
            this.defaultOutputDir.ReadOnly = true;
            this.defaultOutputDir.SaveMode = false;
            this.defaultOutputDir.Size = new System.Drawing.Size(243, 26);
            this.defaultOutputDir.TabIndex = 40;
            this.defaultOutputDir.Title = null;
            this.defaultOutputDir.UseWaitCursor = true;
            // 
            // neroaacencLocation
            // 
            this.neroaacencLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.neroaacencLocation.Enabled = false;
            this.neroaacencLocation.Filename = "";
            this.neroaacencLocation.Filter = "NeroAacEnc|neroaacenc.exe";
            this.neroaacencLocation.FilterIndex = 0;
            this.neroaacencLocation.FolderMode = false;
            this.neroaacencLocation.Location = new System.Drawing.Point(64, 26);
            this.neroaacencLocation.Name = "neroaacencLocation";
            this.neroaacencLocation.ReadOnly = true;
            this.neroaacencLocation.SaveMode = false;
            this.neroaacencLocation.Size = new System.Drawing.Size(399, 26);
            this.neroaacencLocation.TabIndex = 44;
            this.neroaacencLocation.Title = null;
            // 
            // tempDirMP4
            // 
            this.tempDirMP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tempDirMP4.Filename = "";
            this.tempDirMP4.Filter = null;
            this.tempDirMP4.FilterIndex = 0;
            this.tempDirMP4.FolderMode = true;
            this.tempDirMP4.Location = new System.Drawing.Point(12, 20);
            this.tempDirMP4.Name = "tempDirMP4";
            this.tempDirMP4.ReadOnly = true;
            this.tempDirMP4.SaveMode = false;
            this.tempDirMP4.Size = new System.Drawing.Size(418, 26);
            this.tempDirMP4.TabIndex = 41;
            this.tempDirMP4.Title = null;
            this.tempDirMP4.FileSelected += new MeGUI.FileBarEventHandler(this.tempDirMP4_FileSelected);
            // 
            // SettingsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(483, 446);
            this.Controls.Add(this.helpButton1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.otherGroupBox.ResumeLayout(false);
            this.otherGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptableFPSError)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbDefaultOutput.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbVideoPreview.ResumeLayout(false);
            this.gbVideoPreview.PerformLayout();
            this.autoUpdateGroupBox.ResumeLayout(false);
            this.autoUpdateGroupBox.PerformLayout();
            this.outputExtensions.ResumeLayout(false);
            this.outputExtensions.PerformLayout();
            this.autoModeGroupbox.ResumeLayout(false);
            this.autoModeGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPasses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ffmsThreads)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.vobGroupBox.ResumeLayout(false);
            this.vobGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forceFilmPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button resetDialogs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
        private System.Windows.Forms.Button configSourceDetector;
        private System.Windows.Forms.GroupBox otherGroupBox;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.OpenFileDialog openExecutableDialog;
        private System.Windows.Forms.CheckBox autostartQueue;
        private System.Windows.Forms.CheckBox openScript;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.CheckBox deleteCompletedJobs;
        private System.Windows.Forms.CheckBox deleteAbortedOutput;
        private System.Windows.Forms.CheckBox deleteIntermediateFiles;
        private System.Windows.Forms.CheckBox openProgressWindow;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox autoUpdateGroupBox;
        private System.Windows.Forms.CheckBox useAutoUpdateCheckbox;
        private System.Windows.Forms.GroupBox outputExtensions;
        private System.Windows.Forms.TextBox videoExtension;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox audioExtension;
        private System.Windows.Forms.GroupBox autoModeGroupbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nbPasses;
        private System.Windows.Forms.Label audioExtLabel;
        private System.Windows.Forms.Label videoExtLabel;
        private System.Windows.Forms.Button autoEncodeDefaultsButton;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.RadioButton runCommand;
        private System.Windows.Forms.RadioButton shutdown;
        private System.Windows.Forms.RadioButton donothing;
        private System.Windows.Forms.Button configureServersButton;
        private System.Windows.Forms.NumericUpDown acceptableFPSError;
        private System.Windows.Forms.Label label15;
        private MeGUI.core.gui.HelpButton helpButton1;
        private System.Windows.Forms.CheckBox keep2ndPassOutput;
        private System.Windows.Forms.CheckBox keep2ndPassLogFile;
        private System.Windows.Forms.Button configAutoEncodeDefaults;
        private System.Windows.Forms.GroupBox gbVideoPreview;
        private System.Windows.Forms.CheckBox chAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_httpproxyuid;
        private System.Windows.Forms.TextBox txt_httpproxyaddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_httpproxypwd;
        private System.Windows.Forms.TextBox txt_httpproxyport;
        private System.Windows.Forms.GroupBox gbDefaultOutput;
        private System.Windows.Forms.Button clearDefaultOutputDir;
        private FileBar defaultOutputDir;
        private System.Windows.Forms.CheckBox cbAddTimePos;
        private System.Windows.Forms.CheckBox backupfiles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox vobGroupBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.NumericUpDown forceFilmPercentage;
        private System.Windows.Forms.CheckBox autoForceFilm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearMP4TempDirectory;
        private FileBar tempDirMP4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbAutoLoadDG;
        private System.Windows.Forms.RadioButton rbCloseMeGUI;
        private System.Windows.Forms.CheckBox cbAutoStartQueueStartup;
        private System.Windows.Forms.ComboBox cbAutoUpdateServerSubList;
        private System.Windows.Forms.CheckBox chkAlwaysMuxMKV;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.CheckBox chkEnable64bitX264;
        private System.Windows.Forms.CheckBox chkEnsureCorrectPlaybackSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox defaultLanguage2;
        private System.Windows.Forms.ComboBox defaultLanguage1;
        private System.Windows.Forms.CheckBox chkSelectHDTracks;
        private System.Windows.Forms.Button btnClearOutputDirecoty;
        private System.Windows.Forms.NumericUpDown ffmsThreads;
        private System.Windows.Forms.Label lblffmsThreads;
        private System.Windows.Forms.Label lblForcedName;
        private System.Windows.Forms.TextBox txtForcedName;
        private System.Windows.Forms.CheckBox cbUseITUValues;
        private System.Windows.Forms.CheckBox cbOpenAVSinThread;
        private core.gui.TargetSizeSCBox targetSizeSCBox1;
        private FileBar neroaacencLocation;
        private System.Windows.Forms.CheckBox useNeroAacEnc;
        private System.Windows.Forms.Label lblNero;
        private System.Windows.Forms.CheckBox useDGIndexNV;
        private System.Windows.Forms.CheckBox useQAAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHttpProxyMode;
        private System.Windows.Forms.CheckBox chx264ExternalMuxer;
        private System.Windows.Forms.CheckBox useX265;
        private System.Windows.Forms.CheckBox cbUseIncludedAviSynth;
    }
}