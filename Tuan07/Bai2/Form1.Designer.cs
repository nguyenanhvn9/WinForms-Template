using System;
using System.Windows.Forms;

namespace Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBox1;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtLop;

        private GroupBox groupBox2;
        private Button btnTaiDuLieu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnXoaForm;

        private GroupBox groupBox3;
        private DataGridView dgvSinhVien;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.groupBox1 = new GroupBox();
            this.txtMaSV = new TextBox();
            this.txtHoTen = new TextBox();
            this.dtpNgaySinh = new DateTimePicker();
            this.txtLop = new TextBox();

            this.groupBox2 = new GroupBox();
            this.btnTaiDuLieu = new Button();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnCapNhat = new Button();
            this.btnXoaForm = new Button();

            this.groupBox3 = new GroupBox();
            this.dgvSinhVien = new DataGridView();

            this.statusStrip1 = new StatusStrip();
            this.lblStatus = new ToolStripStatusLabel();

            // groupBox1 - Thông tin Sinh viên
            this.groupBox1.Text = "Thông tin Sinh viên";
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(350, 160);

            Label lblMaSV = new Label() { Text = "Mã SV:", Location = new System.Drawing.Point(20, 25) };
            this.txtMaSV.Location = new System.Drawing.Point(100, 20);
            this.txtMaSV.Size = new System.Drawing.Size(220, 25);

            Label lblHoTen = new Label() { Text = "Họ tên:", Location = new System.Drawing.Point(20, 55) };
            this.txtHoTen.Location = new System.Drawing.Point(100, 50);
            this.txtHoTen.Size = new System.Drawing.Size(220, 25);

            Label lblNgaySinh = new Label() { Text = "Ngày sinh:", Location = new System.Drawing.Point(20, 85) };
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 80);
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 25);

            Label lblLop = new Label() { Text = "Lớp:", Location = new System.Drawing.Point(20, 115) };
            this.txtLop.Location = new System.Drawing.Point(100, 110);
            this.txtLop.Size = new System.Drawing.Size(220, 25);

            this.groupBox1.Controls.AddRange(new Control[]
            {
                lblMaSV, txtMaSV,
                lblHoTen, txtHoTen,
                lblNgaySinh, dtpNgaySinh,
                lblLop, txtLop
            });

            // groupBox2 - Thao tác
            this.groupBox2.Text = "Thao tác";
            this.groupBox2.Location = new System.Drawing.Point(380, 12);
            this.groupBox2.Size = new System.Drawing.Size(400, 160);

            this.btnTaiDuLieu.Text = "Tải dữ liệu";
            this.btnThem.Text = "Thêm";
            this.btnSua.Text = "Sửa";
            this.btnXoa.Text = "Xóa";
            this.btnCapNhat.Text = "Cập nhật";
            this.btnXoaForm.Text = "Xóa form";

            this.btnTaiDuLieu.SetBounds(20, 25, 170, 30);
            this.btnThem.SetBounds(20, 60, 170, 30);
            this.btnSua.SetBounds(20, 95, 170, 30);
            this.btnXoa.SetBounds(200, 25, 170, 30);
            this.btnCapNhat.SetBounds(200, 60, 170, 30);
            this.btnXoaForm.SetBounds(200, 95, 170, 30);

            this.groupBox2.Controls.AddRange(new Control[]
            {
                btnTaiDuLieu, btnThem, btnSua, btnXoa, btnCapNhat, btnXoaForm
            });

            // groupBox3 - Danh sách Sinh viên
            this.groupBox3.Text = "Danh sách Sinh viên";
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Size = new System.Drawing.Size(770, 250);

            this.dgvSinhVien.Location = new System.Drawing.Point(10, 20);
            this.dgvSinhVien.Size = new System.Drawing.Size(750, 220);
            this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.groupBox3.Controls.Add(this.dgvSinhVien);

            // statusStrip
            this.statusStrip1.Items.Add(this.lblStatus);
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.lblStatus.Text = "Sẵn sàng";

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.AddRange(new Control[]
            {
                groupBox1, groupBox2, groupBox3, statusStrip1
            });

            this.Text = "Quản lý Sinh viên (Entity Framework)";
            this.Load += (s, e) => { lblStatus.Text = "Sẵn sàng"; };

            // Event handlers
            this.dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            this.btnTaiDuLieu.Click += btnTaiDuLieu_Click;
            this.btnThem.Click += btnThem_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnCapNhat.Click += btnCapNhat_Click;
            this.btnXoaForm.Click += btnXoaForm_Click;
        }
    }
}
