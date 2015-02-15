using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() {
            InitializeComponent();
            if (Settings.Default.FirstRun) {
                txtUEPath.Text = QuteResolver.GetDetectedUEPath();
                txtQtPath.Text = QuteResolver.GetDetectedQtCreatorPath();
            } else {
                txtUEPath.Text = Settings.Default.UEPath;
                txtQtPath.Text = Settings.Default.QtCreatorPath;
            }
            UEPath = txtUEPath.Text;
            QtCreatorPath = txtQtPath.Text;
        }

        public string QtCreatorPath { get; private set; }

        public string UEPath { get; private set; }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnBrowseQtPath_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog { Filter = "Qt Creator|qtcreator.exe", CheckFileExists = true };
            if (dialog.ShowDialog() == DialogResult.OK) {
                if (File.Exists(dialog.FileName)) {
                    txtQtPath.Text = dialog.FileName;
                }
            }
        }

        private void btnDetectUEPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedUEPath();
            if (path != null && Directory.Exists(path)) {
                txtUEPath.Text = path;
            } else {
                MessageBox.Show("Could not auto-detect Unreal Engine path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetectQtPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedQtCreatorPath();
            if (path != null && File.Exists(path)) {
                txtQtPath.Text = path;
            } else {
                MessageBox.Show("Could not auto-detect Qt Creator path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseUEPath_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtUEPath.Text = dialog.SelectedPath;
                Console.WriteLine("Unreal Engine path changed to '{0}'.", dialog.SelectedPath);
            }
        }

        private void txtUEPath_TextChanged(object sender, EventArgs e) {
            UEPath = txtUEPath.Text;
            if (!Directory.Exists(txtUEPath.Text)) {
                txtUEPath.ForeColor = Color.Red;
            } else {
                txtUEPath.ForeColor = Color.Black;
            }
        }

        private void txtQtPath_TextChanged(object sender, EventArgs e) {
            UEPath = txtQtPath.Text;
            if (!File.Exists(txtQtPath.Text)) {
                txtQtPath.ForeColor = Color.Red;
            } else {
                txtQtPath.ForeColor = Color.Black;
            }
        }
    }
}
