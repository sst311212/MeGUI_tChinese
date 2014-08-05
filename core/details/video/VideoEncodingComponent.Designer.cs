namespace MeGUI
{
    partial class VideoEncodingComponent
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
            this.videoOutputLabel = new System.Windows.Forms.Label();
            this.videoInputLabel = new System.Windows.Forms.Label();
            this.queueVideoButton = new System.Windows.Forms.Button();
            this.addAnalysisPass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.editZonesButton = new System.Windows.Forms.Button();
            this.videoProfile = new MeGUI.core.gui.ConfigableProfilesControl();
            this.label2 = new System.Windows.Forms.Label();
            this.videoInput = new MeGUI.FileBar();
            this.videoOutput = new MeGUI.FileBar();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.videopreview = new System.Windows.Forms.Button();
            this.addPrerenderJob = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoOutputLabel
            // 
            this.videoOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoOutputLabel.AutoSize = true;
            this.videoOutputLabel.Location = new System.Drawing.Point(3, 33);
            this.videoOutputLabel.Name = "videoOutputLabel";
            this.videoOutputLabel.Size = new System.Drawing.Size(108, 12);
            this.videoOutputLabel.TabIndex = 2;
            this.videoOutputLabel.Text = "視訊輸出";
            // 
            // videoInputLabel
            // 
            this.videoInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoInputLabel.AutoSize = true;
            this.videoInputLabel.Location = new System.Drawing.Point(3, 7);
            this.videoInputLabel.Name = "videoInputLabel";
            this.videoInputLabel.Size = new System.Drawing.Size(108, 12);
            this.videoInputLabel.TabIndex = 0;
            this.videoInputLabel.Text = "AviSynth 腳本";
            // 
            // queueVideoButton
            // 
            this.queueVideoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queueVideoButton.AutoSize = true;
            this.queueVideoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.queueVideoButton.Location = new System.Drawing.Point(435, 108);
            this.queueVideoButton.Name = "queueVideoButton";
            this.queueVideoButton.Size = new System.Drawing.Size(46, 22);
            this.queueVideoButton.TabIndex = 11;
            this.queueVideoButton.Text = "佇列";
            this.queueVideoButton.Click += new System.EventHandler(this.queueVideoButton_Click);
            // 
            // addAnalysisPass
            // 
            this.addAnalysisPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addAnalysisPass.AutoSize = true;
            this.addAnalysisPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAnalysisPass.Location = new System.Drawing.Point(276, 108);
            this.addAnalysisPass.Name = "addAnalysisPass";
            this.addAnalysisPass.Size = new System.Drawing.Size(153, 22);
            this.addAnalysisPass.TabIndex = 9;
            this.addAnalysisPass.Text = "佇列有效分析";
            this.addAnalysisPass.UseVisualStyleBackColor = true;
            this.addAnalysisPass.Click += new System.EventHandler(this.addAnalysisPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "視訊編碼";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.videoInputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.queueVideoButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.editZonesButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.videoOutputLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoProfile, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoOutput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.videopreview, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.addAnalysisPass, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.addPrerenderJob, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 134);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "檔案格式";
            // 
            // editZonesButton
            // 
            this.editZonesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editZonesButton.AutoSize = true;
            this.editZonesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editZonesButton.Location = new System.Drawing.Point(438, 81);
            this.editZonesButton.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.editZonesButton.Name = "editZonesButton";
            this.editZonesButton.Size = new System.Drawing.Size(40, 20);
            this.editZonesButton.TabIndex = 13;
            this.editZonesButton.Text = "範圍";
            this.editZonesButton.UseVisualStyleBackColor = true;
            this.editZonesButton.Click += new System.EventHandler(this.editZonesButton_Click);
            // 
            // videoProfile
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.videoProfile, 3);
            this.videoProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoProfile.Location = new System.Drawing.Point(117, 55);
            this.videoProfile.Name = "videoProfile";
            this.videoProfile.ProfileSet = "Video";
            this.videoProfile.Size = new System.Drawing.Size(364, 20);
            this.videoProfile.TabIndex = 12;
            this.videoProfile.SelectedProfileChanged += new System.EventHandler(this.videoProfile_SelectedProfileChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "編碼器設定";
            // 
            // videoInput
            // 
            this.videoInput.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.videoInput, 3);
            this.videoInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoInput.Filename = "";
            this.videoInput.Filter = "AviSynth 檔案 (*.avs)|*.avs|所有檔案 (*.*)|*.*";
            this.videoInput.FilterIndex = 0;
            this.videoInput.FolderMode = false;
            this.videoInput.Location = new System.Drawing.Point(117, 3);
            this.videoInput.Name = "videoInput";
            this.videoInput.ReadOnly = true;
            this.videoInput.SaveMode = false;
            this.videoInput.Size = new System.Drawing.Size(364, 20);
            this.videoInput.TabIndex = 1;
            this.videoInput.Title = "開啟 AviSynth 腳本";
            this.videoInput.FileSelected += new MeGUI.FileBarEventHandler(this.videoInput_FileSelected);
            // 
            // videoOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.videoOutput, 3);
            this.videoOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoOutput.Filename = "";
            this.videoOutput.Filter = null;
            this.videoOutput.FilterIndex = 0;
            this.videoOutput.FolderMode = false;
            this.videoOutput.Location = new System.Drawing.Point(117, 29);
            this.videoOutput.Name = "videoOutput";
            this.videoOutput.ReadOnly = false;
            this.videoOutput.SaveMode = true;
            this.videoOutput.Size = new System.Drawing.Size(364, 20);
            this.videoOutput.TabIndex = 3;
            this.videoOutput.Title = "輸入輸出名稱";
            this.videoOutput.FileSelected += new MeGUI.FileBarEventHandler(this.videoOutput_FileSelected);
            // 
            // fileType
            // 
            this.fileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileType.Location = new System.Drawing.Point(117, 81);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(153, 20);
            this.fileType.Sorted = true;
            this.fileType.TabIndex = 14;
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // videopreview
            // 
            this.videopreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videopreview.AutoSize = true;
            this.videopreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.videopreview.Location = new System.Drawing.Point(117, 108);
            this.videopreview.Name = "videopreview";
            this.videopreview.Size = new System.Drawing.Size(153, 22);
            this.videopreview.TabIndex = 16;
            this.videopreview.Text = "重新開啟視訊預覽";
            this.videopreview.UseVisualStyleBackColor = true;
            this.videopreview.Click += new System.EventHandler(this.videopreview_Click);
            // 
            // addPrerenderJob
            // 
            this.addPrerenderJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPrerenderJob.AutoSize = true;
            this.addPrerenderJob.Location = new System.Drawing.Point(3, 111);
            this.addPrerenderJob.Name = "addPrerenderJob";
            this.addPrerenderJob.Size = new System.Drawing.Size(108, 16);
            this.addPrerenderJob.TabIndex = 17;
            this.addPrerenderJob.Text = "加入預渲染任務";
            this.addPrerenderJob.UseVisualStyleBackColor = true;
            // 
            // VideoEncodingComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "VideoEncodingComponent";
            this.Size = new System.Drawing.Size(490, 155);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label videoOutputLabel;
        private System.Windows.Forms.Label videoInputLabel;
        private System.Windows.Forms.Button queueVideoButton;
        private System.Windows.Forms.Button addAnalysisPass;
        private FileBar videoInput;
        private FileBar videoOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private MeGUI.core.gui.ConfigableProfilesControl videoProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editZonesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.Button videopreview;
        private System.Windows.Forms.CheckBox addPrerenderJob;

    }
}
