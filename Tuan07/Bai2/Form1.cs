using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private SinhVienModelEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new SinhVienModelEntities();
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSinhVien.DataSource = db.SinhViens.ToList();
                lblStatus.Text = "Số bản ghi: " + db.SinhViens.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                object ngaySinh = row.Cells["NgaySinh"].Value;
                if (ngaySinh != DBNull.Value && ngaySinh != null)
                    dtpNgaySinh.Value = Convert.ToDateTime(ngaySinh);
                else
                    dtpNgaySinh.Value = DateTime.Today;

                txtLop.Text = row.Cells["Lop"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = txtMaSV.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    Lop = txtLop.Text
                };

                db.SinhViens.Add(sv);
                lblStatus.Text = "Đã thêm (chưa lưu)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                var sv = db.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
                if (sv != null)
                {
                    sv.HoTen = txtHoTen.Text;
                    sv.NgaySinh = dtpNgaySinh.Value;
                    sv.Lop = txtLop.Text;
                    lblStatus.Text = "Đã sửa (chưa lưu)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                var sv = db.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
                if (sv != null)
                {
                    db.SinhViens.Remove(sv);
                    lblStatus.Text = "Đã xóa (chưa lưu)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công!");
                lblStatus.Text = "Đã lưu vào CSDL";
                btnTaiDuLieu_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            dtpNgaySinh.Value = DateTime.Today;
        }
    }
}
