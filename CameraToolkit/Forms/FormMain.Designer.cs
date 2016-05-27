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
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDevices = new System.Windows.Forms.ToolStripDropDownButton();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.helpProviderMain = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            resources.ApplyResources(this.pictureBoxCamera, "pictureBoxCamera");
            this.pictureBoxCamera.ContextMenuStrip = this.contextMenuStripImage;
            this.helpProviderMain.SetHelpKeyword(this.pictureBoxCamera, resources.GetString("pictureBoxCamera.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.pictureBoxCamera, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("pictureBoxCamera.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.pictureBoxCamera, resources.GetString("pictureBoxCamera.HelpString"));
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.helpProviderMain.SetShowHelp(this.pictureBoxCamera, ((bool)(resources.GetObject("pictureBoxCamera.ShowHelp"))));
            this.pictureBoxCamera.TabStop = false;
            this.toolTipMain.SetToolTip(this.pictureBoxCamera, resources.GetString("pictureBoxCamera.ToolTip"));
            // 
            // contextMenuStripImage
            // 
            resources.ApplyResources(this.contextMenuStripImage, "contextMenuStripImage");
            this.helpProviderMain.SetHelpKeyword(this.contextMenuStripImage, resources.GetString("contextMenuStripImage.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.contextMenuStripImage, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("contextMenuStripImage.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.contextMenuStripImage, resources.GetString("contextMenuStripImage.HelpString"));
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.helpProviderMain.SetShowHelp(this.contextMenuStripImage, ((bool)(resources.GetObject("contextMenuStripImage.ShowHelp"))));
            this.toolTipMain.SetToolTip(this.contextMenuStripImage, resources.GetString("contextMenuStripImage.ToolTip"));
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImage_Opening);
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripMenu
            // 
            resources.ApplyResources(this.toolStripMenu, "toolStripMenu");
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.helpProviderMain.SetHelpKeyword(this.toolStripMenu, resources.GetString("toolStripMenu.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this.toolStripMenu, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("toolStripMenu.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this.toolStripMenu, resources.GetString("toolStripMenu.HelpString"));
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
            this.toolTipMain.SetToolTip(this.toolStripMenu, resources.GetString("toolStripMenu.ToolTip"));
            // 
            // toolStripButtonDevices
            // 
            resources.ApplyResources(this.toolStripButtonDevices, "toolStripButtonDevices");
            this.toolStripButtonDevices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDevices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripButtonDevices.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonDevices.Name = "toolStripButtonDevices";
            this.toolStripButtonDevices.ShowDropDownArrow = false;
            // 
            // disconnectToolStripMenuItem
            // 
            resources.ApplyResources(this.disconnectToolStripMenuItem, "disconnectToolStripMenuItem");
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripSeparatorMain1
            // 
            resources.ApplyResources(this.toolStripSeparatorMain1, "toolStripSeparatorMain1");
            this.toolStripSeparatorMain1.Name = "toolStripSeparatorMain1";
            // 
            // toolStripButtonCapture
            // 
            resources.ApplyResources(this.toolStripButtonCapture, "toolStripButtonCapture");
            this.toolStripButtonCapture.CheckOnClick = true;
            this.toolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCapture.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCapture.Name = "toolStripButtonCapture";
            this.toolStripButtonCapture.Click += new System.EventHandler(this.toolStripButtonCapture_Click);
            // 
            // toolStripButtonSave
            // 
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonFolder
            // 
            resources.ApplyResources(this.toolStripButtonFolder, "toolStripButtonFolder");
            this.toolStripButtonFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFolder.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonFolder.Name = "toolStripButtonFolder";
            this.toolStripButtonFolder.Visible = global::Toolkit.Properties.Settings.Default.AutoSave;
            this.toolStripButtonFolder.Click += new System.EventHandler(this.toolStripButtonFolder_Click);
            // 
            // toolStripButtonClose
            // 
            resources.ApplyResources(this.toolStripButtonClose, "toolStripButtonClose");
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            resources.ApplyResources(this.toolStripButtonAbout, "toolStripButtonAbout");
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonSettings
            // 
            resources.ApplyResources(this.toolStripButtonSettings, "toolStripButtonSettings");
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
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
            resources.ApplyResources(this.toolStripMenuItemCamera, "toolStripMenuItemCamera");
            this.toolStripMenuItemCamera.Name = "toolStripMenuItemCamera";
            this.toolStripMenuItemCamera.Click += new System.EventHandler(this.toolStripMenuItemCamera_Click);
            // 
            // toolStripMenuItemSystem
            // 
            resources.ApplyResources(this.toolStripMenuItemSystem, "toolStripMenuItemSystem");
            this.toolStripMenuItemSystem.Name = "toolStripMenuItemSystem";
            this.toolStripMenuItemSystem.Click += new System.EventHandler(this.toolStripMenuItemSystem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripButtonGallery
            // 
            resources.ApplyResources(this.toolStripButtonGallery, "toolStripButtonGallery");
            this.toolStripButtonGallery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGallery.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonGallery.Name = "toolStripButtonGallery";
            this.toolStripButtonGallery.Click += new System.EventHandler(this.toolStripButtonGallery_Click);
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.DefaultExt = "jpg";
            resources.ApplyResources(this.saveFileDialogImage, "saveFileDialogImage");
            this.saveFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogImage_FileOk);
            // 
            // helpProviderMain
            // 
            resources.ApplyResources(this.helpProviderMain, "helpProviderMain");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxCamera);
            this.Controls.Add(this.toolStripMenu);
            this.helpProviderMain.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            this.helpProviderMain.SetHelpNavigator(this, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("$this.HelpNavigator"))));
            this.helpProviderMain.SetHelpString(this, resources.GetString("$this.HelpString"));
            this.Name = "FormMain";
            this.helpProviderMain.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.toolTipMain.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewer_FormClosing);
            this.Shown += new System.EventHandler(this.FormViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCapture;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonDevices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonFolder;
        private System.Windows.Forms.HelpProvider helpProviderMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCamera;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSystem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGallery;
    }
}