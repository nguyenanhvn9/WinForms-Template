namespace Bai2
{
    partial class frmListBox
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
            listMustilSimple = new ListBox();
            listSimple = new ListBox();
            listMutilExtended = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Simple";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 213);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "MustilSimple";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 358);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "MultiExtended";
            // 
            // listMustilSimple
            // 
            listMustilSimple.FormattingEnabled = true;
            listMustilSimple.Items.AddRange(new object[] { "January", "February", "March", "April", "May" });
            listMustilSimple.Location = new Point(229, 213);
            listMustilSimple.Name = "listMustilSimple";
            listMustilSimple.SelectionMode = SelectionMode.MultiSimple;
            listMustilSimple.Size = new Size(494, 104);
            listMustilSimple.TabIndex = 4;
            // 
            // listSimple
            // 
            listSimple.FormattingEnabled = true;
            listSimple.Items.AddRange(new object[] { "January", "February", "March", "April", "May" });
            listSimple.Location = new Point(229, 68);
            listSimple.Name = "listSimple";
            listSimple.Size = new Size(494, 104);
            listSimple.TabIndex = 4;
            // 
            // listMutilExtended
            // 
            listMutilExtended.FormattingEnabled = true;
            listMutilExtended.Items.AddRange(new object[] { "January", "February", "March", "April", "May" });
            listMutilExtended.Location = new Point(229, 358);
            listMutilExtended.Name = "listMutilExtended";
            listMutilExtended.SelectionMode = SelectionMode.MultiExtended;
            listMutilExtended.Size = new Size(494, 104);
            listMutilExtended.TabIndex = 4;
            // 
            // frmListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(listSimple);
            Controls.Add(listMutilExtended);
            Controls.Add(listMustilSimple);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmListBox";
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listMustilSimple;
        private ListBox listSimple;
        private ListBox listMutilExtended;
    }
}