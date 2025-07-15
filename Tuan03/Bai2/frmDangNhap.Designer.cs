namespace Bai2
{
    partial class frmDangNhap
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnForgotPassword = new Button();
            btnLogin = new Button();
            btnExit = new Button();
            txtEmaiID = new TextBox();
            txtPassword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmaiID);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnForgotPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(55, 85);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Email ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(55, 118);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(63, 217);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(137, 44);
            btnForgotPassword.TabIndex = 2;
            btnForgotPassword.Text = "Forgot Password";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(339, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(490, 217);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 44);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtEmaiID
            // 
            txtEmaiID.Location = new Point(247, 78);
            txtEmaiID.Name = "txtEmaiID";
            txtEmaiID.Size = new Size(352, 27);
            txtEmaiID.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(247, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 5;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtEmaiID;
        private Button btnExit;
        private Button btnLogin;
        private Button btnForgotPassword;
        private Label label2;
        private Label label1;
    }
}