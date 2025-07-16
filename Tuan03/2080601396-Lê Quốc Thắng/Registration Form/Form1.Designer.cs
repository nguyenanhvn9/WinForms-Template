namespace Registration_Form
{
    partial class Form1
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
            btnSave = new Button();
            txtFirstname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtLastname = new TextBox();
            txtAddress = new TextBox();
            txtMobile = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(657, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 69);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(183, 118);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(284, 27);
            txtFirstname.TabIndex = 1;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 42);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Registration Form";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 118);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Firstname: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 170);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Lastname: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 223);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Address: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 273);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Mobile No. :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 323);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 7;
            label6.Text = "Username: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 369);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 8;
            label7.Text = "Password :";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(183, 180);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(284, 27);
            txtLastname.TabIndex = 9;
            txtLastname.TextChanged += txtLastname_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(183, 223);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(284, 27);
            txtAddress.TabIndex = 10;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(183, 273);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(284, 27);
            txtMobile.TabIndex = 11;
            txtMobile.TextChanged += textBox4_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 323);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 27);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += textBox5_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 369);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 27);
            txtPassword.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 421);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 14;
            label8.Text = "Email Adress: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(183, 421);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 753);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(txtLastname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFirstname);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtFirstname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtLastname;
        private TextBox txtAddress;
        private TextBox txtMobile;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtEmail;
    }
}
