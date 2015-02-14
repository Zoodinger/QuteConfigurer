using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qute
{
    static class Configuration
    {
        /// <summary>
        /// Values that should be used to describe the State of a build
        /// </summary>
        public static class State
        {
            public readonly static string Debug = "DebugGame";
            public readonly static string Development = "Development";
            public readonly static string Shipping = "Shipping";
        }

        /// <summary>
        /// Values that should be used to describe the Mode of a build
        /// </summary>
        public static class Mode
        {
            public readonly static string Normal = "";
            public readonly static string Editor = "Editor";
            public readonly static string Uncooked = "Uncooked";
        }

        /// <summary>
        /// Values that can be used as additional arguments to a build
        /// </summary>
        public static class Flag
        {
            public readonly static string None = "";
            public readonly static string Rocket = "-rocket";
            public readonly static string Debug = "-debug";
            public readonly static string Game = "-game";
        }

        /// <summary>
        /// Values that should be used as target platforms of a build
        /// </summary>
        public static class Target
        {
            public readonly static string Win64 = "Win64";
            public readonly static string Win32 = "Win32";
        }

        /// <summary>
        /// Contains Build configuration information that can be exported
        /// </summary>
        internal struct Build
        {
            public string Name;
            public string State;
            public string Mode;
            public string BuildFlags;
            public string RunFlags;
            public string Platform;
            public bool RunFromEditor;
            public string ExeSuffix;

            public override string ToString() {
                return Name;
            }
        }

        public delegate string ArgumentResolver(ProjectData data);
    }
}
