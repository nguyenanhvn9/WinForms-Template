namespace Bai_1
{
    partial class frmRegister
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 54);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Firstname :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Lastname :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 1;
            label4.Text = "Address :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 1;
            label5.Text = "Mobile No. :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 1;
            label6.Text = "Username :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(13, 347);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 1;
            label7.Text = "Password :";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(13, 399);
            label8.Name = "label8";
            label8.Size = new Size(148, 28);
            label8.TabIndex = 1;
            label8.Text = "Email Address : ";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(167, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(536, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(167, 142);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(536, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(167, 193);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(536, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(167, 243);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(536, 27);
            txtPhone.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(167, 295);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(536, 27);
            txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(167, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(536, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 400);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(536, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.Location = new Point(582, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 38);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            Text = "FormRegister";
            Load += Form1_Load_1;
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
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnSave;
    }
}
