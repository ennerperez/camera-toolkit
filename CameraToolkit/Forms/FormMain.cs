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
using System.Windows.Forms;
using System.Windows.Forms.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            // saveFileDialogMain
            saveFileDialogMain.DefaultExt = Program.imageFiles[0];

            // Icons
            toolStripButtonDevices.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.linked_camera, 48, Color.White);
            toolStripButtonCapture.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.camera, 48, Color.White);
            toolStripButtonSave.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.save, 48, Color.White);

            toolStripMenuItemCamera.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings_brightness, 48, toolStripMenu.BackColor);
            toolStripMenuItemSystem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings_system_daydream, 48, toolStripMenu.BackColor);

            toolStripButtonGallery.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.image, 48, Color.White);
            toolStripButtonFolder.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.folder_open, 48, Color.White);

            toolStripButtonSettings.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.settings, 48, Color.White);
            toolStripButtonAbout.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.info, 48, Color.White);
            toolStripButtonClose.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.close, 48, Color.White);

            toolStripMenuDisconnectItem.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.videocam_off, 48, toolStripMenu.BackColor);

            toolStripMenuItemCopy.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.content_copy, 16, toolStripMenu.BackColor);

#if DEBUG
            FormHelper.ExtractResources(toolStripMenu);
#endif

        }


        private bool IsRunning()
        {
            return VideSource != null && VideSource.IsRunning;
        }

        private void item_Click(object sender, EventArgs e)
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
                VideSource.NewFrame += new NewFrameEventHandler(captureFrame);
                VideSource.Start();

                toolStripMenuDisconnectItem.Enabled = IsRunning();

                if (Properties.Settings.Default.AskAlbumName)
                    Program.ShowInputDialog(ref Program.albumName, Messages.AlbumName);

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

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelCamera.BackgroundImage != null)
                Clipboard.SetImage(panelCamera.BackgroundImage);
        }

        private void contextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemCopy.Enabled = panelCamera.BackgroundImage != null;
        }

        #endregion

        private bool paused;
        private void captureFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!paused)
            {
                var Imagen = (Bitmap)eventArgs.Frame.Clone();
                panelCamera.BackgroundImage = Imagen;
            }
        }

        private void FormViewer_Shown(object sender, EventArgs e)
        {
            ToolStripMenuItem defaultDevice = null;
            foreach (var item in Program.getDevices())
            {
                var _item = new ToolStripMenuItem(item.Value);
                _item.Tag = item.Key;
                _item.Click += item_Click;
                _item.SetImage(MaterialDesign.Instance, MaterialDesign.IconType.videocam, 48, toolStripMenu.BackColor);
                toolStripButtonDevices.DropDownItems.Add(_item);

                if (Properties.Settings.Default.AutoStart && item.Key == Properties.Settings.Default.DefaultDevice)
                    defaultDevice = _item;

            }

            if (defaultDevice != null)
                defaultDevice.PerformClick();


        }
        private void FormViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            toolStripMenuDisconnectItem.PerformClick();
        }

        private void saveFileDialogMain_FileOk(object sender, CancelEventArgs e)
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

        private void toolStripButtonCapture_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                paused = !paused;
            toolStripButtonCapture.Checked = paused;
        }
        private void toolStripMenuItemDisconnect_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {
                VideSource.SignalToStop();
                VideSource.NewFrame -= new NewFrameEventHandler(captureFrame);
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

            Program.albumName = string.Empty;

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {

                var i = 1;
                string filename = string.Empty;

                while (filename == string.Empty || File.Exists(filename))
                {
                    filename = string.Format("{0}_{1}_{2}_{3}.jpg", DeviceName.Replace(' ', '_'), Program.sessionId, DateTime.Now.ToString("yyyyMMdd"), i.ToString());
                    if (Properties.Settings.Default.AutoSave &&
                        !string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) &&
                        Directory.Exists(Properties.Settings.Default.DefaultPath))

                        filename = Path.Combine(Properties.Settings.Default.DefaultPath, Program.albumName, filename);

                    i++;
                }

                saveFileDialogMain.FileName = filename;

                if (Properties.Settings.Default.AutoSave &&
                    !string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) &&
                    Directory.Exists(Properties.Settings.Default.DefaultPath))
                    saveFileDialogMain_FileOk(sender, new CancelEventArgs());
                else
                    saveFileDialogMain.ShowDialog();

            }
        }

        private void toolStripButtonFolder_Click(object sender, EventArgs e)
        {
            // Settings
            if (string.IsNullOrEmpty(Properties.Settings.Default.DefaultPath) ||
                !Directory.Exists(Properties.Settings.Default.DefaultPath))
            {
                Properties.Settings.Default.AutoSave = false;
                Properties.Settings.Default.DefaultPath = string.Empty;
                Properties.Settings.Default.Save();

                MessageBox.Show(Toolkit.Messages.PathNotFound, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                System.Diagnostics.Process.Start(Properties.Settings.Default.DefaultPath);

        }
        private void toolStripButtonGallery_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemCamera_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                VideSource.DisplayPropertyPage(this.Handle);
        }
        private void toolStripMenuItemSystem_Click(object sender, EventArgs e)
        {
            var child = new FormSettings();
            child.ShowDialog();
        }
        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }
        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}


