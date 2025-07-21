using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmStudentManagement : Form
    {
        public static List<Students> studentList = new List<Students>();
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string rollNo = txtRollNo.Text;
            string studentName = txtStudentName.Text;
            string degree = txtDegree.Text;
            string gpa = txtGpa.Text;

            // Kiểm tra xem các ô có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(rollNo) ||
                string.IsNullOrWhiteSpace(studentName) ||
                string.IsNullOrWhiteSpace(degree) ||
                string.IsNullOrWhiteSpace(gpa))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo một đối tượng sinh viên mới
            Students newStudent = new Students
            {
                RollNo = rollNo,
                Name = studentName,
                Degree = degree,
                Gpa = gpa
            };

            // Thêm sinh viên vào danh sách
            studentList.Add(newStudent);

            // Hiển thị thông báo thành công
            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa nội dung các TextBox
            txtRollNo.Clear();
            txtStudentName.Clear();
            txtDegree.Clear();
            txtGpa.Clear();
            txtRollNo.Focus();
        }

        private void btnSelectOperation_Click(object sender, EventArgs e)
        {
            frmStudentList studentListForm = new frmStudentList();
            studentListForm.Show(); // Sử dụng Show() để có thể tương tác với cả hai form

        }
    }
}
