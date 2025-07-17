using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap(); // Correct form for Login
            frmDangNhap.MdiParent = this;
            frmDangNhap.StartPosition = FormStartPosition.CenterParent;
            frmDangNhap.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.MdiParent = this;
            frmDangKy.StartPosition = FormStartPosition.CenterParent;
            frmDangKy.Show();
        }

        private void inputDataTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputDataTime frmInputDataTime = new frmInputDataTime();
            frmInputDataTime.MdiParent = this;
            frmInputDataTime.StartPosition = FormStartPosition.CenterParent;
            frmInputDataTime.Show();
        }

        private void comBoboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComBobox frmComBobox = new frmComBobox();
            frmComBobox.MdiParent = this;
            frmComBobox.StartPosition = FormStartPosition.CenterParent;
            frmComBobox.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBox frmListBox = new frmListBox();
            frmListBox.MdiParent = this;
            frmListBox.StartPosition = FormStartPosition.CenterParent;
            frmListBox.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckBox frmCheckBox = new frmCheckBox();
            frmCheckBox.MdiParent = this;
            frmCheckBox.StartPosition = FormStartPosition.CenterParent;
            frmCheckBox.Show();
        }

        private void raidoButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadioButton frmRadioButton = new frmRadioButton();
            frmRadioButton.MdiParent = this;
            frmRadioButton.StartPosition = FormStartPosition.CenterParent;
            frmRadioButton.Show();
        }

       
    }
}
