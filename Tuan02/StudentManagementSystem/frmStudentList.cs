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
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null; // Xóa nguồn cũ để làm mới
            dgvStudents.DataSource = frmStudentManagement.studentList;
        }
    }
}
