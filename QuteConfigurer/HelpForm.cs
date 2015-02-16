using System;
using System.Diagnostics;
using System.Windows.Forms;
using Qute.Properties;

namespace Qute
{
    public partial class HelpForm : Form
    {
        public HelpForm() {
            InitializeComponent();
        }

        string[] _entries;

        int _count;
        int _index;

        public void SetData(params string[] pages) {
            _count = pages.Length;
            _entries = pages;
            Index = 0;
            if (_count == 1) {
                btnNext.Visible = false;
                btnPrevious.Visible = false;
                title.Visible = false;
            }
        }

        public int Index {
            get { return _index; }
            set {
                if (value < 0 || value >= _count) {
                    return;
                }
                _index = value;
                title.Text = string.Format("Step {0}/{1}", _index + 1, _count);
                var rtf = Resources.ResourceManager.GetObject(_entries[_index]) as string;
                text.Rtf = rtf;
                btnPrevious.Enabled = _index > 0;
                btnNext.Enabled = _index + 1 < _count;
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            ++Index;
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            --Index;
        }

        private void text_LinkClicked(object sender, LinkClickedEventArgs e) {
            Process.Start(e.LinkText);
        }
    }
}
