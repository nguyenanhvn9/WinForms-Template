using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien_ADO_Disconnected
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dtSinhVien;
        string connStr = "Data Source=DESKTOP-I47SOG3\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Sẵn sàng";
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);
                adapter = new SqlDataAdapter("SELECT * FROM SinhVien", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                dgvSinhVien.DataSource = dtSinhVien;

                lblStatus.Text = "Tải thành công: " + dtSinhVien.Rows.Count + " dòng.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtLop.Text = row.Cells["Lop"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                else
                    dtpNgaySinh.Value = DateTime.Today;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dtSinhVien.NewRow();
                row["MaSV"] = txtMaSV.Text;
                row["HoTen"] = txtHoTen.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                row["Lop"] = txtLop.Text;
                dtSinhVien.Rows.Add(row);

                lblStatus.Text = "Đã thêm (chưa cập nhật)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                int index = dgvSinhVien.CurrentRow.Index;
                dtSinhVien.Rows[index]["HoTen"] = txtHoTen.Text;
                dtSinhVien.Rows[index]["NgaySinh"] = dtpNgaySinh.Value;
                dtSinhVien.Rows[index]["Lop"] = txtLop.Text;

                lblStatus.Text = "Đã sửa (chưa cập nhật)";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                int index = dgvSinhVien.CurrentRow.Index;
                dtSinhVien.Rows[index].Delete();

                lblStatus.Text = "Đã đánh dấu xóa (chưa cập nhật)";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dtSinhVien);
                lblStatus.Text = "Cập nhật thành công!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
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
