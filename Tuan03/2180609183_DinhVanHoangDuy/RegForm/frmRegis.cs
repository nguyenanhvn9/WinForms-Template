namespace RegForm
{
    public partial class frmRegis : Form
    {
        public frmRegis()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text) ||
                string.IsNullOrWhiteSpace(this.txtPassword.Text) ||
                string.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            User user = new User();
            user.SetFirstName(this.txtFirstname.Text);
            user.SetLastName(this.txtLastname.Text);
            user.SetMobile(this.txtMobile.Text);
            user.SetAddress(this.txtAddress.Text);
            user.SetUserName(this.txtUsername.Text);
            user.SetPassword(this.txtPassword.Text);
            user.SetEmail(this.txtEmail.Text);

            frmMain.users.Add(user);

            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtFirstname.Focus();
            MessageBox.Show("Đăng ký thành công!");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
