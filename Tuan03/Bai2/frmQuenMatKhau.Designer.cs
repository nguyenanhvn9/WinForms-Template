namespace Bai2
{
    partial class frmQuenMatKhau
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
            label1 = new Label();
            btnKPMK = new Button();
            txtRegisteredEmail = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(110, 41);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter registered Email:";
            // 
            // btnKPMK
            // 
            btnKPMK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKPMK.Location = new Point(110, 163);
            btnKPMK.Name = "btnKPMK";
            btnKPMK.Size = new Size(220, 45);
            btnKPMK.TabIndex = 1;
            btnKPMK.Text = "ForgotPassword";
            btnKPMK.UseVisualStyleBackColor = true;
            btnKPMK.Click += btnKPMK_Click;
            // 
            // txtRegisteredEmail
            // 
            txtRegisteredEmail.Location = new Point(110, 98);
            txtRegisteredEmail.Name = "txtRegisteredEmail";
            txtRegisteredEmail.Size = new Size(439, 27);
            txtRegisteredEmail.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.Location = new Point(396, 163);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 284);
            Controls.Add(btnExit);
            Controls.Add(txtRegisteredEmail);
            Controls.Add(btnKPMK);
            Controls.Add(label1);
            Name = "frmQuenMatKhau";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnKPMK;
        private TextBox txtRegisteredEmail;
        private Button btnExit;
    }
}