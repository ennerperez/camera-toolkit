using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Pictograms;

namespace Toolkit.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // saveFileDialogImage
            saveFileDialogImage.DefaultExt = Program.imageFiles[0];
            saveFileDialogImage.Filter = string.Format(saveFileDialogImage.Filter,
                string.Join(", *", Program.imageFiles.ToArray()),
                string.Join("; *", Program.imageFiles.ToArray()));


            // Icons
            toolStripButtonDevices.Image = MaterialDesign.GetImage(MaterialDesign.IconType.linked_camera, 48, Color.White);

            toolStripButtonCapture.Image = MaterialDesign.GetImage(MaterialDesign.IconType.camera, 48, Color.White);
            toolStripButtonSave.Image = MaterialDesign.GetImage(MaterialDesign.IconType.save, 48, Color.White);
            toolStripButtonSettings.Image = MaterialDesign.GetImage(MaterialDesign.IconType.settings, 48, Color.White);

            toolStripButtonAbout.Image = MaterialDesign.GetImage(MaterialDesign.IconType.info, 48, Color.White);
            toolStripButtonClose.Image = MaterialDesign.GetImage(MaterialDesign.IconType.close, 48, Color.White);

            disconnectToolStripMenuItem.Image = MaterialDesign.GetImage(MaterialDesign.IconType.videocam_off, 48, toolStripMenu.BackColor);

            copyToolStripMenuItem.Image = MaterialDesign.GetImage(MaterialDesign.IconType.content_copy, 16, toolStripMenu.BackColor);

        }

        private bool IsRunning()
        {
            return VideSource != null && VideSource.IsRunning;
        }

        private void _item_Click(object sender, EventArgs e)
        {

            disconnectToolStripMenuItem.PerformClick();

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

                disconnectToolStripMenuItem.Enabled = IsRunning();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public string DeviceName { get; set; }
        public string Moniker { get; set; }
        public VideoCaptureDevice VideSource { get; set; }

        #region Clipboard
        
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image!= null)
                Clipboard.SetImage(pictureBoxCamera.Image);
        }

        private void contextMenuStripImage_Opening(object sender, CancelEventArgs e)
        {
            copyToolStripMenuItem.Enabled = pictureBoxCamera.Image != null;
        }

        #endregion

        private void FormViewer_Shown(object sender, EventArgs e)
        {
            foreach (var item in Program.getDevices())
            {
                var _item = new ToolStripMenuItem(item.Value);
                _item.Tag = item.Key;
                _item.Click += _item_Click;
                _item.Image = MaterialDesign.GetImage(MaterialDesign.IconType.videocam, 48, toolStripMenu.BackColor);
                toolStripButtonDevices.DropDownItems.Add(_item);
            }
        }

        public void captureFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!paused)
            {
                Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
                pictureBoxCamera.Image = Imagen;
            }
        }

        private void FormViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnectToolStripMenuItem.PerformClick();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool paused;

        private void toolStripButtonCapture_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                paused = !paused;
            toolStripButtonCapture.Checked = paused;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {
                saveFileDialogImage.FileName = string.Format("{0}_{1}.jpg", DeviceName.Replace(' ', '_'), DateTime.Now.ToString("yyyyMMdd"));
                saveFileDialogImage.ShowDialog();
            }
        }

        private void saveFileDialogImage_FileOk(object sender, CancelEventArgs e)
        {
            if (IsRunning())
            {
                try
                {
                    pictureBoxCamera.Image.Save(saveFileDialogImage.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            if (IsRunning())
                VideSource.DisplayPropertyPage(this.Handle);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsRunning())
            {
                VideSource.SignalToStop();
                VideSource.NewFrame -= new NewFrameEventHandler(captureFrame);
                VideSource = null;
                pictureBoxCamera.Image = null;
            }

            var items = from item in toolStripButtonDevices.DropDownItems.OfType<ToolStripMenuItem>()
                        select item;

            foreach (var item in items)
                item.Enabled = true;

            paused = false;
            toolStripButtonCapture.Checked = paused;

            disconnectToolStripMenuItem.Enabled = IsRunning();

        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            var child = new FormAbout();
            child.ShowDialog();
        }
    }
}


