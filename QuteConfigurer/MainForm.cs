﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Qute
{
    public partial class MainForm : Form
    {
        private readonly QuteData _data;

        #region Initialize
        public MainForm() {
            _data = new QuteData();

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
                new QuteExporter.Build {
                    Name = "Debug Editor",
                    State = "DebugGame",
                    Mode = "Editor",
                    BuildFlags = "-rocket",
                    Platform = "Win64",
                    RunFlags = "-debug",
                    ExeSuffix = "",
                    RunFromEditor = true,
                },
                new QuteExporter.Build {
                    Name = "Debug Standalone",
                    State = "DebugGame",
                    Mode = "",
                    BuildFlags = "-rocket",
                    Platform = "Win64",
                    RunFlags = "",
                    ExeSuffix = "-Win64-DebugGame",
                    RunFromEditor = false,
                },
                new QuteExporter.Build {
                    Name = "Development Editor",
                    State = "Development",
                    Mode = "Editor",
                    BuildFlags = "-rocket",
                    Platform = "Win64",
                    RunFlags = "",
                    ExeSuffix = "",
                    RunFromEditor = true,
                },
                new QuteExporter.Build {
                    Name = "Development Standalone",
                    State = "Development",
                    Mode = "",
                    BuildFlags = "-rocket",
                    Platform = "Win64",
                    RunFlags = "",
                    ExeSuffix = "",
                    RunFromEditor = false,
                },
                new QuteExporter.Build {
                    Name = "Shipping",
                    State = "Shipping",
                    Mode = "",
                    BuildFlags = "-rocket",
                    Platform = "Win32",
                    RunFlags = "",
                    ExeSuffix = "-Win32-Shipping",
                    RunFromEditor = false
                }
            };

            //The items showing in the design view are just placeholders.
            listBuild.Items.Clear();
            listBuild.Items.AddRange(configurations);

            // Whether a configuration is checked is encoded in an unsigned long number.
            // Each bit, starting from right to left, represents whether a configuration is ticked or not.
            // 

            var checkedCodes = AppSettings.ConfigFlags;
            var flag = 1u;

            for (var i = 0; i < listBuild.Items.Count; ++i) {
                listBuild.SetItemChecked(i, (checkedCodes & flag) != 0);
                flag = flag << 1;
            }
        }

        bool _dontSaveSettings = false;

        private void MainForm_Load(object sender, EventArgs e) {
            Console.SetOut(new QuteConsoleWriter(txtLog, Color.LightGray));
            Console.SetError(new QuteConsoleWriter(txtLog, Color.Red));

            var kits = QuteResolver.GetKits();

            foreach (var kit in kits) {
                comboKits.Items.Add(kit);
                if (kit.Name.Trim().Equals(AppSettings.KitName.Trim(), StringComparison.InvariantCultureIgnoreCase)
                    && kit.Id.Trim().Equals(AppSettings.KitId.Trim(), StringComparison.InvariantCultureIgnoreCase)) {
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

            checkAlwaysUpdateVS.Checked = AppSettings.AlwaysUpdateVS;
        }

        #endregion


        private void btnQtFiles_Click(object sender, EventArgs e) {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                _data.ValidateEUPaths();

                if (checkAlwaysUpdateVS.Checked) {
                    UpdateVSFiles();
                }

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
            MessageBox.Show("In order for your configurations to compile and debug properly, a Qt Kit and Debugger must be set up. Refer to the Help menu for more information.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuildConfig_Click(object sender, EventArgs e) {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                _data.ValidateEUPaths();

                if (comboKits.SelectedItem is QuteResolver.Kit) {
                    QuteExporter.ExportConfiguration(_data, listBuild.CheckedItems.OfType<QuteExporter.Build>());
                } else {
                    Console.Error.WriteLine("Error: No Qt Kit is selected.");
                }
            } catch (QuteException ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void UpdateVSFiles() {
            _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);

            var gen = _data.GetGenerateCmd();
            if (!File.Exists(gen)) {
                throw new QuteException("Error: Could not find file '" + gen + "'.");
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
            Console.WriteLine("Visual Studio project files were generated.");
        }

        private void btnVSFiles_Click(object sender, EventArgs e) {
            try {
                UpdateVSFiles();
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {

            if (_dontSaveSettings) {
                return;
            }
            // Save all settings
            var kit = comboKits.SelectedItem is QuteResolver.Kit ? (QuteResolver.Kit)
                comboKits.SelectedItem : new QuteResolver.Kit();
            AppSettings.KitId = kit.Id;
            AppSettings.KitName = kit.Name;
            AppSettings.AlwaysUpdateVS = checkAlwaysUpdateVS.Checked;

            var flag = 1u;
            var code = 0xFFFFFFFF;

            for (var i = 0; i < listBuild.Items.Count; ++i) {
                //Remove 1 bit for each build configuration that is unchecked.
                if (listBuild.GetItemChecked(i) == false) {
                    code = (0xFFFFFFFF - flag) & code;
                }
                flag = flag << 1;
            }

            AppSettings.ConfigFlags = code;

            AppSettings.Save();
        }

        private void btnProjInfo_Click(object sender, EventArgs e) {
            try {
                var info = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                Console.WriteLine("Name: {0}\nEngine: {1}", info.Name, info.Engine);
            } catch (QuteException ex) {
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

        string BrowseQtCreatorPath() {
            var dialog = new OpenFileDialog { Filter = "qtcreator.exe" };
            var res = dialog.ShowDialog();

            return res == DialogResult.OK ? dialog.FileName : null;
        }

        private void btnOpenInQt_Click(object sender, EventArgs e) {
            OpenInQt();
        }

        private bool OpenInQt() {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
            } catch (QuteException ex) {
                Console.Error.WriteLine(ex.Message);
                return false;
            }

            var qtProjFile = Path.Combine(_data.GetProjectFilesDir(), _data.UEProject.Name + ".pro");
            if (!File.Exists(qtProjFile)) {
                Console.Error.WriteLine("Qt project files were not found. Did you generate them?");
                return false;
            }

            try {
                var filePath = AppSettings.QtPath ?? "";
                var fileName = Path.GetFileName(filePath);

                if (!File.Exists(filePath) || !fileName.Equals("qtcreator.exe", StringComparison.InvariantCultureIgnoreCase)) {
                    filePath = QuteResolver.GetDetectedQtCreatorPath();
                }
                if (!File.Exists(filePath) || !fileName.Equals("qtcreator.exe", StringComparison.InvariantCultureIgnoreCase)) {
                    filePath = BrowseQtCreatorPath();
                    if (filePath == null) {
                        return false;
                    }
                }

                if (File.Exists(filePath)) {
                    AppSettings.QtPath = filePath;
                    var startInfo = new ProcessStartInfo {
                        FileName = filePath,
                        Arguments = Path.Combine(_data.GetProjectFilesDir(), _data.UEProject.Name + ".pro")
                    };

                    var process = new Process {
                        StartInfo = startInfo,
                    };

                    process.Start();
                    return true;
                }
            } catch (Exception ex) {
                Console.Error.WriteLine(ex.Message);
            }
            return false;
        }

        private void MainForm_Shown(object sender, EventArgs e) {
            if (AppSettings.FirstTime) {
                if (!ShowSettings()) {
                    _dontSaveSettings = true;
                    Application.Exit();
                }
                menuPrepareQt_Click(null, null);
            }

            _data.UEPath = AppSettings.UEPath;
        }

        bool ShowSettings() {
            var settings = new SettingsForm();
            var result = settings.ShowDialog();
            if (result == DialogResult.OK) {
                AppSettings.QtPath = settings.QtCreatorPath;
                _data.UEPath = AppSettings.UEPath = settings.UEPath;
                AppSettings.Save();
                return true;
            }
            return false;
        }

        private void menuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void menuSettings_Click(object sender, EventArgs e) {
            ShowSettings();
        }

        private void menuAbout_Click(object sender, EventArgs e) {
            new AboutForm().ShowDialog();
        }

        private void menuHelpUse_Click(object sender, EventArgs e) {
            var help = new HelpForm { Text = "Help" };
            help.SetData("Help");
            help.ShowDialog();
        }

        private void menuSetup_Click(object sender, EventArgs e) {
            SetupAndLaunch();
        }

        private void SetupAndLaunch() {
            try {
                _data.UEProject = QuteResolver.GetProjectInfo(txtProjectPath.Text);
                _data.ValidateEUPaths();
                if (!(comboKits.SelectedItem is QuteResolver.Kit)) {
                    Console.Error.WriteLine("Error: No Qt Kit is selected.");
                }

                UpdateVSFiles();
                QuteExporter.ExportConfiguration(_data, listBuild.CheckedItems.OfType<QuteExporter.Build>());
                QuteExporter.ExportProject(_data);

                if (OpenInQt()) {
                    Application.Exit();
                }

            } catch (QuteException ex) {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private void menuPrepareQt_Click(object sender, EventArgs e) {
            var help = new HelpForm { Text = menuPrepareQt.Text };
            help.SetData("Page0", "Page1", "Page2", "Page3", "Page4", "Page5", "Page6", "Page7");
            help.ShowDialog();
        }

        private void btnSetup_Click(object sender, EventArgs e) {
            SetupAndLaunch();
        }
    }
}
