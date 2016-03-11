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
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.textBoxAutoSavePath = new System.Windows.Forms.TextBox();
            this.buttonExamine = new System.Windows.Forms.Button();
            this.folderBrowserDialogAutoSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.labelAutoSavePath = new System.Windows.Forms.Label();
            this.label1AutoStartDevice = new System.Windows.Forms.Label();
            this.groupBoxAutostart = new System.Windows.Forms.GroupBox();
            this.groupBoxAutoSave = new System.Windows.Forms.GroupBox();
            this.groupBoxAutostart.SuspendLayout();
            this.groupBoxAutoSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 286);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(216, 286);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "&Ok";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Checked = global::Toolkit.Properties.Settings.Default.AutoStart;
            this.checkBoxAutoStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "AutoStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAutoStart.Location = new System.Drawing.Point(6, 0);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(103, 17);
            this.checkBoxAutoStart.TabIndex = 0;
            this.checkBoxAutoStart.Text = "Auto&start device";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.Enabled = false;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(9, 40);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDevices.TabIndex = 2;
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Checked = global::Toolkit.Properties.Settings.Default.AutoSave;
            this.checkBoxAutoSave.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Toolkit.Properties.Settings.Default, "AutoSave", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAutoSave.Location = new System.Drawing.Point(6, 0);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(115, 17);
            this.checkBoxAutoSave.TabIndex = 0;
            this.checkBoxAutoSave.Text = "Auto&save captures";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            // 
            // textBoxAutoSavePath
            // 
            this.textBoxAutoSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAutoSavePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Toolkit.Properties.Settings.Default, "DefaultPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxAutoSavePath.Enabled = false;
            this.textBoxAutoSavePath.Location = new System.Drawing.Point(9, 43);
            this.textBoxAutoSavePath.Name = "textBoxAutoSavePath";
            this.textBoxAutoSavePath.Size = new System.Drawing.Size(345, 20);
            this.textBoxAutoSavePath.TabIndex = 2;
            this.textBoxAutoSavePath.Text = global::Toolkit.Properties.Settings.Default.DefaultPath;
            // 
            // buttonExamine
            // 
            this.buttonExamine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExamine.Enabled = false;
            this.buttonExamine.Location = new System.Drawing.Point(279, 69);
            this.buttonExamine.Name = "buttonExamine";
            this.buttonExamine.Size = new System.Drawing.Size(75, 23);
            this.buttonExamine.TabIndex = 3;
            this.buttonExamine.Text = "&Examine...";
            this.buttonExamine.UseVisualStyleBackColor = true;
            this.buttonExamine.Click += new System.EventHandler(this.buttonExamine_Click);
            // 
            // labelAutoSavePath
            // 
            this.labelAutoSavePath.AutoSize = true;
            this.labelAutoSavePath.Location = new System.Drawing.Point(6, 24);
            this.labelAutoSavePath.Name = "labelAutoSavePath";
            this.labelAutoSavePath.Size = new System.Drawing.Size(87, 13);
            this.labelAutoSavePath.TabIndex = 1;
            this.labelAutoSavePath.Text = "&Destination path:";
            // 
            // label1AutoStartDevice
            // 
            this.label1AutoStartDevice.AutoSize = true;
            this.label1AutoStartDevice.Location = new System.Drawing.Point(6, 24);
            this.label1AutoStartDevice.Name = "label1AutoStartDevice";
            this.label1AutoStartDevice.Size = new System.Drawing.Size(79, 13);
            this.label1AutoStartDevice.TabIndex = 1;
            this.label1AutoStartDevice.Text = "&Default device:";
            // 
            // groupBoxAutostart
            // 
            this.groupBoxAutostart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAutostart.Controls.Add(this.checkBoxAutoStart);
            this.groupBoxAutostart.Controls.Add(this.label1AutoStartDevice);
            this.groupBoxAutostart.Controls.Add(this.comboBoxDevices);
            this.groupBoxAutostart.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAutostart.Name = "groupBoxAutostart";
            this.groupBoxAutostart.Size = new System.Drawing.Size(360, 74);
            this.groupBoxAutostart.TabIndex = 0;
            this.groupBoxAutostart.TabStop = false;
            // 
            // groupBoxAutoSave
            // 
            this.groupBoxAutoSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAutoSave.Controls.Add(this.checkBoxAutoSave);
            this.groupBoxAutoSave.Controls.Add(this.labelAutoSavePath);
            this.groupBoxAutoSave.Controls.Add(this.buttonExamine);
            this.groupBoxAutoSave.Controls.Add(this.textBoxAutoSavePath);
            this.groupBoxAutoSave.Location = new System.Drawing.Point(12, 92);
            this.groupBoxAutoSave.Name = "groupBoxAutoSave";
            this.groupBoxAutoSave.Size = new System.Drawing.Size(360, 100);
            this.groupBoxAutoSave.TabIndex = 2;
            this.groupBoxAutoSave.TabStop = false;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.groupBoxAutoSave);
            this.Controls.Add(this.groupBoxAutostart);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 360);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxAutostart.ResumeLayout(false);
            this.groupBoxAutostart.PerformLayout();
            this.groupBoxAutoSave.ResumeLayout(false);
            this.groupBoxAutoSave.PerformLayout();
            this.ResumeLayout(false);

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
    }
}