using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.Show();

        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }
    }
}
