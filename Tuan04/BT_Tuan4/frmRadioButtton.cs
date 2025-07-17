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
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }



        private void btnXem_Click(object sender, EventArgs e)
        {
            string tinhTrang = "";
            string gioiTinh = "";
            char[] selectedOptions = new char[2];

            // Lấy tình trạng hôn nhân
            foreach (Control control in grbTinhTrangHonNhan.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    tinhTrang = rb.Text;

                    // Mã hóa lựa chọn
                    if (rb == rbDocThan) selectedOptions[0] = '1';
                    else if (rb == rbCoGiaDinh) selectedOptions[0] = '2';
                    else if (rb == rbLyHon) selectedOptions[0] = '3';

                    break;
                }
            }

            // Lấy giới tính
            foreach (Control control in grbGioiTinh.Controls)
            {
                if (control is RadioButton rb && rb.Checked)
                {
                    gioiTinh = rb.Text;

                    // Mã hóa lựa chọn
                    if (rb == rbNam) selectedOptions[1] = '1';
                    else if (rb == rbNu) selectedOptions[1] = '2';

                    break;
                }
            }

            // Kiểm tra nếu chưa chọn đủ
            if (string.IsNullOrEmpty(tinhTrang) || string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("⚠️ Vui lòng chọn đầy đủ tình trạng hôn nhân và giới tính.",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin đã chọn
            string thongBao = $"✅ Tình trạng hôn nhân: {tinhTrang}\n" +
                              $"✅ Giới tính: {gioiTinh}";

            MessageBox.Show(thongBao, "Thông Tin Đã Chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      
    }
}
