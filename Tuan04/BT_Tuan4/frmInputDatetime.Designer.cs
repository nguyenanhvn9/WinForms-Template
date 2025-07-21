namespace Bai2
{
    partial class frmInputDataTime
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
            btnXem = new Button();
            label1 = new Label();
            maskedTextBox_Time = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnXem
            // 
            btnXem.Location = new Point(435, 216);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.TabIndex = 5;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 102);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 4;
            label1.Text = "Input Date:";
            // 
            // maskedTextBox_Time
            // 
            maskedTextBox_Time.Location = new Point(244, 101);
            maskedTextBox_Time.Mask = "00/00/0000";
            maskedTextBox_Time.Name = "maskedTextBox_Time";
            maskedTextBox_Time.Size = new Size(125, 27);
            maskedTextBox_Time.TabIndex = 3;
            maskedTextBox_Time.ValidatingType = typeof(DateTime);
            // 
            // frmInputDataTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXem);
            Controls.Add(label1);
            Controls.Add(maskedTextBox_Time);
            Name = "frmInputDataTime";
            Text = "Input_Datetime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXem;
        private Label label1;
        private MaskedTextBox maskedTextBox_Time;
    }
}