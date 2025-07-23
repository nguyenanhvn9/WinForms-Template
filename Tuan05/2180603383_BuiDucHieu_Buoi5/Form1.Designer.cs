namespace _2180603383_BuiDucHieu_Buoi5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSinhVien;

        private void InitializeComponent()
        {
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();

            // Label Mã SV
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblMaSV.Location = new System.Drawing.Point(20, 20);

            // TextBox Mã SV
            this.txtMaSV.Location = new System.Drawing.Point(120, 20);
            this.txtMaSV.Width = 200;

            // Label Họ tên
            this.lblHoTen.Text = "Họ và Tên";
            this.lblHoTen.Location = new System.Drawing.Point(20, 60);

            // TextBox Họ tên
            this.txtHoTen.Location = new System.Drawing.Point(120, 60);
            this.txtHoTen.Width = 200;

            // Label Ngày sinh
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 100);

            // DateTimePicker
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 100);
            this.dtpNgaySinh.Width = 200;

            // Label Điểm TB
            this.lblDiemTB.Text = "Điểm TB";
            this.lblDiemTB.Location = new System.Drawing.Point(20, 140);

            // TextBox Điểm TB
            this.txtDiemTB.Location = new System.Drawing.Point(120, 140);
            this.txtDiemTB.Width = 200;

            // Button Thêm
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(20, 180);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // Button Sửa
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(120, 180);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // Button Xóa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(220, 180);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // DataGridView
            this.dgvSinhVien.Location = new System.Drawing.Point(20, 220);
            this.dgvSinhVien.Size = new System.Drawing.Size(500, 200);
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblDiemTB);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvSinhVien);
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
