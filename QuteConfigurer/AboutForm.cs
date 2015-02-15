using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
