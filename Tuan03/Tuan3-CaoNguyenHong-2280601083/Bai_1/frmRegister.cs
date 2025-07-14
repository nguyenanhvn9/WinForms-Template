namespace Bai_1
{
    public partial class frmRegister : Form
    {
        private frmMain mainForm;

        public frmRegister(frmMain main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Fistname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Username = txtUserName.Text
            };
            MessageBox.Show($"User {user.Fistname} {user.Lastname} saved successfully!");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            mainForm.RegisteredUsername = txtUserName.Text;
            mainForm.RegisteredPassword = txtPassword.Text;
            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }
    }

    class User
    {
        public string Fistname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
