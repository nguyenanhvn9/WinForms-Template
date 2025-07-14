namespace Tuan3_Bai2
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
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(251, 35);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 1;
            label1.Text = "Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Firstname:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(170, 104);
            button1.Name = "button1";
            button1.Size = new Size(342, 28);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 150);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Lastname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 187);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 230);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 6;
            label5.Text = "Mobile No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 268);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 7;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 316);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 8;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 361);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 9;
            label8.Text = "Email Address:";
            // 
            // button2
            // 
            button2.Location = new Point(170, 144);
            button2.Name = "button2";
            button2.Size = new Size(348, 32);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 186);
            button3.Name = "button3";
            button3.Size = new Size(345, 28);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(174, 226);
            button4.Name = "button4";
            button4.Size = new Size(345, 28);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(174, 264);
            button5.Name = "button5";
            button5.Size = new Size(345, 28);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(174, 312);
            button6.Name = "button6";
            button6.Size = new Size(345, 28);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(173, 353);
            button7.Name = "button7";
            button7.Size = new Size(345, 28);
            button7.TabIndex = 15;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.DialogResult = DialogResult.OK;
            button8.Location = new Point(556, 398);
            button8.Name = "button8";
            button8.Size = new Size(100, 37);
            button8.TabIndex = 16;
            button8.Text = "SAVE";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
