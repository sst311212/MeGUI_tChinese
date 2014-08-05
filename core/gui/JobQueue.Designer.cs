namespace MeGUI.core.gui
{
    partial class JobQueue
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
            System.Windows.Forms.Button abortButton;
            System.Windows.Forms.Button deleteButton;
            this.jobColumHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.outputColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codecHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fpsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.queueListView = new System.Windows.Forms.ListView();
            this.ownerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queueContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostponedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WaitingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.startStopButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.editJobButton = new System.Windows.Forms.Button();
            abortButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            this.queueContextMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abortButton
            // 
            abortButton.AutoSize = true;
            abortButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            abortButton.Location = new System.Drawing.Point(123, 3);
            abortButton.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            abortButton.Name = "abortButton";
            abortButton.Size = new System.Drawing.Size(39, 22);
            abortButton.TabIndex = 3;
            abortButton.Text = "中止";
            abortButton.UseVisualStyleBackColor = true;
            abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            deleteButton.Location = new System.Drawing.Point(319, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(39, 22);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += new System.EventHandler(this.deleteJobButton_Click);
            // 
            // jobColumHeader
            // 
            this.jobColumHeader.Text = "名稱";
            // 
            // inputColumnHeader
            // 
            this.inputColumnHeader.Text = "輸入";
            // 
            // outputColumnHeader
            // 
            this.outputColumnHeader.Text = "輸出";
            // 
            // codecHeader
            // 
            this.codecHeader.Text = "編碼器";
            // 
            // modeHeader
            // 
            this.modeHeader.Text = "模式";
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "狀態";
            // 
            // startColumn
            // 
            this.startColumn.Text = "開始時間";
            // 
            // endColumn
            // 
            this.endColumn.Text = "結束時間";
            // 
            // fpsColumn
            // 
            this.fpsColumn.Text = "FPS";
            // 
            // upButton
            // 
            this.upButton.AutoSize = true;
            this.upButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upButton.Enabled = false;
            this.upButton.Location = new System.Drawing.Point(225, 3);
            this.upButton.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(39, 22);
            this.upButton.TabIndex = 6;
            this.upButton.Text = "上移";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.AutoSize = true;
            this.downButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downButton.Enabled = false;
            this.downButton.Location = new System.Drawing.Point(270, 3);
            this.downButton.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(39, 22);
            this.downButton.TabIndex = 7;
            this.downButton.Text = "下移";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jobColumHeader,
            this.inputColumnHeader,
            this.outputColumnHeader,
            this.codecHeader,
            this.modeHeader,
            this.statusColumn,
            this.ownerHeader,
            this.startColumn,
            this.endColumn,
            this.fpsColumn});
            this.queueListView.ContextMenuStrip = this.queueContextMenu;
            this.queueListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueListView.FullRowSelect = true;
            this.queueListView.HideSelection = false;
            this.queueListView.Location = new System.Drawing.Point(0, 0);
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(692, 513);
            this.queueListView.TabIndex = 0;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            this.queueListView.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.queueListView_ColumnWidthChanged);
            this.queueListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.queueListView_ItemSelectionChanged);
            this.queueListView.VisibleChanged += new System.EventHandler(this.queueListView_VisibleChanged);
            this.queueListView.DoubleClick += new System.EventHandler(this.queueListView_DoubleClick);
            this.queueListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queueListView_KeyDown);
            // 
            // ownerHeader
            // 
            this.ownerHeader.Text = "工作區";
            // 
            // queueContextMenu
            // 
            this.queueContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteMenuItem,
            this.StatusMenuItem,
            this.AbortMenuItem,
            this.EditMenuItem,
            this.OpenMenuItem});
            this.queueContextMenu.Name = "queueContextMenu";
            this.queueContextMenu.Size = new System.Drawing.Size(143, 114);
            this.queueContextMenu.Opened += new System.EventHandler(this.queueContextMenu_Opened);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.ShortcutKeyDisplayString = "";
            this.DeleteMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteMenuItem.Text = "刪除(&D)";
            this.DeleteMenuItem.ToolTipText = "刪除任務";
            this.DeleteMenuItem.Click += new System.EventHandler(this.deleteJobButton_Click);
            // 
            // StatusMenuItem
            // 
            this.StatusMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PostponedMenuItem,
            this.WaitingMenuItem});
            this.StatusMenuItem.Name = "StatusMenuItem";
            this.StatusMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StatusMenuItem.Text = "變更狀態(&C)";
            // 
            // PostponedMenuItem
            // 
            this.PostponedMenuItem.Name = "PostponedMenuItem";
            this.PostponedMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PostponedMenuItem.Text = "已延遲(&P)";
            this.PostponedMenuItem.Click += new System.EventHandler(this.postponeMenuItem_Click);
            // 
            // WaitingMenuItem
            // 
            this.WaitingMenuItem.Name = "WaitingMenuItem";
            this.WaitingMenuItem.Size = new System.Drawing.Size(152, 22);
            this.WaitingMenuItem.Text = "等待中(&P)";
            this.WaitingMenuItem.Click += new System.EventHandler(this.waitingMenuItem_Click);
            // 
            // AbortMenuItem
            // 
            this.AbortMenuItem.Name = "AbortMenuItem";
            this.AbortMenuItem.ShortcutKeyDisplayString = "";
            this.AbortMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AbortMenuItem.Text = "中止(&A)";
            this.AbortMenuItem.ToolTipText = "停止任務";
            this.AbortMenuItem.Click += new System.EventHandler(this.AbortMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Enabled = false;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.ShortcutKeyDisplayString = "";
            this.EditMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditMenuItem.Text = "編輯(&E)";
            this.EditMenuItem.ToolTipText = "編輯任務\r\n所選的任務只能在等待中或已延遲" +
                "";
            this.EditMenuItem.Click += new System.EventHandler(this.editJobButton_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFileToolStripMenuItem,
            this.inputFolderToolStripMenuItem,
            this.outputFileToolStripMenuItem,
            this.outputFolderToolStripMenuItem});
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(142, 22);
            this.OpenMenuItem.Text = "開啟(&O)";
            // 
            // inputFileToolStripMenuItem
            // 
            this.inputFileToolStripMenuItem.Name = "inputFileToolStripMenuItem";
            this.inputFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputFileToolStripMenuItem.Text = "輸入檔案";
            this.inputFileToolStripMenuItem.Click += new System.EventHandler(this.inputFileToolStripMenuItem_Click);
            // 
            // inputFolderToolStripMenuItem
            // 
            this.inputFolderToolStripMenuItem.Name = "inputFolderToolStripMenuItem";
            this.inputFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inputFolderToolStripMenuItem.Text = "輸入目錄";
            this.inputFolderToolStripMenuItem.Click += new System.EventHandler(this.inputFolderToolStripMenuItem_Click);
            // 
            // outputFileToolStripMenuItem
            // 
            this.outputFileToolStripMenuItem.Name = "outputFileToolStripMenuItem";
            this.outputFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputFileToolStripMenuItem.Text = "輸出檔案";
            this.outputFileToolStripMenuItem.Click += new System.EventHandler(this.outputFileToolStripMenuItem_Click);
            // 
            // outputFolderToolStripMenuItem
            // 
            this.outputFolderToolStripMenuItem.Name = "outputFolderToolStripMenuItem";
            this.outputFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputFolderToolStripMenuItem.Text = "輸出目錄";
            this.outputFolderToolStripMenuItem.Click += new System.EventHandler(this.outputFolderToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.startStopButton);
            this.flowLayoutPanel1.Controls.Add(this.stopButton);
            this.flowLayoutPanel1.Controls.Add(this.pauseButton);
            this.flowLayoutPanel1.Controls.Add(abortButton);
            this.flowLayoutPanel1.Controls.Add(this.editJobButton);
            this.flowLayoutPanel1.Controls.Add(this.upButton);
            this.flowLayoutPanel1.Controls.Add(this.downButton);
            this.flowLayoutPanel1.Controls.Add(deleteButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 513);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(692, 29);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // startStopButton
            // 
            this.startStopButton.AutoSize = true;
            this.startStopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startStopButton.Location = new System.Drawing.Point(3, 3);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(39, 22);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "開始";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Location = new System.Drawing.Point(48, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(39, 22);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(93, 3);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(24, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // editJobButton
            // 
            this.editJobButton.AutoSize = true;
            this.editJobButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editJobButton.Enabled = false;
            this.editJobButton.Location = new System.Drawing.Point(176, 3);
            this.editJobButton.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.editJobButton.Name = "editJobButton";
            this.editJobButton.Size = new System.Drawing.Size(39, 22);
            this.editJobButton.TabIndex = 4;
            this.editJobButton.Text = "編輯";
            this.editJobButton.UseVisualStyleBackColor = true;
            this.editJobButton.Click += new System.EventHandler(this.editJobButton_Click);
            // 
            // JobQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.queueListView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "JobQueue";
            this.Size = new System.Drawing.Size(692, 542);
            this.Load += new System.EventHandler(this.JobQueue_Load);
            this.queueContextMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.ContextMenuStrip queueContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostponedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WaitingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ColumnHeader ownerHeader;
        private System.Windows.Forms.ColumnHeader jobColumHeader;
        private System.Windows.Forms.ColumnHeader inputColumnHeader;
        private System.Windows.Forms.ColumnHeader outputColumnHeader;
        private System.Windows.Forms.ColumnHeader codecHeader;
        private System.Windows.Forms.ColumnHeader modeHeader;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ColumnHeader startColumn;
        private System.Windows.Forms.ColumnHeader endColumn;
        private System.Windows.Forms.ColumnHeader fpsColumn;
        private System.Windows.Forms.Button editJobButton;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFolderToolStripMenuItem;
    }
}
