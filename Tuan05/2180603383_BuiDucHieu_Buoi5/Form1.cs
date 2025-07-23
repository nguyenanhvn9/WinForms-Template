using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2180603383_BuiDucHieu_Buoi5
{
    public partial class Form1 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSachSV.Add(new SinhVien { MaSV = "SV001", HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(2003, 1, 1), DiemTB = 8.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV002", HoTen = "Trần Thị B", NgaySinh = new DateTime(2004, 5, 10), DiemTB = 7.2 });
            danhSachSV.Add(new SinhVien { MaSV = "SV003", HoTen = "Lê Văn C", NgaySinh = new DateTime(2002, 9, 15), DiemTB = 9.0 });

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = danhSachSV;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
            dgvSinhVien.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["DiemTB"].HeaderText = "Điểm TB";

            dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;
                txtDiemTB.Text = row.Cells["DiemTB"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var svMoi = new SinhVien
            {
                MaSV = txtMaSV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiemTB = double.Parse(txtDiemTB.Text)
            };

            danhSachSV.Add(svMoi);

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = danhSachSV;
            CustomizeDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            var svCanSua = danhSachSV.Find(sv => sv.MaSV == maSV);

            if (svCanSua != null)
            {
                svCanSua.HoTen = txtHoTen.Text;
                svCanSua.NgaySinh = dtpNgaySinh.Value;
                svCanSua.DiemTB = double.Parse(txtDiemTB.Text);

                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = danhSachSV;
                CustomizeDataGridView();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                string maSV = dgvSinhVien.SelectedRows[0].Cells["MaSV"].Value.ToString();
                var svXoa = danhSachSV.Find(sv => sv.MaSV == maSV);

                if (svXoa != null)
                {
                    danhSachSV.Remove(svXoa);
                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.DataSource = danhSachSV;
                    CustomizeDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!");
            }
        }
    }
}
