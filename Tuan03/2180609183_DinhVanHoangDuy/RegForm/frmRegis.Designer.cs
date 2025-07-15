namespace RegForm
{
    partial class frmRegis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtAddress = new TextBox();
            txtMobile = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnExit = new Button();
            btnReg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(153, 21);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 81);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Firstname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(48, 113);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Lastname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(48, 145);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 1;
            label4.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(48, 177);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 1;
            label5.Text = "Mobile No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(48, 209);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 1;
            label6.Text = "Username :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(48, 241);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 1;
            label7.Text = "Password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(48, 273);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 1;
            label8.Text = "Email Address :";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(230, 84);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(317, 27);
            txtFirstname.TabIndex = 0;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(230, 117);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(317, 27);
            txtLastname.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(230, 149);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(317, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(230, 180);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(317, 27);
            txtMobile.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(230, 213);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(317, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(317, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(230, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 27);
            txtEmail.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(425, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReg
            // 
            btnReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReg.Location = new Point(112, 329);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(94, 29);
            btnReg.TabIndex = 7;
            btnReg.Text = "Save";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // frmRegis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 381);
            Controls.Add(btnReg);
            Controls.Add(btnExit);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegis";
            Text = "Registration Form";
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
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtAddress;
        private TextBox txtMobile;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnExit;
        private Button btnReg;
    }
}
