namespace StudentManagementSystem
{
    partial class frmStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
            panel_TieuDe = new Panel();
            label1 = new Label();
            panel_Main = new Panel();
            gbxInsertData = new GroupBox();
            btnSelectOperation = new Button();
            btnAddStudent = new Button();
            txtGpa = new TextBox();
            txtDegree = new TextBox();
            txtStudentName = new TextBox();
            txtRollNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel_TieuDe.SuspendLayout();
            panel_Main.SuspendLayout();
            gbxInsertData.SuspendLayout();
            SuspendLayout();
            // 
            // panel_TieuDe
            // 
            panel_TieuDe.BackColor = Color.Aqua;
            panel_TieuDe.Controls.Add(label1);
            panel_TieuDe.Dock = DockStyle.Top;
            panel_TieuDe.Location = new Point(0, 0);
            panel_TieuDe.Name = "panel_TieuDe";
            panel_TieuDe.Size = new Size(1112, 108);
            panel_TieuDe.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 30);
            label1.Name = "label1";
            label1.Size = new Size(571, 48);
            label1.TabIndex = 0;
            label1.Text = "Student Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Main
            // 
            panel_Main.BackColor = Color.White;
            panel_Main.Controls.Add(gbxInsertData);
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.ForeColor = Color.Black;
            panel_Main.Location = new Point(0, 108);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1112, 504);
            panel_Main.TabIndex = 1;
            // 
            // gbxInsertData
            // 
            gbxInsertData.BackColor = Color.WhiteSmoke;
            gbxInsertData.Controls.Add(btnSelectOperation);
            gbxInsertData.Controls.Add(btnAddStudent);
            gbxInsertData.Controls.Add(txtGpa);
            gbxInsertData.Controls.Add(txtDegree);
            gbxInsertData.Controls.Add(txtStudentName);
            gbxInsertData.Controls.Add(txtRollNo);
            gbxInsertData.Controls.Add(label5);
            gbxInsertData.Controls.Add(label4);
            gbxInsertData.Controls.Add(label6);
            gbxInsertData.Controls.Add(label3);
            gbxInsertData.Controls.Add(label2);
            gbxInsertData.Location = new Point(216, 68);
            gbxInsertData.Name = "gbxInsertData";
            gbxInsertData.Size = new Size(680, 369);
            gbxInsertData.TabIndex = 0;
            gbxInsertData.TabStop = false;
            // 
            // btnSelectOperation
            // 
            btnSelectOperation.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSelectOperation.Location = new Point(225, 308);
            btnSelectOperation.Name = "btnSelectOperation";
            btnSelectOperation.Size = new Size(243, 38);
            btnSelectOperation.TabIndex = 4;
            btnSelectOperation.Text = "Select Operation";
            btnSelectOperation.UseVisualStyleBackColor = true;
            btnSelectOperation.Click += btnSelectOperation_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveCaption;
            btnAddStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAddStudent.Location = new Point(283, 263);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(143, 39);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(372, 198);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(197, 30);
            txtGpa.TabIndex = 2;
            // 
            // txtDegree
            // 
            txtDegree.Location = new Point(372, 161);
            txtDegree.Name = "txtDegree";
            txtDegree.Size = new Size(197, 30);
            txtDegree.TabIndex = 2;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(372, 124);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(197, 30);
            txtStudentName.TabIndex = 2;
            // 
            // txtRollNo
            // 
            txtRollNo.Location = new Point(372, 87);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.Size = new Size(197, 30);
            txtRollNo.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(114, 164);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 1;
            label5.Text = "Degree:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(114, 127);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 1;
            label4.Text = "Student Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(114, 201);
            label6.Name = "label6";
            label6.Size = new Size(219, 23);
            label6.TabIndex = 1;
            label6.Text = "Aggregate GPA (Out of 10):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(114, 90);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 1;
            label3.Text = "Student RollNo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 26);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 0;
            label2.Text = "INSERT DATA";
            // 
            // frmStudentManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 612);
            Controls.Add(panel_Main);
            Controls.Add(panel_TieuDe);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmStudentManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management System";
            panel_TieuDe.ResumeLayout(false);
            panel_TieuDe.PerformLayout();
            panel_Main.ResumeLayout(false);
            gbxInsertData.ResumeLayout(false);
            gbxInsertData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_TieuDe;
        private Panel panel_Main;
        private Label label1;
        private GroupBox gbxInsertData;
        private Label label2;
        private TextBox txtGpa;
        private TextBox txtDegree;
        private TextBox txtStudentName;
        private TextBox txtRollNo;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Button btnAddStudent;
        private Button btnSelectOperation;
    }
}