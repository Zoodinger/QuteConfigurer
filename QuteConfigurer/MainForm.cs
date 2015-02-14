using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    public partial class MainForm : Form
    {
        private readonly ProjectData _data;

        #region Initialize
        public MainForm() {

            _data = new ProjectData();

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

            InitializeConfigurations();
        }

        private void InitializeConfigurations() {
            var configurations = new object[] 
            {
                new Configuration.Build {
                    Name = "Debug Editor",
                    State = Configuration.State.Debug,
                    Mode = Configuration.Mode.Editor,
                    BuildFlags = Configuration.Flag.Rocket,
                    Platform = Configuration.Target.Win64,
                    RunFlags = Configuration.Flag.Debug,
                    ExeSuffix = "",
                    RunFromEditor = true,
                },
                new Configuration.Build {
                    Name = "Debug Standalone",
                    State = Configuration.State.Debug,
                    Mode = Configuration.Mode.Normal,
                    BuildFlags = Configuration.Flag.Rocket,
                    Platform = Configuration.Target.Win64,
                    RunFlags = Configuration.Flag.None,
                    ExeSuffix = Configuration.Target.Win64 + "-" + Configuration.State.Debug,
                    RunFromEditor = false,
                },
                new Configuration.Build {
                    Name = "Development Editor",
                    State = Configuration.State.Development,
                    Mode = Configuration.Mode.Editor,
                    BuildFlags = Configuration.Flag.Rocket,
                    Platform = Configuration.Target.Win64,
                    RunFlags = Configuration.Flag.None,
                    ExeSuffix = "",
                    RunFromEditor = true,
                },
                new Configuration.Build {
                    Name = "Development Standalone",
                    State = Configuration.State.Development,
                    Mode = Configuration.Mode.Normal,
                    BuildFlags = Configuration.Flag.Rocket,
                    Platform = Configuration.Target.Win64,
                    RunFlags = Configuration.Flag.None,
                    ExeSuffix = "",
                    RunFromEditor = false,
                }
            };

            //The items showing in the design view are just placeholders.
            listBuild.Items.Clear();
            listBuild.Items.AddRange(configurations);

            // Whether a configuration is checked is encoded in an unsigned long number.
            // Each bit, starting from right to left, represents whether a configuration is ticked or not.
            // 

            var checkedCodes = Settings.Default.ConfigFlags;
            var flag = 1u;

            for (var i = 0; i < listBuild.Items.Count; ++i) {
                listBuild.SetItemChecked(i, (checkedCodes & flag) != 0);
                flag = flag << 1;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            Console.SetOut(new QuteConsoleWriter(txtLog, Color.LightGray));
            Console.SetError(new QuteConsoleWriter(txtLog, Color.Red));

            //Set up the input fields to have already stored settings.
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

            checkAlwaysUpdateVS.Checked = Settings.Default.AlwaysUpdateVS;
        }

        #endregion


        private void btnQtFiles_Click(object sender, EventArgs e) {
            try {
                if (checkAlwaysUpdateVS.Checked) {
                    UpdateVSFiles();
                }
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                QuteExporter.ExportProject(_data);
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
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
            _data.UEPath = txtUEPath.Text;
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
            Console.Error.WriteLine("Operation is not supported yet.");
        }

        private void btnBuildConfig_Click(object sender, EventArgs e) {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);

                if (comboKits.SelectedItem is QuteResolver.Kit) {
                    QuteExporter.ExportConfiguration(_data, listBuild.CheckedItems.OfType<Configuration.Build>());
                }
            } catch (QuteResolver.ProjectException ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void UpdateVSFiles() {
            _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);

            var gen = _data.GetGenerateCmd();
            if (!File.Exists(gen)) {
                throw new QuteResolver.ProjectException("Error: Could not find file " + gen);
            }

            var startInfo = new ProcessStartInfo {
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = _data.GetGenerateCmd(),
                Arguments = _data.UEProject.Path
            };

            var process = new Process {
                StartInfo = startInfo
            };

            process.Start();
            process.WaitForExit();

            Console.WriteLine("Visual Studio project files were upgraded.");
        }

        private void btnGenVSFiles_Click(object sender, EventArgs e) {
            try {
                UpdateVSFiles();
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
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
            var kit = comboKits.SelectedItem is QuteResolver.Kit ? (QuteResolver.Kit)
                comboKits.SelectedItem : new QuteResolver.Kit();
            Settings.Default.KitId = kit.Id;
            Settings.Default.KitName = kit.Name;
            Settings.Default.UEPath = txtUEPath.Text;
            Settings.Default.AlwaysUpdateVS = checkAlwaysUpdateVS.Checked;

            var flag = 1u;
            var code = 0xFFFFFFFF;

            for (var i = 0; i < listBuild.Items.Count; ++i) {
                //Remove 1 bit for each build configuration that is unchecked.
                if (listBuild.GetItemChecked(i) == false) {
                    code = (0xFFFFFFFF - flag) & code;
                }
                flag = flag << 1;
            }

            Settings.Default.ConfigFlags = code;

            Settings.Default.Save();
        }

        private void btnProjInfo_Click(object sender, EventArgs e) {
            try {
                var info = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                Console.WriteLine("Name: {0}\nEngine: {1}", info.Name, info.Engine);
            } catch (QuteResolver.ProjectException ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void listBuild_SelectedIndexChanged(object sender, EventArgs e) {
            listBuild.SelectedIndex = -1;
        }

        private void comboKits_SelectedIndexChanged(object sender, EventArgs e) {
            _data.Kit = (QuteResolver.Kit)comboKits.SelectedItem;
        }

        private void txtProjectPath_Leave(object sender, EventArgs e) {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
            } catch {
                // Suppress errors
            }
        }

        private void checkAlwaysUpdateVS_CheckedChanged(object sender, EventArgs e) {
            btnVSFiles.Enabled = !checkAlwaysUpdateVS.Checked;
        }

        private void btnOpenInQt_Click(object sender, EventArgs e) {
            Console.Error.WriteLine("Operation is not supported yet.");
        }

    }
}
