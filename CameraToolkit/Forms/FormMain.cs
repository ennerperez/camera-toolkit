using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Pictograms;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(Program.Assembly.Location);

            // saveFileDialogMain
            saveFileDialogMain.DefaultExt = Program.Formats.FirstOrDefault();

            // Icons
            toolStripButtonDevices.SetImage(MaterialDesign.Instance, Program.Icon, 48, SystemColors.Control);
            toolStripButtonCapture.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.camera, 48, SystemColors.Control);
            toolStripButtonSave.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, SystemColors.Control);

            //toolStripMenuItemCamera.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings_brightness, 48, toolStripMenu.BackColor);
            //toolStripMenuItemSystem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings_system_daydream, 48, toolStripMenu.BackColor);

            toolStripMenuItemCamera.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.build, 48, toolStripMenu.BackColor);
            toolStripMenuItemSystem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings, 48, toolStripMenu.BackColor);

            toolStripButtonGallery.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.image, 48, SystemColors.Control);
            toolStripButtonFolder.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, SystemColors.Control);

            toolStripButtonSettings.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings, 48, SystemColors.Control);
            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, SystemColors.Control);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, SystemColors.Control);

            toolStripMenuDisconnectItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.videocam_off, 48, toolStripMenu.BackColor);

#if DEBUG
            FormHelper.ExtractResources(toolStripMenu);
