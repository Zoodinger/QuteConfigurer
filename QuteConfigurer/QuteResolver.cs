using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Qute
{
    static class QuteResolver
    {
        /// <summary>
        /// Contains information about a Qt kit.
        /// </summary>
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

        public struct UEProject
        {
            public string Path;
            public string Engine;
            public string Name;

            public UEProject(string path, string name, string engine) {
                Name = name;
                Engine = engine;
                Path = path;
            }
        }

        public static UEProject GetProjectInfo(string path) {
            var project = new UEProject { Path = path };

            try {
                using (var reader = new StreamReader(path)) {
                    var data = reader.ReadToEnd();
                    var json = JObject.Parse(data);

                    foreach (var node in json) {
                        if (node.Key == "EngineAssociation") {
                            project.Engine = node.Value.ToString();
                        }

                        if (node.Key != "Modules") {
                            continue;
                        }

                        foreach (var module in node.Value.Select(JObject.FromObject)) {
                            foreach (var entry in module) {
                                if (entry.Key == "Name") {
                                    project.Name = entry.Value.ToString();
                                }
                            }

                        }
                    }
                }
            } catch (FileNotFoundException) {
                Console.WriteLine("Error: File not found.");
            } catch (ArgumentException) {
                Console.WriteLine("Error: Invalid project path.");
            } catch {
                Console.WriteLine("Error: Could not read project information.");
            }

            return project;
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

        /// <summary>
        /// Get a sequence containing all the kits
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Kit> GetKits() {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fullPath = Path.Combine(appData, @"QtProject\qtcreator\profiles.xml");

            var doc = new XmlDocument();

            if (!File.Exists(fullPath)) {
                yield break;
            }

            doc.Load(fullPath);
            var root = doc.SelectSingleNode("qtcreator");

            if (root == null) {
                yield break;
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
                                        .Replace("%{Qt:Version}", "")
                                        .Replace("  ", " ").Trim(); // Avoid double spaces in name
                                    break;
                                case "PE.Profile.Name":
                                    kit.Name = value.InnerText
                                        .Replace("%{Qt:Version}", "")
                                        .Replace("  ", " ").Trim(); // Avoid double spaces in name
                                    break;
                            }
                        }
                    }
                    if (kit.Name != "" && kit.Id != "") {
                        yield return kit;
                    }
                }
            }
        }
    }
}
