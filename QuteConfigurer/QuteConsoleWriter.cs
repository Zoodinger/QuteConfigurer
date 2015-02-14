using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Qute
{
    /// <summary>
    /// A TextWriter that outputs text to a RichTextBox
    /// </summary>
    class QuteConsoleWriter : TextWriter
    {
        private readonly RichTextBox _textBox;
        private readonly Color _color;

        public QuteConsoleWriter(RichTextBox textbox) {
            _textBox = textbox;
            _color = textbox.ForeColor;
        }

        public QuteConsoleWriter(RichTextBox textbox, Color color) {
            _textBox = textbox;
            _color = color;
        }

        public override void Write(char value) {
            base.Write(value);
            
            _textBox.SelectionStart = _textBox.TextLength;
            _textBox.SelectionLength = 0;

            _textBox.SelectionColor = _color;
            _textBox.AppendText(value.ToString(CultureInfo.InvariantCulture));
            _textBox.SelectionColor = _textBox.ForeColor;

        }

        public override Encoding Encoding {
            get { return Encoding.UTF8; }
        }
    }

}
