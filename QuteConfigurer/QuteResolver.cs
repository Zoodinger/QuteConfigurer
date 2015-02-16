using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace Qute
{
    /// <summary>
    /// Responsible for reading data from the disk.
    /// </summary>
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

        /// <summary>
        /// Represents information about an Unreal Engine project.
        /// </summary>
        public struct UEProject
        {
            public string Path;
            public string Engine;
            public string Name;

            public UEProject(string name, string engine, string path) {
                Path = path;
                Engine = engine;
                Name = name;
            }
        }
        
        /// <summary>
        /// Gets Unreal Project information from a file.
        /// </summary>
        public static UEProject GetProjectInfo(string path) {
            string name = null;
            string engine = null;

            try {
                using (var reader = new StreamReader(path)) {
                    var data = reader.ReadToEnd();
                    var json = JObject.Parse(data);

                    foreach (var node in json) {
                        if (node.Key == "EngineAssociation") {
                            engine = node.Value.ToString();
                        }

                        if (node.Key != "Modules") {
                            continue;
                        }

                        foreach (var module in node.Value.Select(JObject.FromObject)) {
                            foreach (var entry in module) {
                                if (entry.Key == "Name") {
                                    name = entry.Value.ToString();
                                }
                            }

                        }
                    }
                }

            } catch (FileNotFoundException) {
                throw new QuteException("Error: File not found.");
            } catch (ArgumentException) {
                throw new QuteException("Error: Invalid project path.");
            } catch {
                throw new QuteException("Error: Could not read project information.");
            }

            if (name == null || engine == null) {
                throw new QuteException("Error: Missing project information.");
            }

            return new UEProject(name, engine, path);

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
        /// Gets the location of the Qt Creator executable, based on the install location of Qt
        /// </summary>
        /// <returns></returns>
        public static string GetDetectedQtCreatorPath() {
            return Path.Combine(GetDetectedQtPath(), @"Tools\QtCreator\bin\qtcreator.exe");
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
        /// Get a sequence containing all the kits available for Qt Creator.
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
