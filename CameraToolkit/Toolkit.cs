using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Pictograms;
using System.Windows.Forms;

namespace Toolkit
{
    internal static partial class Program
    {
        internal static MaterialDesign.IconType Icon => MaterialDesign.IconType.linked_camera;
        internal static string SessionId => DateTime.Now.TimeOfDay.Ticks.ToString();
        internal static FilterInfoCollection Devices => new FilterInfoCollection(FilterCategory.VideoInputDevice);

        internal static List<string> Formats => new List<string>(new[] { ".bmp", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif" });

        internal static string AlbumName = string.Empty;

        internal static void Initialize()
        {
#if DEBUG
            ImageHelper.GetEditorIcon(MaterialDesign.GetImage(Program.Icon, 256, Color.White));
#endif
        }

        internal static Dictionary<string, string> GetDevices()
        {
            var result = new Dictionary<string, string>();

            if (Devices.Count > 0)
                for (int i = 0; i < Devices.Count; i++)
                    result.Add(Devices[i].MonikerString, Devices[i].Name.ToString());

            return result;
        }

        internal static DialogResult ShowInputDialog(ref string input, string caption)
        {
            var size = new Size(200, 70);

            var inputBox = new Form
            {
                Padding = new Padding(6),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowIcon = false,
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = size,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };

            var textBox = new TextBox
            {
                Dock = DockStyle.Top,
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            var okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = Messages.OK,
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = Messages.Cancel,
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            var result = inputBox.ShowDialog();
            input = textBox.Text;

            return result;
        }
    }
}