using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Qute
{
    public partial class AboutForm : Form
    {
        public AboutForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Close();
        }

        private void AboutForm_Load(object sender, EventArgs e) {
            lblProduct.Text = Program.GetProduct();
            lblVersion.Text = "Version " + Program.GetVersion();
            lblAuthor.Text = Program.GetAuthor();
        }

        private void description_LinkClicked(object sender, LinkClickedEventArgs e) {
            Process.Start(e.LinkText);
        }
    }
}
