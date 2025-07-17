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
    public partial class frmInputDataTime : Form
    {
        public frmInputDataTime()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string input = maskedTextBox_Time.Text.Trim(); // Lấy dữ liệu từ TextBox
            DateTime ngay;

            // Thử chuyển đổi chuỗi nhập thành kiểu DateTime
            if (DateTime.TryParseExact(input, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out ngay))
            {
                // Nếu hợp lệ, hiển thị thông tin ngày
                MessageBox.Show("Ngày bạn nhập là: " + ngay.ToString("dddd, dd MMMM yyyy"),
                                "Thông tin ngày", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Nếu không hợp lệ, báo lỗi
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
