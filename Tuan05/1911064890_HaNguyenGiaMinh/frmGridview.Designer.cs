namespace _1911064890_HaNguyenGiaMinh
{
    partial class frmGridview
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            clmFristName = new DataGridViewTextBoxColumn();
            clmLastName = new DataGridViewTextBoxColumn();
            clmStudentCode = new DataGridViewTextBoxColumn();
            clmAge = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 50);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "FirstName ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 90);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "LastName ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 148);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Student Code ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 195);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Age ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(457, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(457, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(457, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(457, 27);
            textBox4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmFristName, clmLastName, clmStudentCode, clmAge });
            dataGridView1.Location = new Point(0, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 202);
            dataGridView1.TabIndex = 5;
            // 
            // clmFristName
            // 
            clmFristName.DataPropertyName = "fristName";
            clmFristName.HeaderText = "First Name ";
            clmFristName.MinimumWidth = 6;
            clmFristName.Name = "clmFristName";
            clmFristName.Width = 125;
            // 
            // clmLastName
            // 
            clmLastName.HeaderText = "Last Name ";
            clmLastName.MinimumWidth = 6;
            clmLastName.Name = "clmLastName";
            clmLastName.Width = 125;
            // 
            // clmStudentCode
            // 
            clmStudentCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmStudentCode.HeaderText = "Student Code ";
            clmStudentCode.MinimumWidth = 6;
            clmStudentCode.Name = "clmStudentCode";
            // 
            // clmAge
            // 
            clmAge.HeaderText = "Age";
            clmAge.MinimumWidth = 6;
            clmAge.Name = "clmAge";
            clmAge.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(694, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 52);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.button1_Click;
            // 
            // frmGridview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGridview";
            Text = "Gridview";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmFristName;
        private DataGridViewTextBoxColumn clmLastName;
        private DataGridViewTextBoxColumn clmStudentCode;
        private DataGridViewTextBoxColumn clmAge;
        private Button btnAdd;
    }
}
