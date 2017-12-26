namespace Toolkit.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.folderBrowserDialogAutoSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.labelAutoSavePath = new System.Windows.Forms.Label();
            this.label1AutoStartDevice = new System.Windows.Forms.Label();
            this.groupBoxAutostart = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.groupBoxAutoSave = new System.Windows.Forms.GroupBox();
            this.checkBoxAlbumName = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.textBoxAutoSavePath = new System.Windows.Forms.TextBox();
            this.checkBoxCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.groupBoxAutostart.SuspendLayout();
            this.groupBoxAutoSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAccept
            // 
            resources.ApplyResources(this.buttonAccept, "buttonAccept");
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // comboBoxDevices
            // 
            resources.ApplyResources(this.comboBoxDevices, "comboBoxDevices");
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Name = "comboBoxDevices";
            // 
            // buttonExamine
            // 
            resources.ApplyResources(this.buttonExamine, "buttonExamine");
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.ButtonExamine_Click);
            // 
            // labelAutoSavePath
            // 
            resources.ApplyResources(this.labelAutoSavePath, "labelAutoSavePath");
            this.labelAutoSavePath.Name = "labelAutoSavePath";
            // 
            // label1AutoStartDevice
            // 
            resources.ApplyResources(this.label1AutoStartDevice, "label1AutoStartDevice");
            this.label1AutoStartDevice.Name = "label1AutoStartDevice";
            // 
            // groupBoxAutostart
            // 
            resources.ApplyResources(this.groupBoxAutostart, "groupBoxAutostart");
            this.groupBoxAutostart.Controls.Add(this.checkBoxAutoStart);
            this.groupBoxAutostart.Controls.Add(this.label1AutoStartDevice);
            this.groupBoxAutostart.Controls.Add(this.comboBoxDevices);
            this.groupBoxAutostart.Name = "groupBoxAutostart";
            this.groupBoxAutostart.TabStop = false;
            // 
            // checkBoxAutoStart
            // 
            resources.ApplyResources(this.checkBoxAutoStart, "checkBoxAutoStart");
            this.checkBoxAutoStart.Checked = global::Toolkit.Properties.Settings.Default.AutoStart;
            this.checkBoxAutoStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "AutoStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // groupBoxAutoSave
            // 
            resources.ApplyResources(this.groupBoxAutoSave, "groupBoxAutoSave");
            this.groupBoxAutoSave.Controls.Add(this.checkBoxAlbumName);
            this.groupBoxAutoSave.Controls.Add(this.checkBoxAutoSave);
            this.groupBoxAutoSave.Controls.Add(this.labelAutoSavePath);
            this.groupBoxAutoSave.Controls.Add(this.buttonExamine);
            this.groupBoxAutoSave.Controls.Add(this.textBoxAutoSavePath);
            this.groupBoxAutoSave.Name = "groupBoxAutoSave";
            this.groupBoxAutoSave.TabStop = false;
            // 
            // checkBoxAlbumName
            // 
            resources.ApplyResources(this.checkBoxAlbumName, "checkBoxAlbumName");
            this.checkBoxAlbumName.Checked = global::Toolkit.Properties.Settings.Default.AskAlbumName;
            this.checkBoxAlbumName.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "AskAlbumName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAlbumName.Name = "checkBoxAlbumName";
            this.checkBoxAlbumName.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSave
            // 
            resources.ApplyResources(this.checkBoxAutoSave, "checkBoxAutoSave");
            this.checkBoxAutoSave.Checked = global::Toolkit.Properties.Settings.Default.AutoSave;
            this.checkBoxAutoSave.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "AutoSave", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoSavePath
            // 
            resources.ApplyResources(this.textBoxAutoSavePath, "textBoxAutoSavePath");
            this.textBoxAutoSavePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Toolkit.Properties.Settings.Default, "DefaultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxAutoSavePath.Name = "textBoxAutoSavePath";
            this.textBoxAutoSavePath.Text = global::Toolkit.Properties.Settings.Default.DefaultPath;
            // 
            // checkBoxCheckForUpdates
            // 
            resources.ApplyResources(this.checkBoxCheckForUpdates, "checkBoxCheckForUpdates");
            this.checkBoxCheckForUpdates.Checked = global::Toolkit.Properties.Settings.Default.CheckForUpdates;
            this.checkBoxCheckForUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckForUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "CheckForUpdates", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCheckForUpdates.Name = "checkBoxCheckForUpdates";
            this.checkBoxCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.checkBoxCheckForUpdates);
            this.Controls.Add(this.groupBoxAutoSave);
            this.Controls.Add(this.groupBoxAutostart);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxAutostart.ResumeLayout(false);
            this.groupBoxAutostart.PerformLayout();
            this.groupBoxAutoSave.ResumeLayout(false);
            this.groupBoxAutoSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.TextBox textBoxAutoSavePath;
        private System.Windows.Forms.Button buttonExamine;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAutoSavePath;
        private System.Windows.Forms.Label labelAutoSavePath;
        private System.Windows.Forms.Label label1AutoStartDevice;
        private System.Windows.Forms.GroupBox groupBoxAutostart;
        private System.Windows.Forms.GroupBox groupBoxAutoSave;
        private System.Windows.Forms.CheckBox checkBoxAlbumName;
        private System.Windows.Forms.CheckBox checkBoxCheckForUpdates;
    }
}