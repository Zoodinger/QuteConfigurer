using System;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Qute
{
    static class Program
    {
        internal static string GetVersion() {
            return ApplicationDeployment.IsNetworkDeployed
                   ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                   : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        internal static string GetAuthor() {
            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
        }

        internal static string GetCopyright() {
            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        internal static string GetTitle() {
            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0) {
                var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "") {
                    return titleAttribute.Title;
                }
            }
            return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }

        internal static string GetProduct() {
            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AppSettings.InitSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
