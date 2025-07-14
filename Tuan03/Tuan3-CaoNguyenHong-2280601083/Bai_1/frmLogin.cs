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
    public partial class frmLogin : Form
    {
        private frmMain mainForm;

        public frmLogin(frmMain main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forgot Password clicked!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == mainForm.RegisteredUsername && txtPassword.Text == mainForm.RegisteredPassword)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
