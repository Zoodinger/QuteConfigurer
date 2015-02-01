using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    public partial class MainForm : Form
    {
        public MainForm() {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => {
                var resourceName = new AssemblyName(args.Name).Name + ".dll";
                var resource = Array.Find(GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)) {
                    if (stream != null) {
                        var assemblyData = new Byte[stream.Length];
                        stream.Read(assemblyData, 0, assemblyData.Length);
                        return Assembly.Load(assemblyData);
                    }
                }

                return null;
            };


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

        private void txtQtPath_TextChanged(object sender, EventArgs e) {
            if (!Directory.Exists(txtQtPath.Text)) {
                txtQtPath.ForeColor = Color.Red;
            } else {
                txtQtPath.ForeColor = Color.Black;
            }
        }

        private void browseQt_Click(object sender, EventArgs e) {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                txtQtPath.Text = dialog.SelectedPath;
                Console.WriteLine("Qt path changed to '{0}'.", dialog.SelectedPath);
            }
        }

        private void btnDetectQt_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedQtPath();
            if (path != null && Directory.Exists(path)) {
                txtQtPath.Text = path;
                Console.WriteLine("Qt path changed to '{0}'.", path);
            } else {
                Console.WriteLine("Could not auto-detect Qt installation path.");
            }
        }


        private class ConsoleRedirector : TextWriter
        {
            private readonly RichTextBox _textBox;

            public ConsoleRedirector(RichTextBox textbox) {
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

        private void btnQtFiles_Click(object sender, EventArgs e) {
            QuteResolver.UEProject project = QuteResolver.GetProjectInfo(txtProjectPath.Text);

            if (string.IsNullOrWhiteSpace(project.Name) || string.IsNullOrWhiteSpace(project.Engine)) {
                Console.WriteLine("Error: Failed to read data from project file.");
                return;
            }

            var path = Path.GetDirectoryName(txtProjectPath.Text) ?? "";
            path = Path.Combine(path, @"Intermediate\ProjectFiles\MyQtProject.vcxproj");
            if (!File.Exists(path)) {
                Console.WriteLine("Error: Could not detect Visual Studio project files.");
            }


        }

        private void btnBrowseProject_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog { Filter = "Unreal Project File (*.uproject)|*.uproject|All types (*.*)|*.*" };
            var res = dialog.ShowDialog();

            if (res == DialogResult.OK) {
                txtProjectPath.Text = dialog.FileName;
                Console.WriteLine("Selected project.");
            }
        }

        private void btnDetectUEPath_Click(object sender, EventArgs e) {
            var path = QuteResolver.GetDetectedUEPath();
            if (path != null && Directory.Exists(path)) {
                txtUEPath.Text = path;
                Console.WriteLine("Unreal Engine path changed to '{0}'.", path);
            } else {
                Console.WriteLine("Could not auto-detect Unreal Engine installation path.");
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
            if (!Directory.Exists(txtUEPath.Text)) {
                txtUEPath.ForeColor = Color.Red;
            } else {
                txtUEPath.ForeColor = Color.Black;
            }
        }

        private void txtProjectPath_TextChanged(object sender, EventArgs e) {
            if (!File.Exists(txtProjectPath.Text)) {
                txtProjectPath.ForeColor = Color.Red;
            } else {
                txtProjectPath.ForeColor = Color.Black;
            }
        }

        private void btnKitReadMe_Click(object sender, EventArgs e) {
            Console.WriteLine("Operation not yet supported.");
        }

        private void btnBuildConfig_Click(object sender, EventArgs e) {
            Console.WriteLine("Operation not yet supported.");
        }

        private void btnGenVSFiles_Click(object sender, EventArgs e) {
            Console.WriteLine("Operation not yet supported.");
        }

        private void btnHelpVS_Click(object sender, EventArgs e) {
            Console.WriteLine("Help: Generate project files for Visual Studio. "
              + "You should perform this operation when VS Project files become out of sync,"
              + " or right before you generate Qt project files.");
        }

        private void btnHelpBuildConfig_Click(object sender, EventArgs e) {
            Console.WriteLine("Help: Generate build configuration every time you change the engine. "
             + "An appropriate Qt Kit must be selected!");
        }

        private void btnHelpQt_Click(object sender, EventArgs e) {
            Console.WriteLine("Help: Generate Qt project files. "
              + "Visual Studio project files must be up-to-date before performing this operation. "
              + "Do this whenever you add code to your project outside of Qt Creator, or after upgrading the engine.");

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            // Save all settings
            Settings.Default.QtPath = txtQtPath.Text;
            var kit = comboKits.SelectedItem is QuteResolver.Kit ? (QuteResolver.Kit)
                comboKits.SelectedItem : new QuteResolver.Kit();
            Settings.Default.KitId = kit.Id;
            Settings.Default.KitName = kit.Name;
            Settings.Default.UEPath = txtUEPath.Text;
            Settings.Default.Save();
        }

    }
}
