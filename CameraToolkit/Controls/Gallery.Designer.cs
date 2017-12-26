namespace Toolkit.Controls
{
    partial class Gallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gallery));
            this.imageListThumbs = new System.Windows.Forms.ImageList(this.components);
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.labelInformation = new System.Windows.Forms.Label();
            this.contextMenuStripActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListThumbs
            // 
            this.imageListThumbs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.imageListThumbs, "imageListThumbs");
            this.imageListThumbs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewItems
            // 
            this.listViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath,
            this.columnHeaderSize});
            this.listViewItems.ContextMenuStrip = this.contextMenuStripActions;
            resources.ApplyResources(this.listViewItems, "listViewItems");
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.LargeImageList = this.imageListThumbs;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.SmallImageList = this.imageListThumbs;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewItems_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            resources.ApplyResources(this.columnHeaderName, "columnHeaderName");
            // 
            // columnHeaderPath
            // 
            resources.ApplyResources(this.columnHeaderPath, "columnHeaderPath");
            // 
            // columnHeaderSize
            // 
            resources.ApplyResources(this.columnHeaderSize, "columnHeaderSize");
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            resources.ApplyResources(this.contextMenuStripActions, "contextMenuStripActions");
            this.contextMenuStripActions.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripActions_Opening);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.largeIconsToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.tilesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            resources.ApplyResources(this.listToolStripMenuItem, "listToolStripMenuItem");
            this.listToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            resources.ApplyResources(this.smallIconsToolStripMenuItem, "smallIconsToolStripMenuItem");
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.SmallIconsToolStripMenuItem_Click);
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            resources.ApplyResources(this.largeIconsToolStripMenuItem, "largeIconsToolStripMenuItem");
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.LargeIconsToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            resources.ApplyResources(this.detailsToolStripMenuItem, "detailsToolStripMenuItem");
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            resources.ApplyResources(this.tilesToolStripMenuItem, "tilesToolStripMenuItem");
            this.tilesToolStripMenuItem.Click += new System.EventHandler(this.TilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.FileSystemWatcher_Changed);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.FileSystemWatcher_Renamed);
            // 
            // labelInformation
            // 
            resources.ApplyResources(this.labelInformation, "labelInformation");
            this.labelInformation.Name = "labelInformation";
            // 
            // Gallery
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.listViewItems);
            this.DoubleBuffered = true;
            this.Name = "Gallery";
            this.Load += new System.EventHandler(this.Gallery_Load);
            this.contextMenuStripActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListThumbs;
        private System.Windows.Forms.ListView listViewItems;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label labelInformation;
    }
}
