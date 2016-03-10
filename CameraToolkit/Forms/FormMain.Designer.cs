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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDevices = new System.Windows.Forms.ToolStripDropDownButton();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparatorMain1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.contextMenuStripImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.ContextMenuStrip = this.contextMenuStripImage;
            this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamera.Location = new System.Drawing.Point(48, 0);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(576, 441);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamera.TabIndex = 0;
            this.pictureBoxCamera.TabStop = false;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.AutoSize = false;
            this.toolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.toolStripMenu.CanOverflow = false;
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDevices,
            this.toolStripSeparatorMain1,
            this.toolStripButtonCapture,
            this.toolStripButtonSave,
            this.toolStripButtonSettings,
            this.toolStripButtonClose,
            this.toolStripButtonAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMenu.Size = new System.Drawing.Size(48, 441);
            this.toolStripMenu.TabIndex = 2;
            // 
            // toolStripButtonDevices
            // 
            this.toolStripButtonDevices.AutoSize = false;
            this.toolStripButtonDevices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDevices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStripButtonDevices.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDevices.Image")));
            this.toolStripButtonDevices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDevices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDevices.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonDevices.Name = "toolStripButtonDevices";
            this.toolStripButtonDevices.ShowDropDownArrow = false;
            this.toolStripButtonDevices.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonDevices.Text = "&Device";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripMenuItem.Image")));
            this.disconnectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "&Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparatorMain1
            // 
            this.toolStripSeparatorMain1.Name = "toolStripSeparatorMain1";
            this.toolStripSeparatorMain1.Size = new System.Drawing.Size(47, 6);
            // 
            // toolStripButtonCapture
            // 
            this.toolStripButtonCapture.AutoSize = false;
            this.toolStripButtonCapture.CheckOnClick = true;
            this.toolStripButtonCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCapture.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCapture.Image")));
            this.toolStripButtonCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCapture.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonCapture.Name = "toolStripButtonCapture";
            this.toolStripButtonCapture.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonCapture.Text = "&Capture";
            this.toolStripButtonCapture.Click += new System.EventHandler(this.toolStripButtonCapture_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.AutoSize = false;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonSave.Text = "&Save...";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.AutoSize = false;
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonSettings.Text = "&Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.AutoSize = false;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonClose.Text = "&Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(48, 48);
            this.toolStripButtonAbout.Text = "&About...";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.DefaultExt = "jpg";
            this.saveFileDialogImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogImage_FileOk);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStripImage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripImage_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pictureBoxCamera);
            this.Controls.Add(this.toolStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraToolkit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewer_FormClosing);
            this.Shown += new System.EventHandler(this.FormViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.contextMenuStripImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCapture;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonDevices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}