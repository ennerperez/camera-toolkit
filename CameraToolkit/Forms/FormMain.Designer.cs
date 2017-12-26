namespace Toolkit.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDevices = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuDisconnectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparatorMain1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemCamera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGallery = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.helpProviderMain = new System.Windows.Forms.HelpProvider();
            this.panelCamera = new System.Windows.Forms.BufferedPanel();
            this.labelPreview = new System.Windows.Forms.Label();
            this.contextMenuStripImage.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panelCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.helpProviderMain.SetShowHelp(this.contextMenuStripImage, ((bool)(resources.GetObject("contextMenuStripImage.ShowHelp"))));
            resources.ApplyResources(this.contextMenuStripImage, "contextMenuStripImage");
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripImage_Opening);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            resources.ApplyResources(this.toolStripMenuItemCopy, "toolStripMenuItemCopy");
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDevices,
            this.toolStripSeparatorMain1,
            this.toolStripButtonCapture,
            this.toolStripButtonSave,
            this.toolStripButtonFolder,
            this.toolStripButtonClose,
            this.toolStripButtonAbout,
            this.toolStripButtonSettings,
            this.toolStripSeparator1,
            this.toolStripButtonGallery});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.helpProviderMain.SetShowHelp(this.toolStripMenu, ((bool)(resources.GetObject("toolStripMenu.ShowHelp"))));
            // 
            // toolStripButtonDevices
            // 
            resources.ApplyResources(this.toolStripButtonDevices, "toolStripButtonDevices");
            this.toolStripButtonDevices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDevices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDisconnectItem,
            this.toolStripSeparator2});
            this.toolStripButtonDevices.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonDevices.Name = "toolStripButtonDevices";
            this.toolStripButtonDevices.ShowDropDownArrow = false;
            // 
            // toolStripMenuDisconnectItem
            // 
            resources.ApplyResources(this.toolStripMenuDisconnectItem, "toolStripMenuDisconnectItem");
            this.toolStripMenuDisconnectItem.Name = "toolStripMenuDisconnectItem";
            this.toolStripMenuDisconnectItem.Click += new System.EventHandler(this.ToolStripMenuItemDisconnect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripSeparatorMain1
            // 
            this.toolStripSeparatorMain1.Name = "toolStripSeparatorMain1";
            resources.ApplyResources(this.toolStripSeparatorMain1, "toolStripSeparatorMain1");
            // 
            // toolStripButtonCapture
            // 
            resources.ApplyResources(this.toolStripButtonCapture, "toolStripButtonCapture");
            this.toolStripButtonCapture.CheckOnClick = true;
            this.toolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCapture.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCapture.Name = "toolStripButtonCapture";
            this.toolStripButtonCapture.Click += new System.EventHandler(this.ToolStripButtonCapture_Click);
            // 
            // toolStripButtonSave
            // 
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSave_Click);
            // 
            // toolStripButtonFolder
            // 
            resources.ApplyResources(this.toolStripButtonFolder, "toolStripButtonFolder");
            this.toolStripButtonFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFolder.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFolder.Name = "toolStripButtonFolder";
            this.toolStripButtonFolder.Visible = global::Toolkit.Properties.Settings.Default.AutoSave;
            this.toolStripButtonFolder.Click += new System.EventHandler(this.ToolStripButtonFolder_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.ToolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButtonSettings, "toolStripButtonSettings");
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCamera,
            this.toolStripMenuItemSystem});
            this.toolStripButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.ShowDropDownArrow = false;
            // 
            // toolStripMenuItemCamera
            // 
            this.toolStripMenuItemCamera.Name = "toolStripMenuItemCamera";
            resources.ApplyResources(this.toolStripMenuItemCamera, "toolStripMenuItemCamera");
            this.toolStripMenuItemCamera.Click += new System.EventHandler(this.ToolStripMenuItemCamera_Click);
            // 
            // toolStripMenuItemSystem
            // 
            this.toolStripMenuItemSystem.Name = "toolStripMenuItemSystem";
            resources.ApplyResources(this.toolStripMenuItemSystem, "toolStripMenuItemSystem");
            this.toolStripMenuItemSystem.Click += new System.EventHandler(this.ToolStripMenuItemSystem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonGallery
            // 
            resources.ApplyResources(this.toolStripButtonGallery, "toolStripButtonGallery");
            this.toolStripButtonGallery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGallery.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonGallery.Name = "toolStripButtonGallery";
            this.toolStripButtonGallery.Click += new System.EventHandler(this.ToolStripButtonGallery_Click);
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.DefaultExt = "jpg";
            resources.ApplyResources(this.saveFileDialogMain, "saveFileDialogMain");
            this.saveFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialogMain_FileOk);
            // 
            // panelCamera
            // 
            resources.ApplyResources(this.panelCamera, "panelCamera");
            this.panelCamera.ContextMenuStrip = this.contextMenuStripImage;
            this.panelCamera.Controls.Add(this.labelPreview);
            this.panelCamera.Name = "panelCamera";
            this.helpProviderMain.SetShowHelp(this.panelCamera, ((bool)(resources.GetObject("panelCamera.ShowHelp"))));
            // 
            // labelPreview
            // 
            this.labelPreview.AllowDrop = true;
            this.labelPreview.BackColor = System.Drawing.Color.Transparent;
            this.labelPreview.ContextMenuStrip = this.contextMenuStripImage;
            resources.ApplyResources(this.labelPreview, "labelPreview");
            this.labelPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPreview.Name = "labelPreview";
            this.helpProviderMain.SetShowHelp(this.labelPreview, ((bool)(resources.GetObject("labelPreview.ShowHelp"))));
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelCamera);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FormMain";
            this.helpProviderMain.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewer_FormClosing);
            this.Shown += new System.EventHandler(this.FormViewer_Shown);
            this.contextMenuStripImage.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BufferedPanel panelCamera;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCapture;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonDevices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDisconnectItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonFolder;
        private System.Windows.Forms.HelpProvider helpProviderMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCamera;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSystem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGallery;
        private System.Windows.Forms.Label labelPreview;
    }
}