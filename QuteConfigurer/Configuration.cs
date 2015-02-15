using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qute
{
    /// <summary>
    /// Contains Build configuration information that can be exported
    /// </summary>
    struct Configuration
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
}
