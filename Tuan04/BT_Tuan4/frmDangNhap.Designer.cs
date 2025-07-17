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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtEmaiID = new TextBox();
            btnExit = new Button();
            btnLogin = new Button();
            btnForgotPassword = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmaiID);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnForgotPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 312);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(684, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 229);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(247, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtEmaiID
            // 
            txtEmaiID.Location = new Point(247, 78);
            txtEmaiID.Name = "txtEmaiID";
            txtEmaiID.Size = new Size(352, 27);
            txtEmaiID.TabIndex = 5;
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
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(1073, 428);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}