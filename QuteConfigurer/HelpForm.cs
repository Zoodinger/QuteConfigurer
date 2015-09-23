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
            
            if (_count == 1) {
                btnPrevious.Visible = false;
                title.Visible = false;
            }

            Index = 0;
        }

        private int Index {
            get { return _index; }
            set {
                if (value < 0 || value >= _count) {
                    return;
                }
                _index = value;
                title.Text = string.Format("Step {0}/{1}", _index + 1, _count);
                var rtf = Resources.ResourceManager.GetObject(_entries[_index]) as string;
                // The following is a hack that will replace $(UserFolder) with the user folder, used for a specific page in the documentation
                if (rtf != null) {
                    var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    // '\' characters need to be escaped
                    userProfile = userProfile.Replace(@"\", @"\\");
                    rtf = rtf.Replace("$(UserFolder)", userProfile);
                }
                text.Rtf = rtf;
                btnPrevious.Enabled = _index > 0;
                btnNext.Text = _index + 1 < _count ? "&Next" : "&Close";
                text.Select(0, 0);
                text.Focus();
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (_index + 1 == _count) {
                Close();
            } else {
                ++Index;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            --Index;
        }

        private void text_LinkClicked(object sender, LinkClickedEventArgs e) {
            Process.Start(e.LinkText);
        }

        private void HelpForm_Shown(object sender, EventArgs e)
        {
            text.Select(0, 0);
            text.Focus();
        }
    }
}
