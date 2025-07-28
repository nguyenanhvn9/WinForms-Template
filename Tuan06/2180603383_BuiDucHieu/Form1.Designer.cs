using System;
using System.Windows.Forms;

namespace ProductDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtSearch;
        private ComboBox cbCategory;
        private NumericUpDown numFrom;
        private NumericUpDown numTo;
        private CheckBox chkInStock;
        private Button btnFilter;
        private Button btnReset;
        private DataGridView dgvProducts;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSearch = new TextBox();
            this.cbCategory = new ComboBox();
            this.numFrom = new NumericUpDown();
            this.numTo = new NumericUpDown();
            this.chkInStock = new CheckBox();
            this.btnFilter = new Button();
            this.btnReset = new Button();
            this.dgvProducts = new DataGridView();
            this.statusStrip1 = new StatusStrip();
            this.lblStatus = new ToolStripStatusLabel();

            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Size = new System.Drawing.Size(200, 23);

            // cbCategory
            this.cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCategory.Location = new System.Drawing.Point(230, 12);
            this.cbCategory.Size = new System.Drawing.Size(150, 23);

            // numFrom
            this.numFrom.Location = new System.Drawing.Point(400, 12);
            this.numFrom.Maximum = 100000;

            // numTo
            this.numTo.Location = new System.Drawing.Point(490, 12);
            this.numTo.Maximum = 100000;

            // chkInStock
            this.chkInStock.AutoSize = true;
            this.chkInStock.Location = new System.Drawing.Point(590, 14);
            this.chkInStock.Text = "Chỉ hiện sản phẩm còn hàng";

            // btnFilter
            this.btnFilter.Location = new System.Drawing.Point(750, 10);
            this.btnFilter.Size = new System.Drawing.Size(90, 25);
            this.btnFilter.Text = "Lọc kết quả";
            this.btnFilter.Click += new EventHandler(this.btnFilter_Click);

            // btnReset
            this.btnReset.Location = new System.Drawing.Point(850, 10);
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.Text = "Xóa bộ lọc";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);

            // dgvProducts
            this.dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvProducts.Location = new System.Drawing.Point(12, 50);
            this.dgvProducts.Size = new System.Drawing.Size(928, 360);
            this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // statusStrip1
            this.statusStrip1.Items.Add(this.lblStatus);
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);

            // lblStatus
            this.lblStatus.Text = "Đã tìm thấy 0 sản phẩm.";

            // Form1
            this.ClientSize = new System.Drawing.Size(952, 442);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.numFrom);
            this.Controls.Add(this.numTo);
            this.Controls.Add(this.chkInStock);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Product Dashboard";
            this.Load += new EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
