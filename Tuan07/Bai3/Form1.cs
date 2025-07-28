using Bai3;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private QuanLySanPhamContext dbContext;

        private SplitContainer splitContainer;
        private ListBox lstDanhMuc;
        private TextBox txtMaDanhMuc, txtTenDanhMuc;
        private Button btnThemDanhMuc, btnSuaDanhMuc, btnXoaDanhMuc;
        private DataGridView dgvSanPham;
        private TextBox txtMaSP, txtTenSP;
        private NumericUpDown nudDonGia, nudSoLuongTon;
        private Button btnThem, btnSua, btnXoa, btnLamMoi;
        private GroupBox grpDanhSachSP, grpChiTietSP;
        private Label lblDanhMuc;

        public Form1()
        {
            InitializeComponent(); // để giữ file Designer (có thể rỗng)
            BuildUI();             // giao diện bằng code
            Load += Form1_Load;
        }

        private void BuildUI()
        {
            this.Text = "Ứng dụng quản lý sản phẩm";
            this.Width = 1000;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            splitContainer = new SplitContainer() { Dock = DockStyle.Fill, SplitterDistance = 300 };

           
        
            this.Text = "Ứng dụng quản lý sản phẩm";
            this.Width = 1000;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

            splitContainer = new SplitContainer() { Dock = DockStyle.Fill, SplitterDistance = 300 };

            // === Panel trái ===
            lblDanhMuc = new Label() { Text = "Danh mục sản phẩm", Dock = DockStyle.Top, Height = 30, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
            lstDanhMuc = new ListBox() { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10) };
            lstDanhMuc.SelectedIndexChanged += LstDanhMuc_SelectedIndexChanged;

            var panelBottom = new Panel() { Dock = DockStyle.Bottom, Height = 120 };

            var lblMaDanhMuc = new Label() { Text = "Mã danh mục", Top = 5, Left = 10, Width = 100 };
            txtMaDanhMuc = new TextBox() { Width = 260, Top = 25, Left = 10, ReadOnly = true };

            var lblTenDanhMuc = new Label() { Text = "Tên danh mục", Top = 50, Left = 10, Width = 100 };
            txtTenDanhMuc = new TextBox() { Width = 260, Top = 70, Left = 10 };

            btnThemDanhMuc = new Button() { Text = "Thêm", Width = 70, Top = 100, Left = 10 };
            btnSuaDanhMuc = new Button() { Text = "Sửa", Width = 70, Top = 100, Left = 90 };
            btnXoaDanhMuc = new Button() { Text = "Xóa", Width = 70, Top = 100, Left = 170 };

            btnThemDanhMuc.Click += BtnThemDanhMuc_Click;
            btnSuaDanhMuc.Click += BtnSuaDanhMuc_Click;
            btnXoaDanhMuc.Click += BtnXoaDanhMuc_Click;

            panelBottom.Controls.AddRange(new Control[] {
        lblMaDanhMuc, txtMaDanhMuc, lblTenDanhMuc, txtTenDanhMuc,
        btnThemDanhMuc, btnSuaDanhMuc, btnXoaDanhMuc
    });

            splitContainer.Panel1.Controls.AddRange(new Control[] { lstDanhMuc, lblDanhMuc, panelBottom });


            // === Panel phải ===
            var tablePanel = new TableLayoutPanel() { Dock = DockStyle.Fill, RowCount = 2 };
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            grpDanhSachSP = new GroupBox() { Text = "Danh sách sản phẩm", Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            dgvSanPham = new DataGridView() { Dock = DockStyle.Fill };
            dgvSanPham.SelectionChanged += DgvSanPham_SelectionChanged;
            grpDanhSachSP.Controls.Add(dgvSanPham);

            grpChiTietSP = new GroupBox() { Text = "Thông tin chi tiết sản phẩm", Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            var panelChiTiet = new Panel() { Dock = DockStyle.Fill };

            var lblMaSP = new Label() { Text = "Mã SP", Top = 10, Left = 20, Width = 100 };
            txtMaSP = new TextBox() { Width = 200, Top = 30, Left = 20, ReadOnly = true };

            var lblTenSP = new Label() { Text = "Tên SP", Top = 60, Left = 20, Width = 100 };
            txtTenSP = new TextBox() { Width = 200, Top = 80, Left = 20 };

            var lblDonGia = new Label() { Text = "Đơn giá", Top = 10, Left = 250, Width = 100 };
            nudDonGia = new NumericUpDown() { Width = 200, Top = 30, Left = 250, Maximum = 100000000 };

            var lblSoLuongTon = new Label() { Text = "Số lượng tồn", Top = 60, Left = 250, Width = 100 };
            nudSoLuongTon = new NumericUpDown() { Width = 200, Top = 80, Left = 250, Maximum = 1000000 };

            btnThem = new Button() { Text = "Thêm", Width = 70, Top = 120, Left = 20 };
            btnSua = new Button() { Text = "Sửa", Width = 70, Top = 120, Left = 100 };
            btnXoa = new Button() { Text = "Xóa", Width = 70, Top = 120, Left = 180 };
            btnLamMoi = new Button() { Text = "Làm mới", Width = 80, Top = 120, Left = 260 };

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;

            panelChiTiet.Controls.AddRange(new Control[] {
        lblMaSP, txtMaSP, lblTenSP, txtTenSP,
        lblDonGia, nudDonGia, lblSoLuongTon, nudSoLuongTon,
        btnThem, btnSua, btnXoa, btnLamMoi
    });

            grpChiTietSP.Controls.Add(panelChiTiet);

            tablePanel.Controls.Add(grpDanhSachSP, 0, 0);
            tablePanel.Controls.Add(grpChiTietSP, 0, 1);
            splitContainer.Panel2.Controls.Add(tablePanel);

            this.Controls.Add(splitContainer);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext = new QuanLySanPhamContext();
            LoadDanhMuc();
        }

        private void LoadDanhMuc()
        {
            var list = dbContext.DanhMucs.ToList();
            lstDanhMuc.DataSource = list;
            lstDanhMuc.DisplayMember = "TenDanhMuc";
            lstDanhMuc.ValueMember = "MaDanhMuc";
        }

        private void LstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedItem is DanhMuc dm)
            {
                txtMaDanhMuc.Text = dm.MaDanhMuc.ToString();
                txtTenDanhMuc.Text = dm.TenDanhMuc;
                dgvSanPham.DataSource = dbContext.SanPhams.Where(sp => sp.MaDanhMuc == dm.MaDanhMuc).ToList();
            }
        }

        private void BtnThemDanhMuc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDanhMuc.Text))
            {
                var dm = new DanhMuc { TenDanhMuc = txtTenDanhMuc.Text };
                dbContext.DanhMucs.Add(dm);
                dbContext.SaveChanges();
                LoadDanhMuc();
            }
        }

        private void BtnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedItem is DanhMuc dm)
            {
                dm.TenDanhMuc = txtTenDanhMuc.Text;
                dbContext.SaveChanges();
                LoadDanhMuc();
            }
        }

        private void BtnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedItem is DanhMuc dm)
            {
                if (dm.SanPhams.Any())
                {
                    MessageBox.Show("Danh mục còn sản phẩm, không thể xóa!");
                    return;
                }
                dbContext.DanhMucs.Remove(dm);
                dbContext.SaveChanges();
                LoadDanhMuc();
            }
        }

        private void DgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPham sp)
            {
                txtMaSP.Text = sp.MaSP.ToString();
                txtTenSP.Text = sp.TenSP;
                nudDonGia.Value = sp.DonGia;
                nudSoLuongTon.Value = sp.SoLuongTon;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedItem is DanhMuc dm)
            {
                var sp = new SanPham
                {
                    TenSP = txtTenSP.Text,
                    DonGia = nudDonGia.Value,
                    SoLuongTon = (int)nudSoLuongTon.Value,
                    MaDanhMuc = dm.MaDanhMuc
                };
                dbContext.SanPhams.Add(sp);
                dbContext.SaveChanges();
                LstDanhMuc_SelectedIndexChanged(null, null);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaSP.Text, out int id))
            {
                var sp = dbContext.SanPhams.Find(id);
                if (sp != null)
                {
                    sp.TenSP = txtTenSP.Text;
                    sp.DonGia = nudDonGia.Value;
                    sp.SoLuongTon = (int)nudSoLuongTon.Value;
                    dbContext.SaveChanges();
                    LstDanhMuc_SelectedIndexChanged(null, null);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaSP.Text, out int id))
            {
                var sp = dbContext.SanPhams.Find(id);
                if (sp != null)
                {
                    dbContext.SanPhams.Remove(sp);
                    dbContext.SaveChanges();
                    LstDanhMuc_SelectedIndexChanged(null, null);
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            nudDonGia.Value = 0;
            nudSoLuongTon.Value = 0;
        }
    }
}
