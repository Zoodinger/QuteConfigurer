using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qute
{
    class Configuration
    {
        public static class State
        {
            public readonly static string Debug = "DebugGame";
            public readonly static string Development = "Development";
            public readonly static string Shipping = "Shipping";
        }

        public static class Mode
        {
            public readonly static string None = "";
            public readonly static string Editor = "Editor";
            public readonly static string Uncooked = "Uncooked";
        }

        public static class Flag
        {
            public readonly static string None = "";
            public readonly static string Rocket = "-rocket";
            public readonly static string Debug = "-debug";
            public readonly static string Game = "-game";
        }

        public static class Target
        {
            public readonly static string Win64 = "Win64";
            public readonly static string Win32 = "Win32";
        }

        internal struct Build
        {
            public string Name;
            public string State;
            public string Mode;
            public string Flag;
            public string Target;
            public string WorkDir;

            public override string ToString() {
                return Name;
            }
        }

        internal struct Run
        {
            public string Name;
            public string Flag;
            public string Executable;
            public string WorkDir;
            public bool ProjectArgument;

            public override string ToString() {
                return Name;
            }
        }
    }
}
