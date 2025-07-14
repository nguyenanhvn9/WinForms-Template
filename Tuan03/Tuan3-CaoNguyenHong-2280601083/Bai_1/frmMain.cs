using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RegisteredUsername { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RegisteredPassword { get; set; }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin(this); // truyền this
            loginForm.ShowDialog();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister(this); // truyền this
            registerForm.ShowDialog();
        }
    }
}
