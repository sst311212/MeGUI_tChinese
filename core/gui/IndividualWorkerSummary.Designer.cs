﻿namespace MeGUI.core.gui
{
    partial class IndividualWorkerSummary
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
            this.workerNameAndJob = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownLaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showProgressWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerNameAndJob.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerNameAndJob
            // 
            this.workerNameAndJob.Controls.Add(this.progressBar1);
            this.workerNameAndJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerNameAndJob.Location = new System.Drawing.Point(0, 0);
            this.workerNameAndJob.Name = "workerNameAndJob";
            this.workerNameAndJob.Padding = new System.Windows.Forms.Padding(5);
            this.workerNameAndJob.Size = new System.Drawing.Size(292, 43);
            this.workerNameAndJob.TabIndex = 0;
            this.workerNameAndJob.TabStop = false;
            this.workerNameAndJob.Text = "[名稱]: [狀態]";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(5, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 18);
            this.progressBar1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startEncodingToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.abortToolStripMenuItem,
            this.shutDownLaterToolStripMenuItem,
            this.shutDownToolStripMenuItem,
            this.toolStripSeparator1,
            this.showProgressWindowToolStripMenuItem,
            this.showQueueToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(312, 186);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // startEncodingToolStripMenuItem
            // 
            this.startEncodingToolStripMenuItem.Name = "startEncodingToolStripMenuItem";
            this.startEncodingToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.startEncodingToolStripMenuItem.Text = "開始工作區";
            this.startEncodingToolStripMenuItem.Click += new System.EventHandler(this.startEncodingToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.stopToolStripMenuItem.Text = "完成目前任務後停止工作區";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // abortToolStripMenuItem
            // 
            this.abortToolStripMenuItem.Name = "abortToolStripMenuItem";
            this.abortToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.abortToolStripMenuItem.Text = "立即中止任務並停止工作區";
            this.abortToolStripMenuItem.Click += new System.EventHandler(this.abortToolStripMenuItem_Click);
            // 
            // shutDownLaterToolStripMenuItem
            // 
            this.shutDownLaterToolStripMenuItem.Name = "shutDownLaterToolStripMenuItem";
            this.shutDownLaterToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.shutDownLaterToolStripMenuItem.Text = "完成工作區任務時刪除該工作區";
            this.shutDownLaterToolStripMenuItem.Click += new System.EventHandler(this.shutDownLaterToolStripMenuItem_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.shutDownToolStripMenuItem.Text = "立即刪除工作區";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(308, 6);
            // 
            // showProgressWindowToolStripMenuItem
            // 
            this.showProgressWindowToolStripMenuItem.Name = "showProgressWindowToolStripMenuItem";
            this.showProgressWindowToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.showProgressWindowToolStripMenuItem.Text = "顯示進度視窗";
            this.showProgressWindowToolStripMenuItem.Click += new System.EventHandler(this.showProgressWindowToolStripMenuItem_Click);
            // 
            // showQueueToolStripMenuItem
            // 
            this.showQueueToolStripMenuItem.Name = "showQueueToolStripMenuItem";
            this.showQueueToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.showQueueToolStripMenuItem.Text = "顯示佇列";
            this.showQueueToolStripMenuItem.Click += new System.EventHandler(this.showQueueToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.renameToolStripMenuItem.Text = "重新命名工作區";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // IndividualWorkerSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.workerNameAndJob);
            this.MaximumSize = new System.Drawing.Size(1000, 43);
            this.MinimumSize = new System.Drawing.Size(0, 43);
            this.Name = "IndividualWorkerSummary";
            this.Size = new System.Drawing.Size(292, 43);
            this.workerNameAndJob.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox workerNameAndJob;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProgressWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownLaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
