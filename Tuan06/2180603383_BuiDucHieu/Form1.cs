using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductDashboard
{
    public partial class Form1 : Form
    {
        List<Product> productList = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            // Giả lập Placeholder cho .NET Framework
            txtSearch.Text = "Tìm kiếm...";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == "Tìm kiếm...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };

            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Tìm kiếm...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu
            productList = new List<Product>
            {
                new Product { ID = 1, Name = "iPhone 15", Category = "Điện thoại", Price = 25000, Stock = 10 },
                new Product { ID = 2, Name = "Samsung A52", Category = "Điện thoại", Price = 12000, Stock = 8 },
                new Product { ID = 3, Name = "Laptop Dell", Category = "Laptop", Price = 18000, Stock = 5 },
                new Product { ID = 4, Name = "Tủ lạnh LG", Category = "Điện máy", Price = 15000, Stock = 0 },
                new Product { ID = 5, Name = "Bàn phím Logitech", Category = "Phụ kiện", Price = 500, Stock = 50 }
            };

            var categories = productList.Select(p => p.Category).Distinct().ToList();
            categories.Insert(0, "Tất cả");
            cbCategory.DataSource = categories;

            numFrom.Value = 0;
            numTo.Value = 30000;

            LoadData(productList);
        }

        private void LoadData(List<Product> data)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = data;
            lblStatus.Text = $"Đã tìm thấy {data.Count} sản phẩm.";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var query = productList.AsEnumerable();

            if (txtSearch.Text != "Tìm kiếm..." && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query = query.Where(p => p.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (cbCategory.SelectedItem.ToString() != "Tất cả")
            {
                query = query.Where(p => p.Category == cbCategory.SelectedItem.ToString());
            }

            query = query.Where(p => p.Price >= numFrom.Value && p.Price <= numTo.Value);

            if (chkInStock.Checked)
            {
                query = query.Where(p => p.Stock > 0);
            }

            LoadData(query.ToList());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Tìm kiếm...";
            txtSearch.ForeColor = Color.Gray;
            cbCategory.SelectedIndex = 0;
            numFrom.Value = 0;
            numTo.Value = 30000;
            chkInStock.Checked = false;

            LoadData(productList);
        }
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
