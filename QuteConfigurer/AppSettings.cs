using System;
using System.IO;

namespace Qute
{
    /// <summary>
    /// Holds all application settings. The reason this class is used instead of the default application C# settings
    /// is that manually setting the app.config location does not seem to work. Since the executable can be moved,
    /// its settings need to be stored the same way regardless of its location.
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// Gets or sets the path to the root folder of Unreal Engine 4.
        /// </summary>
        public static string UEPath { get; set; }
        /// <summary>
        /// Gets or sets the location of qtcreator.exe.
        /// </summary>
        public static string QtPath { get; set; }
        /// <summary>
        /// Gets or sets the name of the saved Qt Kit.
        /// </summary>
        public static string KitName { get; set; }
        /// <summary>
        /// Gets or sets the id of the saved Qt Kit.
        /// </summary>
        public static string KitId { get; set; }
        /// <summary>
        /// Gets or sets the bit flags of the build configurations.
        /// </summary>
        public static uint ConfigFlags { get; set; }
        /// <summary>
        /// Gets or sets whether VS files should be always updated before generating Qt project files.
        /// </summary>
        public static bool AlwaysUpdateVS { get; set; }
        /// <summary>
        /// This property will be true the first time the
        /// application runs, or if a settings file was not detected.
        /// </summary>
        public static bool FirstTime { get; private set; }

        /// <summary>
        /// Saves all settings.
        /// </summary>
        public static void Save() {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dir = Path.Combine(appData, @"Qute\");
            Directory.CreateDirectory(dir);
            using (var writer = new StreamWriter(Path.Combine(dir, "settings.ini"))) {
                writer.WriteLine("UEPath=" + UEPath);
                writer.WriteLine("QtPath=" + QtPath);
                writer.WriteLine("KitName=" + KitName);
                writer.WriteLine("KitId=" + KitId);
                writer.WriteLine("ConfigFlags=" + ConfigFlags);
                writer.WriteLine("AlwaysUpdateVS=" + AlwaysUpdateVS);
            }
        }

        /// <summary>
        /// Initializes all settings to default values if a settings file was not found.
        /// </summary>
        public static void InitSettings() {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var settings = Path.Combine(appData, @"Qute\settings.ini");
            if (File.Exists(settings)) {
                using (var stream = new StreamReader(settings)) {
                    string line;
                    while ((line = stream.ReadLine()) != null) {
                        var splitIndex = line.IndexOf('=');
                        if (splitIndex == -1) { continue; }
                        var name = line.Substring(0, splitIndex);
                        try {
                            var value = line.Substring(splitIndex + 1);
                            switch (name) {
                                case "UEPath": UEPath = value;
                                    break;
                                case "QtPath": QtPath = value;
                                    break;
                                case "KitName": KitName = value;
                                    break;
                                case "KitId": KitId = value;
                                    break;
                                case "ConfigFlags": ConfigFlags = uint.Parse(value);
                                    break;
                                case "AlwaysUpdateVS": AlwaysUpdateVS = bool.Parse(value);
                                    break;
                            }
                        } catch {
                            //Suppress all errors when a specific setting failed to be read
                        }
                    }
                }
            } else {
                //Set everything to default values
                UEPath = "";
                QtPath = "";
                KitName = "";
                KitId = "";
                ConfigFlags = 0xFFFFFFFF;
                AlwaysUpdateVS = true;
                FirstTime = true;
            }
        }
    }
}