#endif
        }

        private bool IsRunning()
        {
            return VideSource != null && VideSource.IsRunning;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            toolStripMenuDisconnectItem.PerformClick();

            Moniker = (sender as ToolStripMenuItem).Tag.ToString();
            DeviceName = (sender as ToolStripMenuItem).Text;

            var items = from item in toolStripButtonDevices.DropDownItems.OfType<ToolStripMenuItem>()
                        select item;

            foreach (var item in items)
                item.Enabled = true;

            (sender as ToolStripMenuItem).Enabled = false;

            try
            {
                VideSource = new VideoCaptureDevice(Moniker);
                VideSource.NewFrame += new NewFrameEventHandler(CaptureFrame);
                VideSource.Start();

                toolStripMenuDisconnectItem.Enabled = IsRunning();

                if (Properties.Settings.Default.AskAlbumName)
                    Program.ShowInputDialog(ref Program.AlbumName, "Album");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            labelPreview.Visible = !IsRunning();

            toolStripButtonCapture.Enabled = IsRunning();
            toolStripButtonSave.Enabled = IsRunning();
        }

        public string DeviceName { get; set; }
        public string Moniker { get; set; }
        public VideoCaptureDevice VideSource { get; set; }

        #region Clipboard

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelCamera.BackgroundImage != null)
                Clipboard.SetImage(panelCamera.BackgroundImage);
        }

        private void ContextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemCopy.Enabled = panelCamera.BackgroundImage != null;
        }

        #endregion Clipboard

        private bool paused;

        private void CaptureFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!paused)
            {
                var Imagen = (Bitmap)eventArgs.Frame.Clone();
                panelCamera.BackgroundImage = Imagen;
            }
        }

        private async void FormViewer_Shown(object sender, EventArgs e)
        {
            ToolStripMenuItem defaultDevice = null;
            foreach (var item in Program.GetDevices())
            {
                var _item = new ToolStripMenuItem(item.Value)
                {
                    Tag = item.Key
                };
                _item.Click += Item_Click;
                _item.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.videocam, 48, toolStripMenu.BackColor);
                toolStripButtonDevices.DropDownItems.Add(_item);

                if (Properties.Settings.Default.AutoStart && item.Key == Properties.Settings.Default.DefaultDevice)
                    defaultDevice = _item;
            }

            labelPreview.Visible = defaultDevice == null;

            if (defaultDevice != null)
                defaultDevice.PerformClick();

            if (Properties.Settings.Default.CheckForUpdates)
                await GitHubInfo.CheckForUpdateAsync();
        }

        private void FormViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            toolStripMenuDisconnectItem.PerformClick();
        }

        private void SaveFileDialogMain_FileOk(object sender, CancelEventArgs e)
        {
            if (IsRunning())
            {
                try
                {
                    var fileInfo = new FileInfo(saveFileDialogMain.FileName);
                    if (!fileInfo.Directory.Exists)
                        fileInfo.Directory.Create();

                    panelCamera.BackgroundImage.Save(saveFileDialogMain.FileName);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region ToolStrip

        private void ToolStripButtonCapture_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                paused = !paused;
            toolStripButtonCapture.Checked = paused;
        }

        private void ToolStripMenuItemDisconnect_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {
                VideSource.SignalToStop();
                VideSource.NewFrame -= new NewFrameEventHandler(CaptureFrame);
                VideSource = null;
                panelCamera.BackgroundImage = null;
            }

            labelPreview.Visible = !IsRunning();

            var items = from item in toolStripButtonDevices.DropDownItems.OfType<ToolStripMenuItem>()
                        select item;

            foreach (var item in items)
                item.Enabled = true;

            paused = false;
            toolStripButtonCapture.Checked = paused;
            toolStripButtonCapture.Enabled = IsRunning();
            toolStripButtonSave.Enabled = IsRunning();

            toolStripMenuDisconnectItem.Enabled = IsRunning();

            Program.AlbumName = string.Empty;
        }

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {
                var i = 1;
                string filename = string.Empty;

                while (filename == string.Empty || File.Exists(filename))
                {
                    filename = string.Format("{0}_{1}_{2}_{3}.jpg", DeviceName.Replace(' ', '_'), Program.SessionId, DateTime.Now.ToString("yyyyMMdd"), i.ToString());
                    if (Properties.Settings.Default.AutoSave &&
                        !string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) &&
                        Directory.Exists(Properties.Settings.Default.DefaultPath))
                    {
                        if (Properties.Settings.Default.AskAlbumName && string.IsNullOrEmpty(Program.AlbumName))
                            Program.ShowInputDialog(ref Program.AlbumName, "Album");

                        filename = Path.Combine(Properties.Settings.Default.DefaultPath, Program.AlbumName, filename);
                    }
                    i++;
                }

                saveFileDialogMain.FileName = filename;

                if (Properties.Settings.Default.AutoSave &&
                    !string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) &&
                    Directory.Exists(Properties.Settings.Default.DefaultPath))
                    SaveFileDialogMain_FileOk(sender, new CancelEventArgs());
                else
                    saveFileDialogMain.ShowDialog();
            }
        }

        private void ToolStripButtonFolder_Click(object sender, EventArgs e)
        {
            // Settings
            if (string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) ||
                !Directory.Exists(Properties.Settings.Default.DefaultPath))
            {
                Properties.Settings.Default.AutoSave = false;
                Properties.Settings.Default.DefaultPath = string.Empty;
                Properties.Settings.Default.Save();

                MessageBox.Show(Messages.PathNotFound, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                Process.Start(Path.Combine(Properties.Settings.Default.DefaultPath, Program.AlbumName));
        }

        private void ToolStripButtonGallery_Click(object sender, EventArgs e)
        {
            if (!this.Controls.OfType<Controls.Gallery>().Any())
            {
                var child = new Controls.Gallery
                {
                    Dock = DockStyle.Right,
                    BackColor = toolStripMenu.BackColor,
                    ForeColor = SystemColors.Control
                };
                Controls.Add(child);
                child.BringToFront();
            }
            else
            {
                var child = this.Controls.OfType<Controls.Gallery>().FirstOrDefault();
                if (child != null)
                    child.Close();
            }
        }

        private void ToolStripMenuItemCamera_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                VideSource.DisplayPropertyPage(this.Handle);
        }

        private void ToolStripMenuItemSystem_Click(object sender, EventArgs e)
        {
            var child = new FormSettings();
            child.ShowDialog();
            toolStripButtonGallery.Visible = Properties.Settings.Default.AutoSave;
            toolStripButtonFolder.Visible = Properties.Settings.Default.AutoSave;
            toolStripSeparator1.Visible = Properties.Settings.Default.AutoSave;
        }

        private void ToolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }

        private void ToolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion ToolStrip
    }
}