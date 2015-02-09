using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Qute.Properties;

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
                Console.Error.WriteLine("Error: Failed to read data from project file.");
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
                    Console.Error.WriteLine("Error: Could not detect Visual Studio project files.");
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
                            } else if (sub.Name == "ClInclude" && sub.Attributes != null) {
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
                                var entries = text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
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

        struct BuildConfig
        {
            public string Name;
            public string Output;
            public string BuildCmd;
            public string CleanCmd;
            public string Arguments;
        }

        static void WriteQValue(this XmlWriter writer, string type, string key, object text) {
            writer.WriteStartElement("value");
            writer.WriteAttributeString("type", type);
            if (key != null) {
                writer.WriteAttributeString("key", key);
            }
            writer.WriteString(text.ToString());
            writer.WriteEndElement();
        }

        static void StartQMap(this XmlWriter writer, string type, string key) {
            writer.WriteStartElement("valuemap");
            writer.WriteAttributeString("type", type);
            if (key != null) {
                writer.WriteAttributeString("key", key);
            }
        }

        static void EndQMap(this XmlWriter writer) {
            writer.WriteEndElement();
        }

        public static void ExportConfiguration(QuteResolver.UEProject project, QuteResolver.Kit kit) {
            if (string.IsNullOrWhiteSpace(project.Name) || string.IsNullOrWhiteSpace(project.Engine)) {
                Console.Error.WriteLine("Error: Failed to read data from project file.");
                return;
            }

            var unrealEnginePath = Path.Combine(Settings.Default.UEPath, project.Engine);
            var unrealBatchPath = Path.Combine(unrealEnginePath, @"Engine\Build\BatchFiles\");

            var projPath = Path.GetDirectoryName(project.Path) ?? "";
            var configPath = Path.Combine(projPath, @"Intermediate\ProjectFiles\");
            var workingDir = Path.Combine(projPath, @"Intermediate\Build\");

            var configurations = new BuildConfig[] 
            {
                new BuildConfig {
                    Name = "Debug Editor",
                    BuildCmd = unrealBatchPath + "Build.bat",
                    CleanCmd = unrealBatchPath + "Clean.bat" ,
                    Arguments = string.Format("{0}Editor Win64 DebugGame \"{1}\" -rocket", project.Name, project.Path)
                }
            };


            for (int i = 0; i < configurations.Length; ++i) {
                configurations[i].Output = Path.Combine(configPath, @"Qute\" + configurations[i].Name);
            }

            try {
                using (var xml = new XmlTextWriter(configPath + project.Name + ".pro.user", Encoding.UTF8)) {
                    xml.Formatting = Formatting.Indented;
                    xml.WriteStartDocument();
                    xml.WriteDocType("QtCreatorProject", null, null, null);
                    xml.WriteComment(" Written with Qute " + Program.GetVersion() + " ");

                    xml.WriteStartElement("qtcreator");

                    xml.WriteStartElement("data");
                    {
                        xml.WriteStartElement("variable");
                        xml.WriteString("ProjectExplorer.Project.Target.0");
                        xml.WriteEndElement();

                        xml.StartQMap("valuemap", null);
                        {

                            //Information about the kit
                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", kit.Name);
                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", kit.Name);
                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", kit.Id);

                            for (var i = 0; i < configurations.Length; ++i) {
                                xml.StartQMap("QVariantMap", "ProjectExplorer.Target.BuildConfiguration." + i);
                                {
                                    xml.WriteQValue("QString", "ProjectExplorer.BuildConfiguration.BuildDirectory", configurations[i].Output);

                                    //Information for the Build command
                                    xml.StartQMap("QVariantMap", "ProjectExplorer.BuildConfiguration.BuildStepList.0");
                                    {
                                        xml.StartQMap("QVariantMap", "ProjectExplorer.BuildStepList.Step.0");
                                        {
                                            xml.WriteQValue("bool", "ProjectExplorer.BuildStep.Enabled", true);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.Arguments", configurations[i].Arguments);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.Command", configurations[i].BuildCmd);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.WorkingDirectory", workingDir);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", "Custom Process Step");
                                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", "Custom Process Step");
                                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "ProjectExplorer.ProcessStep");
                                        }
                                        xml.EndQMap();

                                        xml.WriteQValue("int", "ProjectExplorer.BuildStepList.StepsCount", 1);
                                        xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", "Build");
                                        xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", "Build");
                                        xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "ProjectExplorer.BuildSteps.Build");
                                    }
                                    xml.EndQMap();

                                    //Information for the Clean command
                                    xml.StartQMap("QVariantMap", "ProjectExplorer.BuildConfiguration.BuildStepList.1");
                                    {
                                        xml.StartQMap("QVariantMap", "ProjectExplorer.BuildStepList.Step.0");
                                        {
                                           xml.WriteQValue("bool", "ProjectExplorer.BuildStep.Enabled", true);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.Arguments", configurations[i].Arguments);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.Command", configurations[i].CleanCmd);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProcessStep.WorkingDirectory", workingDir);
                                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", "Custom Process Step");
                                           // xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", "Custom Process Step");
                                            xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "ProjectExplorer.ProcessStep");
                                        }
                                        xml.EndQMap();

                                        xml.WriteQValue("int", "ProjectExplorer.BuildStepList.StepsCount", 1);
                                        xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", "Clean");
                                       // xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", "Clean");
                                        xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "ProjectExplorer.BuildSteps.Clean");
                                    }
                                    xml.EndQMap();

                                    //General information for the build

                                    xml.WriteQValue("int", "ProjectExplorer.BuildConfiguration.BuildStepListCount", 2);

                                    xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", configurations[i].Name);
                                    xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", configurations[i].Name);
                                    xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "Qt4ProjectManager.Qt4BuildConfiguration");
                                    xml.WriteQValue("int", "Qt4ProjectManager.Qt4BuildConfiguration.BuildConfiguration", 2);
                                    xml.WriteQValue("bool", "Qt4ProjectManager.Qt4BuildConfiguration.UseShadowBuild", true);
                                }
                                xml.EndQMap();
                            }
                            xml.WriteQValue("int", "ProjectExplorer.Target.BuildConfigurationCount", configurations.Length);


                            xml.StartQMap("QVariantMap", "ProjectExplorer.Target.RunConfiguration.0");
                            {
                                var editorExecutable = Path.Combine(unrealEnginePath, @"Engine\Binaries\Win64\UE4Editor.exe");
                                var argument = string.Format("\"{0}\" -game", project.Path);
                                var wDir = Path.Combine(projPath, @"Binaries\Win64");

                                xml.WriteQValue("QString", "ProjectExplorer.CustomExecutableRunConfiguration.Arguments", argument);
                                xml.WriteQValue("QString", "ProjectExplorer.CustomExecutableRunConfiguration.Executable", editorExecutable);
                                xml.WriteQValue("bool", "ProjectExplorer.CustomExecutableRunConfiguration.UseTerminal", false);
                                xml.WriteQValue("QString", "ProjectExplorer.CustomExecutableRunConfiguration.WorkingDirectory", wDir);
                                xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DefaultDisplayName", "Run");
                                xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.DisplayName", "Run");
                                xml.WriteQValue("QString", "ProjectExplorer.ProjectConfiguration.Id", "ProjectExplorer.CustomExecutableRunConfiguration");
                                xml.WriteQValue("bool", "RunConfiguration.UseCppDebugger", true);
                                xml.WriteQValue("bool", "RunConfiguration.UseCppDebuggerAuto", false);
                                xml.WriteQValue("bool", "RunConfiguration.UseMultiProcess", false);
                                xml.WriteQValue("bool", "RunConfiguration.UseQmlDebugger", false);
                                xml.WriteQValue("bool", "RunConfiguration.UseQmlDebuggerAuto", false);
                            }
                            xml.EndQMap();
                            xml.WriteQValue("int", "ProjectExplorer.Target.RunConfigurationCount", 1);
                        }
                        xml.WriteEndElement(); // valuemap
                    }
                    xml.WriteEndElement(); //data

                    // Final information. I don't know what this meas exactly, but it's required.

                    xml.WriteStartElement("data");
                    {
                        xml.WriteStartElement("variable");
                        xml.WriteString("ProjectExplorer.Project.TargetCount");
                        xml.WriteEndElement();
                        xml.WriteQValue("int", null, 1);
                    }
                    xml.WriteEndElement();

                    xml.WriteStartElement("data");
                    {
                        xml.WriteStartElement("variable");
                        xml.WriteString("ProjectExplorer.Project.TargetCount");
                        xml.WriteEndElement();
                        xml.WriteQValue("int", null, 1);
                    }
                    xml.WriteEndElement();

                    xml.WriteStartElement("data");
                    {
                        xml.WriteStartElement("variable");
                        xml.WriteString("ProjectExplorer.Project.Updater.FileVersion");
                        xml.WriteEndElement();
                        xml.WriteQValue("int", null, 18);
                    }
                    xml.WriteEndElement();

                    xml.WriteStartElement("data");
                    {
                        xml.WriteStartElement("variable");
                        xml.WriteString("Version");
                        xml.WriteEndElement();
                        xml.WriteQValue("int", null, 18);
                    }
                    xml.WriteEndElement();


                    xml.WriteEndElement();
                }
                Console.WriteLine("Project Configuration was created in " + configPath);
            } catch (Exception e) {
                Console.Error.WriteLine("Error: Failed to write project configuration.");
            }
        }
    }
}
