using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QtConfigurator
{
    public class ConsoleOutWriter : TextWriter
    {
        TextBox _target;

        public ConsoleOutWriter(TextBox target) {
            _target = target;
        }

        public override void Write(char value) {
        }

        public override Encoding Encoding {
            get { return Encoding.UTF8; }
        }
    }
}
