using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Qute
{
    static class QuteExporter
    {
        /// <summary>
        /// Export all necessary Qt Project files.
        /// </summary>
        /// <param name="project"></param>
        public static void ExportProject(QuteResolver.UEProject project) {
            if (string.IsNullOrWhiteSpace(project.Name) || string.IsNullOrWhiteSpace(project.Engine)) {
                Console.WriteLine("Error: Failed to read data from project file.");
                return;
            }

            var projLoc = Path.GetDirectoryName(project.Path) ?? "";
            projLoc = Path.Combine(projLoc, @"Intermediate\ProjectFiles\");

            var vsProjPath = projLoc + project.Name + ".vcxproj";

            StreamWriter qtProject = null;
            StreamWriter qtDefines = null;
            StreamWriter qtIncludes = null;

            //Make sure all three files can be written to before proceeding.
            try {
                qtProject = new StreamWriter(projLoc + project.Name + ".pro");
                qtDefines = new StreamWriter(projLoc + "defines.pri");
                qtIncludes = new StreamWriter(projLoc + "includes.pri");
            } catch {
                if (qtProject != null) {
                    qtProject.Close();
                } else {
                    Console.WriteLine("Could not open {0}", projLoc + project.Name + ".pro");
                }

                if (qtDefines != null) {
                    qtDefines.Close();
                } else {
                    Console.WriteLine("Could not open {0}", projLoc + "defines.pri");
                }

                if (qtIncludes != null) {
                    qtIncludes.Close();
                } else {
                    Console.WriteLine("Could not open {0}", projLoc + "includes.pri");
                }

                return;
            }

            try {

                qtProject.WriteLine("TEMPLATE = app");
                qtProject.WriteLine("CONFIG += console");
                qtProject.WriteLine("CONFIG -= app_bundle");
                qtProject.WriteLine("CONFIG -= qt");
                qtProject.WriteLine("CONFIG += c++11");
                qtProject.WriteLine();
                qtProject.WriteLine("include(defines.pri)");
                qtProject.WriteLine();

                var doc = new XmlDocument();
                doc.Load(vsProjPath);
                if (!File.Exists(vsProjPath)) {
                    Console.WriteLine("Error: Could not detect Visual Studio project files.");
                    return;
                }

                var root = doc.ChildNodes.Cast<XmlNode>().FirstOrDefault(child => child.Name == "Project");

                if (root == null) {
                    Console.WriteLine("Error reading {0}", Path.GetFileName(vsProjPath));
                    return;
                }

                foreach (XmlNode node in root) {
                    if (node.Name == "ItemGroup") {
                        foreach (XmlNode sub in node.ChildNodes) {
                            if (sub.Name == "ClCompile" && sub.Attributes != null) {
                                var include = sub.Attributes["Include"];
                                if (include != null) {
                                    qtProject.WriteLine("SOURCES += " + include.Value);
                                }
                            }
                            else if (sub.Name == "ClInclude" && sub.Attributes != null) {
                                var include = sub.Attributes["Include"];
                                if (include != null) {
                                    qtProject.WriteLine("HEADERS += " + include.Value);
                                }
                            }
                        }
                    } else if (node.Name == "PropertyGroup") {
                        foreach (XmlNode sub in node.ChildNodes) {
                            if (sub.Name == "NMakePreprocessorDefinitions") {
                                var text = sub.InnerText;
                                var entries = text.Split(new[]{';'}, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var entry in entries) {
                                    qtDefines.WriteLine("DEFINES += \"" + entry.Trim() + "\"");
                                }
                            } else if (sub.Name == "NMakeIncludeSearchPath") {
                                var text = sub.InnerText;
                                var entries = text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (var entry in entries) {
                                    qtIncludes.WriteLine("INCLUDEPATH += \"" + entry.Trim() + "\"");
                                }
                            }
                        }
                    }
                }

                qtProject.WriteLine();
                qtProject.WriteLine("include(includes.pri)");

                Console.WriteLine("Qt project files were created in " + projLoc);

            } finally {
                qtProject.Close();
                qtDefines.Close();
                qtIncludes.Close();
            }
        }
    }
}
