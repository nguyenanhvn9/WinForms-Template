using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911064890_HaNguyenGiaMInh
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        // Thêm biến thành viên cho lưu trữ phép toán và giá trị
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        // Giả sử lbl_NoiDung là một Label để hiển thị nội dung, bạn cần khai báo nó nếu chưa có
        // private Label lbl_NoiDung;


        // Xử lý sự kiện cho các nút số
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "0";
            else
                lbl_NoiDung.Text += "0";
            isOperationPerformed = false;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "1";
            else
                lbl_NoiDung.Text += "1";
            isOperationPerformed = false;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "2";
            else
                lbl_NoiDung.Text += "2";
            isOperationPerformed = false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "3";
            else
                lbl_NoiDung.Text += "3";
            isOperationPerformed = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "4";
            else
                lbl_NoiDung.Text += "4";
            isOperationPerformed = false;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "5";
            else
                lbl_NoiDung.Text += "5";
            isOperationPerformed = false;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "6";
            else
                lbl_NoiDung.Text += "6";
            isOperationPerformed = false;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "7";
            else
                lbl_NoiDung.Text += "7";
            isOperationPerformed = false;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "8";
            else
                lbl_NoiDung.Text += "8";
            isOperationPerformed = false;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text == "0" || isOperationPerformed)
                lbl_NoiDung.Text = "9";
            else
                lbl_NoiDung.Text += "9";
            isOperationPerformed = false;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                lbl_NoiDung.Text = "0.";
                isOperationPerformed = false;
            }
            else if (!lbl_NoiDung.Text.Contains("."))
            {
                lbl_NoiDung.Text += ".";
            }
        }

        // các nút phép toán nâng cao
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                number = -number; // Đổi dấu của số
                lbl_NoiDung.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number) && number != 0)
            {
                number = 1 / number; // Tính nghịch đảo
                lbl_NoiDung.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ khác 0.");
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                number = Math.Pow(number, 2); // Tính bình phương
                lbl_NoiDung.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number) && number >= 0)
            {
                number = Math.Sqrt(number); // Tính căn bậc hai
                lbl_NoiDung.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ lớn hơn hoặc bằng 0.");
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                number = number / 100; // Tính phần trăm
                lbl_NoiDung.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        // các phép toán cơ bản
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                if (operation != "")
                {
                    // Nếu đã có phép toán trước đó, thực hiện phép toán
                    PerformCalculation(number);
                }
                else
                {
                    // Lưu giá trị ban đầu
                    result = number;
                }
                operation = "+"; // Cập nhật phép toán
                isOperationPerformed = true; // Đánh dấu đã thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                if (operation != "")
                {
                    // Nếu đã có phép toán trước đó, thực hiện phép toán
                    PerformCalculation(number);
                }
                else
                {
                    // Lưu giá trị ban đầu
                    result = number;
                }
                operation = "-"; // Cập nhật phép toán
                isOperationPerformed = true; // Đánh dấu đã thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                if (operation != "")
                {
                    // Nếu đã có phép toán trước đó, thực hiện phép toán
                    PerformCalculation(number);
                }
                else
                {
                    // Lưu giá trị ban đầu
                    result = number;
                }
                operation = "*"; // Cập nhật phép toán
                isOperationPerformed = true; // Đánh dấu đã thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                if (operation != "")
                {
                    // Nếu đã có phép toán trước đó, thực hiện phép toán
                    PerformCalculation(number);
                }
                else
                {
                    // Lưu giá trị ban đầu
                    result = number;
                }
                operation = "/"; // Cập nhật phép toán
                isOperationPerformed = true; // Đánh dấu đã thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        // các nút chức năng
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lbl_NoiDung.Text.Length > 0)
            {
                lbl_NoiDung.Text = lbl_NoiDung.Text.Substring(0, lbl_NoiDung.Text.Length - 1);
            }
            if (lbl_NoiDung.Text == "")
            {
                lbl_NoiDung.Text = "0"; // Đặt lại về 0 nếu không còn ký tự nào
            }
            isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbl_NoiDung.Text = "0"; // Đặt lại nội dung về 0
            result = 0; // Đặt lại kết quả
            operation = ""; // Xóa phép toán
            isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lbl_NoiDung.Text = "0"; // Đặt lại nội dung về 0
            isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            // Xóa bộ nhớ
            result = 0;
            operation = "";
            isOperationPerformed = false;
            lbl_NoiDung.Text = "0"; // Đặt lại nội dung về 0
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            // Hiển thị giá trị trong bộ nhớ
            lbl_NoiDung.Text = result.ToString();
            isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
        }

        private void btnM_Plus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                result += number; // Cộng giá trị hiện tại vào bộ nhớ
                lbl_NoiDung.Text = result.ToString(); // Hiển thị giá trị trong bộ nhớ
                isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnM_Subtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                result -= number; // Trừ giá trị hiện tại khỏi bộ nhớ
                lbl_NoiDung.Text = result.ToString(); // Hiển thị giá trị trong bộ nhớ
                isOperationPerformed = false; // Đánh dấu chưa thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_NoiDung.Text, out double number))
            {
                PerformCalculation(number); // Thực hiện phép toán với giá trị hiện tại
                operation = ""; // Xóa phép toán sau khi tính toán
                isOperationPerformed = true; // Đánh dấu đã thực hiện phép toán
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void PerformCalculation(double number)
        {
            switch (operation)
            {
                case "+":
                    result += number; // Cộng
                    break;
                case "-":
                    result -= number; // Trừ
                    break;
                case "*":
                    result *= number; // Nhân
                    break;
                case "/":
                    if (number != 0)
                        result /= number; // Chia
                    else
                        MessageBox.Show("Không thể chia cho 0.");
                    break;
                default:
                    result = number; // Nếu không có phép toán, chỉ lưu giá trị
                    break;
            }
            lbl_NoiDung.Text = result.ToString(); // Cập nhật kết quả lên giao diện
        }
    }
}
