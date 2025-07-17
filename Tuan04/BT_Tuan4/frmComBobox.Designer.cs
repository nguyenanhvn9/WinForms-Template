namespace Bai2
{
    partial class frmComBobox
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
            cboSimple = new ComboBox();
            cboDropDown = new ComboBox();
            cboAutoComplete = new ComboBox();
            cboDropdownList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboSimple
            // 
            cboSimple.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboSimple.FormattingEnabled = true;
            cboSimple.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Firday", "Staturday" });
            cboSimple.Location = new Point(268, 43);
            cboSimple.Name = "cboSimple";
            cboSimple.Size = new Size(362, 28);
            cboSimple.TabIndex = 0;
            // 
            // cboDropDown
            // 
            cboDropDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDropDown.FormattingEnabled = true;
            cboDropDown.Location = new Point(270, 153);
            cboDropDown.Name = "cboDropDown";
            cboDropDown.Size = new Size(360, 28);
            cboDropDown.TabIndex = 1;
            // 
            // cboAutoComplete
            // 
            cboAutoComplete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboAutoComplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAutoComplete.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboAutoComplete.FormattingEnabled = true;
            cboAutoComplete.Location = new Point(268, 373);
            cboAutoComplete.Name = "cboAutoComplete";
            cboAutoComplete.Size = new Size(362, 28);
            cboAutoComplete.TabIndex = 2;
            // 
            // cboDropdownList
            // 
            cboDropdownList.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDropdownList.Enabled = false;
            cboDropdownList.FormattingEnabled = true;
            cboDropdownList.Location = new Point(270, 263);
            cboDropdownList.Name = "cboDropdownList";
            cboDropdownList.Size = new Size(362, 28);
            cboDropdownList.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(125, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Simple";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(125, 156);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 5;
            label2.Text = "DropDown";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(125, 266);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 6;
            label3.Text = "DropdownList";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(125, 376);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "Auto Complete";
            // 
            // frmComBobox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 445);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboDropdownList);
            Controls.Add(cboAutoComplete);
            Controls.Add(cboDropDown);
            Controls.Add(cboSimple);
            Name = "frmComBobox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComBobox";
            Load += frmComBobox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSimple;
        private ComboBox cboDropDown;
        private ComboBox cboAutoComplete;
        private ComboBox cboDropdownList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}