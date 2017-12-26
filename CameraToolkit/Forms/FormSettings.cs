using System;
using System.Drawing;
using System.Windows.Forms;

namespace Toolkit.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetEntryAssembly().Location);

            comboBoxDevices.DisplayMember = "Value";
            comboBoxDevices.ValueMember = "Key";
            comboBoxDevices.DataSource = new BindingSource(Program.GetDevices(), null);

            comboBoxDevices.DataBindings.Add("Enabled", checkBoxAutoStart, "Checked");
            textBoxAutoSavePath.DataBindings.Add("Enabled", checkBoxAutoSave, "Checked");
            buttonExamine.DataBindings.Add("Enabled", checkBoxAutoSave, "Checked");
            checkBoxAlbumName.DataBindings.Add("Enabled", checkBoxAutoSave, "Checked");
        }

        private void buttonExamine_Click(object sender, EventArgs e)
        {
            folderBrowserDialogAutoSavePath.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialogAutoSavePath.SelectedPath))
                textBoxAutoSavePath.Text = folderBrowserDialogAutoSavePath.SelectedPath;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (checkBoxAutoSave.Checked && !System.IO.Directory.Exists(textBoxAutoSavePath.Text))
            {
                var question = MessageBox.Show(Toolkit.Messages.PathNotFoundAndCreate, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.Directory.CreateDirectory(textBoxAutoSavePath.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Toolkit.Messages.PathInvalid, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Properties.Settings.Default.DefaultDevice = comboBoxDevices.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.DefaultDevice) && comboBoxDevices.Items.Count > 0)
                comboBoxDevices.SelectedValue = Properties.Settings.Default.DefaultDevice;
        }
    }
}