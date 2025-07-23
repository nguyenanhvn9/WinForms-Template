namespace QLSinhVien_ADONET
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLop;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaiDuLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaForm;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSinhVien;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();

            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaiDuLieu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaForm = new System.Windows.Forms.Button();

            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // groupBox1 - Thông tin sinh viên
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(500, 130);
            this.groupBox1.Text = "Thông tin Sinh viên";

            // Mã SV
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.Text = "Mã sinh viên:";
            this.txtMaSV.Location = new System.Drawing.Point(100, 22);
            this.txtMaSV.Size = new System.Drawing.Size(150, 23);

            // Họ tên
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.Text = "Họ tên:";
            this.txtHoTen.Location = new System.Drawing.Point(100, 57);
            this.txtHoTen.Size = new System.Drawing.Size(380, 23);

            // Ngày sinh
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.Text = "Ngày sinh:";
            this.dtpNgaySinh.Location = new System.Drawing.Point(100, 92);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);

            // Lớp
            this.label4.Location = new System.Drawing.Point(310, 95);
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.Text = "Lớp:";
            this.txtLop.Location = new System.Drawing.Point(350, 92);
            this.txtLop.Size = new System.Drawing.Size(130, 23);

            // groupBox2 - Thao tác
            this.groupBox2.Controls.Add(this.btnTaiDuLieu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnXoaForm);
            this.groupBox2.Location = new System.Drawing.Point(530, 12);
            this.groupBox2.Size = new System.Drawing.Size(240, 130);
            this.groupBox2.Text = "Thao tác";

            this.btnTaiDuLieu.Text = "Tải dữ liệu";
            this.btnTaiDuLieu.Location = new System.Drawing.Point(20, 20);
            this.btnTaiDuLieu.Size = new System.Drawing.Size(200, 23);
            this.btnTaiDuLieu.Click += new System.EventHandler(this.btnTaiDuLieu_Click);

            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(20, 45);
            this.btnThem.Size = new System.Drawing.Size(95, 23);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(125, 45);
            this.btnSua.Size = new System.Drawing.Size(95, 23);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(20, 75);
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnXoaForm.Text = "Xóa form";
            this.btnXoaForm.Location = new System.Drawing.Point(125, 75);
            this.btnXoaForm.Size = new System.Drawing.Size(95, 23);
            this.btnXoaForm.Click += new System.EventHandler(this.btnXoaForm_Click);

            // groupBox3 - Danh sách
            this.groupBox3.Controls.Add(this.dgvSinhVien);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Size = new System.Drawing.Size(760, 250);
            this.groupBox3.Text = "Danh sách Sinh viên";

            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);

            // statusStrip
            this.statusStrip1.Items.Add(this.lblStatus);
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);

            this.lblStatus.Text = "Sẵn sàng";

            // Form1
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Quản lý Sinh viên - ADO.NET";
            this.Load += new System.EventHandler(this.btnTaiDuLieu_Click); // tự load dữ liệu khi mở form

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
