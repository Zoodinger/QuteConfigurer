using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    public partial class MainForm : Form
    {

        public MainForm() {

            //Json dll is embedded as a resource. This code will make sure it's loaded.
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
            Console.SetOut(new QuteConsoleWriter(txtLog, Color.LightGray));
            Console.SetError(new QuteConsoleWriter(txtLog, Color.Red));

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

            //If the program is run in a project directory, set active project to the first *.uproject file found.
            var dir = Directory.GetCurrentDirectory();
            if (Directory.Exists(dir)) {
                foreach (var file in Directory.GetFiles(dir, "*.uproject")) {
                    txtProjectPath.Text = file;
                    txtProjectPath_TextChanged(null, null);
                    break;
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



        private void btnQtFiles_Click(object sender, EventArgs e) {
            var project = QuteResolver.GetProjectInfo(txtProjectPath.Text);
            if (project.ErrorStatus != null) {
                Console.Error.WriteLine(project.ErrorStatus);
            } else {
                QuteExporter.ExportProject(project);
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
                btnProjInfo.Enabled = false;
            } else {
                txtProjectPath.ForeColor = Color.Black;
                btnProjInfo.Enabled = true;
            }
        }

        private void btnKitReadMe_Click(object sender, EventArgs e) {
            Console.Error.WriteLine("Operation not yet supported.");
        }

        private void btnBuildConfig_Click(object sender, EventArgs e) {
            QuteResolver.UEProject project = QuteResolver.GetProjectInfo(txtProjectPath.Text);
            if (comboKits.SelectedItem is QuteResolver.Kit) {
                var kit = (QuteResolver.Kit)comboKits.SelectedItem;
                QuteExporter.ExportConfiguration(project, kit);
            }
        }

        private void btnGenVSFiles_Click(object sender, EventArgs e) {
            Console.Error.WriteLine("Operation not yet supported.");
        }

        private void btnHelpVS_Click(object sender, EventArgs e) {
            MessageBox.Show("Generate project files for Visual Studio. "
              + "You should perform this operation when VS Project files become out of sync,"
              + " or right before you generate Qt project files.",
              "Help on '" + btnVSFiles.Text + "'", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelpBuildConfig_Click(object sender, EventArgs e) {
            MessageBox.Show("Generate build configuration every time you change the engine. "
             + "An appropriate Qt Kit must be selected!",
             "Help on '" + btnBuildConfig.Text + "'", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelpQt_Click(object sender, EventArgs e) {
            MessageBox.Show("Generate Qt project files. "
              + "Visual Studio project files must be up-to-date before performing this operation. "
              + "Do this whenever you add code to your project outside of Qt Creator, or after upgrading the engine.",
            "Help on '" + btnQtFiles.Text + "'", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnProjInfo_Click(object sender, EventArgs e) {
            var info = QuteResolver.GetProjectInfo(txtProjectPath.Text);
            if (info.ErrorStatus == null) {
                Console.WriteLine("Name: {0}\nEngine: {1}", info.Name, info.Engine);
            } else {
                Console.Error.WriteLine(info.ErrorStatus);
            }
        }

    }
}
