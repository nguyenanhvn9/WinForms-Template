namespace Bai2
{
    partial class frmRadioButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbTinhTrangHonNhan = new GroupBox();
            rbLyHon = new RadioButton();
            rbCoGiaDinh = new RadioButton();
            rbDocThan = new RadioButton();
            grbGioiTinh = new GroupBox();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            btnXem = new Button();
            grbTinhTrangHonNhan.SuspendLayout();
            grbGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // grbTinhTrangHonNhan
            // 
            grbTinhTrangHonNhan.Controls.Add(rbLyHon);
            grbTinhTrangHonNhan.Controls.Add(rbCoGiaDinh);
            grbTinhTrangHonNhan.Controls.Add(rbDocThan);
            grbTinhTrangHonNhan.Location = new Point(71, 31);
            grbTinhTrangHonNhan.Name = "grbTinhTrangHonNhan";
            grbTinhTrangHonNhan.Size = new Size(522, 181);
            grbTinhTrangHonNhan.TabIndex = 0;
            grbTinhTrangHonNhan.TabStop = false;
            grbTinhTrangHonNhan.Text = "Tình trạng hôn nhân";
            // 
            // rbLyHon
            // 
            rbLyHon.AutoSize = true;
            rbLyHon.Location = new Point(28, 118);
            rbLyHon.Name = "rbLyHon";
            rbLyHon.Size = new Size(72, 24);
            rbLyHon.TabIndex = 2;
            rbLyHon.TabStop = true;
            rbLyHon.Text = "Ly hôn";
            rbLyHon.UseVisualStyleBackColor = true;
            // 
            // rbCoGiaDinh
            // 
            rbCoGiaDinh.AutoSize = true;
            rbCoGiaDinh.Location = new Point(28, 70);
            rbCoGiaDinh.Name = "rbCoGiaDinh";
            rbCoGiaDinh.Size = new Size(106, 24);
            rbCoGiaDinh.TabIndex = 1;
            rbCoGiaDinh.TabStop = true;
            rbCoGiaDinh.Text = "Có gia đình";
            rbCoGiaDinh.UseVisualStyleBackColor = true;
            // 
            // rbDocThan
            // 
            rbDocThan.AutoSize = true;
            rbDocThan.Location = new Point(28, 26);
            rbDocThan.Name = "rbDocThan";
            rbDocThan.Size = new Size(90, 24);
            rbDocThan.TabIndex = 0;
            rbDocThan.TabStop = true;
            rbDocThan.Text = "Độc thân";
            rbDocThan.UseVisualStyleBackColor = true;
            // 
            // grbGioiTinh
            // 
            grbGioiTinh.Controls.Add(rbNu);
            grbGioiTinh.Controls.Add(rbNam);
            grbGioiTinh.Location = new Point(79, 256);
            grbGioiTinh.Name = "grbGioiTinh";
            grbGioiTinh.Size = new Size(514, 134);
            grbGioiTinh.TabIndex = 1;
            grbGioiTinh.TabStop = false;
            grbGioiTinh.Text = "Giới Tính";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(39, 77);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 1;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(39, 36);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(481, 418);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.TabIndex = 2;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // frmRadioButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(btnXem);
            Controls.Add(grbGioiTinh);
            Controls.Add(grbTinhTrangHonNhan);
            Name = "frmRadioButton";
            Text = "frmRadioButton";
            grbTinhTrangHonNhan.ResumeLayout(false);
            grbTinhTrangHonNhan.PerformLayout();
            grbGioiTinh.ResumeLayout(false);
            grbGioiTinh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTinhTrangHonNhan;
        private GroupBox grbGioiTinh;
        private RadioButton rbLyHon;
        private RadioButton rbCoGiaDinh;
        private RadioButton rbDocThan;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Button btnXem;
    }
}