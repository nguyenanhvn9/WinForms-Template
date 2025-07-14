namespace Bai_2
{
    partial class frmLogin
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(83, 40);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 0;
            label2.Text = "Email ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(83, 104);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 236);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 2;
            button1.Text = "Forgot Password ?";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(360, 236);
            button2.Name = "button2";
            button2.Size = new Size(87, 40);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(453, 236);
            button3.Name = "button3";
            button3.Size = new Size(87, 40);
            button3.TabIndex = 2;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(128, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(737, 394);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 614);
            Controls.Add(groupBox1);
            Name = "frmLogin";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
    }
}