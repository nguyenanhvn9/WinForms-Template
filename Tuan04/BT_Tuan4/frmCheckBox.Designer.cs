namespace Bai2
{
    partial class frmCheckBox
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
            chkSoThich = new CheckedListBox();
            label1 = new Label();
            btnXem = new Button();
            SuspendLayout();
            // 
            // chkSoThich
            // 
            chkSoThich.FormattingEnabled = true;
            chkSoThich.Items.AddRange(new object[] { "Câu Cá", "Đi Bộ", "Thể Dục", "Bóng Đá", "Cầu Lông" });
            chkSoThich.Location = new Point(53, 121);
            chkSoThich.Name = "chkSoThich";
            chkSoThich.Size = new Size(214, 136);
            chkSoThich.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Sở thích";
            // 
            // btnXem
            // 
            btnXem.Location = new Point(333, 325);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.TabIndex = 2;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // frmCheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXem);
            Controls.Add(label1);
            Controls.Add(chkSoThich);
            Name = "frmCheckBox";
            Text = "frmCheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chkSoThich;
        private Label label1;
        private Button btnXem;
    }
}