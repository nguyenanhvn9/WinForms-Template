namespace Bai2
{
    partial class frmDangKy
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSaVe = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtMobile = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            label1.Location = new Point(247, 18);
            label1.Name = "label1";
            label1.Size = new Size(316, 47);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(30, 96);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 1;
            label2.Text = "FirstName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(121, 31);
            label3.TabIndex = 1;
            label3.Text = "LastName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(30, 156);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 1;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(30, 186);
            label5.Name = "label5";
            label5.Size = new Size(127, 31);
            label5.TabIndex = 1;
            label5.Text = "Mobile No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(30, 216);
            label6.Name = "label6";
            label6.Size = new Size(122, 31);
            label6.TabIndex = 1;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(30, 246);
            label7.Name = "label7";
            label7.Size = new Size(115, 31);
            label7.TabIndex = 1;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F);
            label8.Location = new Point(30, 276);
            label8.Name = "label8";
            label8.Size = new Size(123, 31);
            label8.TabIndex = 1;
            label8.Text = "FirstName:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F);
            label9.Location = new Point(30, 276);
            label9.Name = "label9";
            label9.Size = new Size(164, 31);
            label9.TabIndex = 1;
            label9.Text = "Email Address:";
            // 
            // btnSaVe
            // 
            btnSaVe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnSaVe.Location = new Point(521, 344);
            btnSaVe.Name = "btnSaVe";
            btnSaVe.Size = new Size(103, 45);
            btnSaVe.TabIndex = 2;
            btnSaVe.Text = "Save";
            btnSaVe.UseVisualStyleBackColor = true;
            btnSaVe.Click += btnSaVe_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(258, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(388, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(258, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(388, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(258, 156);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(388, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(258, 186);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(388, 27);
            txtMobile.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(258, 216);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(388, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(258, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(388, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(258, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(388, 27);
            txtEmail.TabIndex = 3;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSaVe);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangKy";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSaVe;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtMobile;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}