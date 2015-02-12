using System;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    static class Program
    {
        /// <summary>
        /// Initializes default settings if they don't exist.
        /// </summary>
        static void InitSettings() {

            //Attempts to get the current user's name.
            if (Settings.Default.Username.Trim() == string.Empty) {
                Settings.Default.Username = Environment.UserName;
            }

            //Attempts to get Qt's install directory from the registry if the current setting is not a folder.
            if (!Directory.Exists(Settings.Default.QtPath.Trim())) {
                var value = QuteResolver.GetDetectedQtPath();
                if (!Directory.Exists(value)) {
                    value = "";
                }
                Settings.Default.QtPath = value;
            }

            if (!Directory.Exists(Settings.Default.UEPath.Trim())) {
                var value = QuteResolver.GetDetectedUEPath();
                if (!Directory.Exists(value)) {
                    value = "";
                }
                Settings.Default.UEPath = value;
            }

            Settings.Default.Save();
        }

        internal static string GetVersion() {
            return ApplicationDeployment.IsNetworkDeployed
                   ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                   : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            InitSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
