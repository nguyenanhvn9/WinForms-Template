using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DataGridView
{
    public partial class frmDataGridView : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();


        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void frmDataGridView_Load(object sender, EventArgs e)
        {
            danhSachSV.Add(new SinhVien { MaSV = "SV001", HoTen = "Nguyễn Văn An", NgaySinh = new DateTime(2003, 1, 15), DiemTB = 8.5 });
            danhSachSV.Add(new SinhVien { MaSV = "SV002", HoTen = "Trần Thị Bình", NgaySinh = new DateTime(2003, 5, 20), DiemTB = 7.9 });
            danhSachSV.Add(new SinhVien { MaSV = "SV003", HoTen = "Lê Văn Cường", NgaySinh = new DateTime(2003, 9, 10), DiemTB = 9.1 });

            LoadDataGridView();

        }

        private void CustomizeDataGridView()
        {
            dgvSinhVien.Columns.Clear();

            dgvSinhVien.Columns.Add("colMaSV", "Mã Sinh Viên");
            dgvSinhVien.Columns.Add("colHoTen", "Họ và Tên");
            dgvSinhVien.Columns.Add("colNgaySinh", "Ngày Sinh");
            dgvSinhVien.Columns.Add("colDiemTB", "Điểm TB");

            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void LoadDataGridView()
        {
            dgvSinhVien.Rows.Clear();

            foreach (SinhVien sv in danhSachSV)
            {
                dgvSinhVien.Rows.Add(sv.MaSV, sv.HoTen, sv.NgaySinh.ToString("dd/MM/yyyy"), sv.DiemTB);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diemStr = txtDiemTB.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (danhSachSV.Any(s => s.MaSV == maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.");
                return;
            }

            if (!double.TryParse(diemStr, out double diem))
            {
                MessageBox.Show("Điểm phải là số hợp lệ.");
                return;
            }

            SinhVien sv = new SinhVien
            {
                MaSV = maSV,
                HoTen = hoTen,
                NgaySinh = dtpNgaySinh.Value,
                DiemTB = diem
            };

            danhSachSV.Add(sv);
            LoadDataGridView();




        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            SinhVien sv = danhSachSV.Find(s => s.MaSV == maSV);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa.");
                return;
            }

            sv.HoTen = txtHoTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            if (double.TryParse(txtDiemTB.Text.Trim(), out double diem))
            {
                sv.DiemTB = diem;
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Điểm phải là số hợp lệ.");
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                string maSV = dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString();
                SinhVien sv = danhSachSV.Find(s => s.MaSV == maSV);

                if (sv != null)
                {
                    danhSachSV.Remove(sv);
                    LoadDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
            }




        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtDiemTB.Text = dgvSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }


        }
    }
    }
