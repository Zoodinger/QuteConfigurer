using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Qute
{
    public partial class SettingsForm : Form
    {
        public SettingsForm() {
            InitializeComponent();
            if (AppSettings.FirstTime) {
                txtUEPath.Text = QuteResolver.GetDetectedUEPath();
                txtQtPath.Text = QuteResolver.GetDetectedQtCreatorPath();
            } else {
                txtUEPath.Text = AppSettings.UEPath; 
                txtQtPath.Text = AppSettings.QtPath;
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
                    if (txtQtPath.Text != dialog.FileName) {
                        Console.WriteLine("Qt Creator location changed to '{0}'.", dialog.FileName);
                        txtQtPath.Text = dialog.FileName;
                    }
                }
            }
        }

        private void btnDetectUEPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedUEPath();
            if (path != null && Directory.Exists(path)) {
                if (txtUEPath.Text != path) {
                    txtUEPath.Text = path;
                    Console.WriteLine("Unreal Engine path changed to '{0}'.", path);
                }
            } else {
                Console.Error.WriteLine("Error: Could not auto-detect Unreal Engine installation path.");
            }
        }

        private void btnDetectQtPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedQtCreatorPath();
            if (path != null && File.Exists(path)) {
                if (path != txtQtPath.Text) {
                    txtQtPath.Text = path;
                    Console.WriteLine("Qt Creator location changed to '{0}'.", path);
                }
            } else {
                Console.Error.WriteLine("Error: Could not auto-detect Qt Creator location.");
            }
        }

        private void btnBrowseUEPath_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                if (txtUEPath.Text != dialog.SelectedPath) {
                    txtUEPath.Text = dialog.SelectedPath;
                    Console.WriteLine("Unreal Engine path changed to '{0}'.", dialog.SelectedPath);
                }
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
