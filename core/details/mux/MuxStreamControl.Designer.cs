namespace MeGUI.core.details.mux
{
    partial class MuxStreamControl
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
            this.subName = new System.Windows.Forms.TextBox();
            this.SubNamelabel = new System.Windows.Forms.Label();
            this.subtitleLanguage = new System.Windows.Forms.ComboBox();
            this.subtitleLanguageLabel = new System.Windows.Forms.Label();
            this.subtitleInputLabel = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.audioDelay = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.input = new MeGUI.FileBar();
            this.chkDefaultStream = new System.Windows.Forms.CheckBox();
            this.chkForceStream = new System.Windows.Forms.CheckBox();
            this.removeSubtitleTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.audioDelay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // subName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.subName, 2);
            this.subName.Location = new System.Drawing.Point(200, 28);
            this.subName.MaxLength = 100;
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(168, 22);
            this.subName.TabIndex = 40;
            // 
            // SubNamelabel
            // 
            this.SubNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubNamelabel.AutoSize = true;
            this.SubNamelabel.Location = new System.Drawing.Point(165, 33);
            this.SubNamelabel.Name = "SubNamelabel";
            this.SubNamelabel.Size = new System.Drawing.Size(29, 12);
            this.SubNamelabel.TabIndex = 39;
            this.SubNamelabel.Text = "名稱";
            // 
            // subtitleLanguage
            // 
            this.subtitleLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitleLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtitleLanguage.Location = new System.Drawing.Point(38, 29);
            this.subtitleLanguage.Name = "subtitleLanguage";
            this.subtitleLanguage.Size = new System.Drawing.Size(121, 20);
            this.subtitleLanguage.Sorted = true;
            this.subtitleLanguage.TabIndex = 37;
            // 
            // subtitleLanguageLabel
            // 
            this.subtitleLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitleLanguageLabel.AutoSize = true;
            this.subtitleLanguageLabel.Location = new System.Drawing.Point(3, 33);
            this.subtitleLanguageLabel.Name = "subtitleLanguageLabel";
            this.subtitleLanguageLabel.Size = new System.Drawing.Size(29, 12);
            this.subtitleLanguageLabel.TabIndex = 36;
            this.subtitleLanguageLabel.Text = "語言";
            // 
            // subtitleInputLabel
            // 
            this.subtitleInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitleInputLabel.AutoSize = true;
            this.subtitleInputLabel.Location = new System.Drawing.Point(3, 6);
            this.subtitleInputLabel.Name = "subtitleInputLabel";
            this.subtitleInputLabel.Size = new System.Drawing.Size(29, 12);
            this.subtitleInputLabel.TabIndex = 33;
            this.subtitleInputLabel.Text = "輸入";
            // 
            // delayLabel
            // 
            this.delayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(3, 62);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(29, 12);
            this.delayLabel.TabIndex = 43;
            this.delayLabel.Text = "延遲";
            // 
            // audioDelay
            // 
            this.audioDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.audioDelay.Location = new System.Drawing.Point(38, 57);
            this.audioDelay.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.audioDelay.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.audioDelay.Name = "audioDelay";
            this.audioDelay.Size = new System.Drawing.Size(121, 22);
            this.audioDelay.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.input, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.delayLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.subtitleInputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.audioDelay, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubNamelabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.subtitleLanguage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.subtitleLanguageLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkDefaultStream, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.removeSubtitleTrack, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkForceStream, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 83);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // input
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.input, 5);
            this.input.Filename = "";
            this.input.Filter = null;
            this.input.FilterIndex = 0;
            this.input.FolderMode = false;
            this.input.Location = new System.Drawing.Point(37, 2);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.Name = "input";
            this.input.ReadOnly = true;
            this.input.SaveMode = false;
            this.input.Size = new System.Drawing.Size(365, 21);
            this.input.TabIndex = 41;
            this.input.Title = null;
            this.input.FileSelected += new MeGUI.FileBarEventHandler(this.input_FileSelected);
            // 
            // chkDefaultStream
            // 
            this.chkDefaultStream.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDefaultStream.AutoSize = true;
            this.chkDefaultStream.Location = new System.Drawing.Point(200, 60);
            this.chkDefaultStream.Name = "chkDefaultStream";
            this.chkDefaultStream.Size = new System.Drawing.Size(72, 16);
            this.chkDefaultStream.TabIndex = 44;
            this.chkDefaultStream.Text = "預設軌道";
            this.chkDefaultStream.UseVisualStyleBackColor = true;
            this.chkDefaultStream.Visible = false;
            // 
            // chkForceStream
            // 
            this.chkForceStream.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkForceStream.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkForceStream, 2);
            this.chkForceStream.Location = new System.Drawing.Point(278, 60);
            this.chkForceStream.Name = "chkForceStream";
            this.chkForceStream.Size = new System.Drawing.Size(72, 16);
            this.chkForceStream.TabIndex = 45;
            this.chkForceStream.Text = "強制軌道";
            this.chkForceStream.UseVisualStyleBackColor = true;
            this.chkForceStream.Visible = false;
            this.chkForceStream.CheckedChanged += new System.EventHandler(this.chkForceStream_CheckedChanged);
            // 
            // removeSubtitleTrack
            // 
            this.removeSubtitleTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeSubtitleTrack.Location = new System.Drawing.Point(391, 28);
            this.removeSubtitleTrack.Margin = new System.Windows.Forms.Padding(0);
            this.removeSubtitleTrack.Name = "removeSubtitleTrack";
            this.removeSubtitleTrack.Size = new System.Drawing.Size(22, 21);
            this.removeSubtitleTrack.TabIndex = 46;
            this.removeSubtitleTrack.Text = "X";
            // 
            // MuxStreamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MuxStreamControl";
            this.Size = new System.Drawing.Size(434, 83);
            ((System.ComponentModel.ISupportInitialize)(this.audioDelay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox subName;
        protected System.Windows.Forms.Label SubNamelabel;
        protected System.Windows.Forms.ComboBox subtitleLanguage;
        protected System.Windows.Forms.Label subtitleLanguageLabel;
        protected System.Windows.Forms.Label subtitleInputLabel;
        protected System.Windows.Forms.Label delayLabel;
        protected System.Windows.Forms.NumericUpDown audioDelay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.CheckBox chkDefaultStream;
        public FileBar input;
        public System.Windows.Forms.CheckBox chkForceStream;
        protected System.Windows.Forms.Button removeSubtitleTrack;
    }
}
