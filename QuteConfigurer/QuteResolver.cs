using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Win32;

namespace QtConfigurator
{
    class QuteResolver
    {
        public struct Kit
        {
            public string Name;
            public string Id;

            public Kit(string name, string id) {
                Name = name;
                Id = id;
            }

            public override string ToString() {
                return Name;
            }
        }

        /// <summary>
        /// Gets the install path of Qt from the Registry.
        /// </summary>
        /// <returns>The install path or null if not found or an error occurs.</returns>
        public static string GetDetectedQtPath() {
            try {
                return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\Qt", "InstallLocation", "") as string;
            } catch {
                return "";
            }
        }

        /// <summary>
        /// Gets the install path of Unreal Engine from the Registry.
        /// </summary>
        /// <returns>The install path or null if not found or an error occurs.</returns>
        public static string GetDetectedUEPath() {
            try {
                var view = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);
                var key = localMachine.OpenSubKey(@"SOFTWARE\EpicGames\Unreal Engine", false);
                return key == null ? null : key.GetValue("INSTALLDIR", null) as string;
            } catch {
                return null;
            }
        }

        public static IEnumerable<Kit> GetKits() {
            var outList = new List<Kit>();

            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fullPath = Path.Combine(appData, @"QtProject\qtcreator\profiles.xml");

            var doc = new XmlDocument();

            if (!File.Exists(fullPath)) {
                return outList;
            }

            doc.Load(fullPath);
            var root = doc.SelectSingleNode("qtcreator");

            if (root == null) {
                return outList;
            }

            foreach (XmlNode dataChild in root.ChildNodes) {
                foreach (XmlNode vm in dataChild.ChildNodes) {
                    if (vm.Name != "valuemap") { continue; }
                    var kit = new Kit("", "");
                    foreach (XmlNode value in vm.ChildNodes) {
                        if (value.Name != "value" || value.Attributes == null) { continue; }
                        var keyAttr = value.Attributes["key"];
                        if (keyAttr != null) {
                            switch (keyAttr.Value) {
                                case "PE.Profile.Id":
                                    kit.Id = value.InnerText
                                        .Replace("%{Qt:Version} ", "") // Avoid double spaces in name
                                        .Replace("%{Qt:Version}", "");
                                    break;
                                case "PE.Profile.Name":
                                    kit.Name = value.InnerText
                                        .Replace("%{Qt:Version}", "")
                                        .Replace("  ", " "); // Avoid double spaces in name
                                    break;
                            }
                        }
                    }
                    if (kit.Name != "" && kit.Id != "") {
                        outList.Add(kit);
                    }
                }
            }

            return outList;
        }
    }
}
