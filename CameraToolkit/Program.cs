using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;
using System.Windows.Forms;

namespace Toolkit
{
    static class Program
    {

        internal static FilterInfoCollection devices;
        internal static List<string> activeDevices;
        internal static string sessionId;

        internal static string albumName;

        internal static List<string> imageFiles = new List<string>(new string[] { ".bmp", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });

        [STAThread]
        static void Main()
        {

#if DEBUG
            ImageHelper.GetEditorIcon(MaterialDesign.GetImage(MaterialDesign.IconType.linked_camera, 256, Color.White));
#endif

            sessionId = DateTime.Now.TimeOfDay.Ticks.ToString();
            activeDevices = new List<string>();
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }

        internal static Dictionary<string, string> getDevices()
        {
            var result = new Dictionary<string, string>();

            if (devices.Count > 0)
                for (int i = 0; i < devices.Count; i++)
                    result.Add(devices[i].MonikerString, devices[i].Name.ToString());

            return result;
        }

        internal static DialogResult ShowInputDialog(ref string input, string caption)
        {
            var size = new Size(200, 70);

            var inputBox = new Form();
            inputBox.Padding = new Padding(6);
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ShowIcon = false;
            inputBox.ShowInTaskbar = false;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.ClientSize = size;
            inputBox.Text = caption;
            inputBox.StartPosition = FormStartPosition.CenterParent;

            var textBox = new TextBox();
            textBox.Dock = DockStyle.Top;
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            var okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = Messages.OK;
            okButton.Location = new Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = Messages.Cancel;
            cancelButton.Location = new Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            var result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }

    }

}
