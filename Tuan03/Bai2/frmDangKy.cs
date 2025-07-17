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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnSaVe_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra dữ liệu đơn giản
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ, Tên và Email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin đã nhập
            string info = $"👤 Họ tên: {firstName} {lastName}\n" +
                          $"🏠 Địa chỉ: {address}\n" +
                          $"📱 SĐT: {mobile}\n" +
                          $"🧑‍💻 Tài khoản: {username}\n" +
                          $"🔒 Mật khẩu: {password}\n" +
                          $"📧 Email: {email}";

            MessageBox.Show(info, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Tạo file nếu chưa tồn tại và ghi dữ liệu
            try
            {
                string filePath = "users.txt";

                // Tạo file nếu chưa có
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close(); // Tạo và đóng ngay để ghi tiếp
                }

                // Ghi dữ liệu vào file
                string data = $"{firstName},{lastName},{address},{mobile},{username},{password},{email}";
                File.AppendAllText(filePath, data + Environment.NewLine);

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Lưu thông tin vào file
            try
            {
                string data = $"{firstName},{lastName},{address},{mobile},{username},{password},{email}";
                File.AppendAllText("users.txt", data + Environment.NewLine);

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }




    }
}

