using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Qute.Properties;

namespace Qute
{
    static class Program
    {
        /// <summary>
        /// Initializes default settings if they don't exist.
        /// </summary>
        static void InitSettings() {
       //     Settings.Default.UEPath = "";
         //   Settings.Default.QtPath = "";

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

            Console.WriteLine(Settings.Default.Username);
            Console.WriteLine(Settings.Default.QtPath);

            Settings.Default.Save();
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
