using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QtConfigurator.Properties;

namespace QtConfigurator
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Console.SetOut(new ConsoleRedirector(txtLog));

            //Set up the input fields to have already stored settings.

            txtQtPath.Text = Settings.Default.QtPath;
            txtUEPath.Text = Settings.Default.UEPath;

            var kits = QuteResolver.GetKits();

            foreach (var kit in kits) {
                comboKits.Items.Add(kit);
                if (kit.Name == Settings.Default.KitName
                    && kit.Id == Settings.Default.KitId) {
                        comboKits.SelectedItem = kit;
                }
            }
        }

        private void txtQtPath_TextChanged(object sender, System.EventArgs e) {
            if (!Directory.Exists(txtQtPath.Text)) {
                txtQtPath.ForeColor = SystemColors.GrayText;
            } else {
                txtQtPath.ForeColor = SystemColors.WindowText;
            }
        }

        private void browseQt_Click(object sender, System.EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtQtPath.Text = dialog.SelectedPath;
                Console.WriteLine("Qt path changed to '{0}'.", dialog.SelectedPath);
            }
        }

        private void btnDetectQt_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedQtPath();
            if (path != "" && Directory.Exists(path)) {
                txtQtPath.Text = path;
                Console.WriteLine("Qt path changed to '{0}'.", path);
            } else {
                Console.WriteLine("Could not auto-detect Qt installation path.");
            }
        }


        private class ConsoleRedirector : TextWriter
        {
            private readonly TextBox _textBox;

            public ConsoleRedirector(TextBox textbox) {
                _textBox = textbox;
            }

            public override void Write(char value) {
                base.Write(value);
                _textBox.AppendText(value.ToString(CultureInfo.InvariantCulture));
            }

            public override Encoding Encoding {
                get { return Encoding.UTF8; }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (var kit in QuteResolver.GetKits()) {
                Console.WriteLine("{0}, {1}", kit.Name, kit.Id);
            }
        }

        private void btnBrowseProject_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog {Filter = "Unreal Project File (*.uproject)|*.uproject|All types (*.*)|*.*"};
            var res = dialog.ShowDialog();

            if (res == DialogResult.OK) {
                txtProjectPath.Text = dialog.FileName;
                Console.WriteLine("Selected project.");
            }
        }

        private void btnDetectUEPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedUEPath();
            if (path != "" && Directory.Exists(path)) {
                txtUEPath.Text = path;
                Console.WriteLine("Unreal Engine path changed to '{0}'.", path);
            } else {
                Console.WriteLine("Could not auto-detect Unreal Engine installation path.");
            }
        }

        private void lblPath_Click(object sender, EventArgs e) {

        }

        private void btnBrowseUEPath_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtUEPath.Text = dialog.SelectedPath;
                Console.WriteLine("Unreal Engine path changed to '{0}'.", dialog.SelectedPath);
            }
        }

        private void txtUEPath_TextChanged(object sender, EventArgs e) {
            if (!Directory.Exists(txtUEPath.Text)) {
                txtUEPath.ForeColor = SystemColors.GrayText;
            } else {
                txtUEPath.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtProjectPath_TextChanged(object sender, EventArgs e) {

        }

    }
}
