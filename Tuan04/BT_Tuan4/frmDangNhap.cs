using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmaiID.Text.Trim();
            string password = txtPassword.Text.Trim();
            // Kiểm tra dữ liệu đơn giản
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Email và Mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hiển thị thông tin đã nhập
            string info = $"📧 Email: {email}\n" +
                          $"🔒 Mật khẩu: {password}";
            MessageBox.Show(info, "Thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isAuthenticated = false;
            try
            {
                string filePath = "users.txt";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy dữ liệu người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        string savedEmail = parts[6];
                        string savedPassword = parts[5];

                        if (email.Equals(savedEmail, StringComparison.OrdinalIgnoreCase) &&
                            password == savedPassword)
                        {
                            isAuthenticated = true;
                            break;
                        }
                    }
                }

                if (isAuthenticated)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đăng nhập
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Xác nhận thoát ứng dụng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau quenMatKhauForm = new frmQuenMatKhau();
            quenMatKhauForm.StartPosition = FormStartPosition.CenterParent;
            quenMatKhauForm.ShowDialog();


        }



        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }


    }
}
