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
            frmDangNhap.StartPosition = FormStartPosition.CenterParent;
            frmDangNhap.ShowDialog();




        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy(); // Correct form for Registration
            frmDangKy.StartPosition = FormStartPosition.CenterParent;
            frmDangKy.ShowDialog();



        }
    }
}
