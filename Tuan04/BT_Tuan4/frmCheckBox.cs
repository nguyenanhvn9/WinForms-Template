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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Khởi tạo danh sách lưu các mục đã chọn
            List<string> soThichDaChon = new List<string>();

            // Duyệt qua các mục trong CheckedListBox
            for (int i = 0; i < chkSoThich.Items.Count; i++)
            {
                if (chkSoThich.GetItemChecked(i))
                {
                    string muc = chkSoThich.Items[i].ToString();
                    soThichDaChon.Add("✔ " + muc);
                }
            }

            // Tạo thông báo kết quả
            string thongBao;

            if (soThichDaChon.Count > 0)
            {
                thongBao = "✅ Các sở thích bạn đã chọn:\n\n";
                thongBao += string.Join("\n", soThichDaChon);
            }
            else
            {
                thongBao = "⚠️ Bạn chưa chọn sở thích nào!";
            }

            // Hiển thị hộp thoại kết quả
            MessageBox.Show(thongBao, "Kết quả chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
