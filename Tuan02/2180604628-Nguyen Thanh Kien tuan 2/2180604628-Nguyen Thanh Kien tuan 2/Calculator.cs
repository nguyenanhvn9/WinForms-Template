using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180604628_Nguyen_Thanh_Kien_tuan_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculator(object sender, EventArgs e)
        {

        }

        private void btnEight(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btnSeven(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btnCE(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnClear(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            // Nếu bạn có biến lưu phép toán như operand1, operand2 thì cũng reset ở đây:
            result = 0;
            currentOperator = "";
        }

        private void btnBackspace(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void btnOne(object sender, EventArgs e)
        {

        }

        private void btnPercent(object sender, EventArgs e)
        {

        }

        private void btnReciprocal(object sender, EventArgs e)
        {

        }

        private void btnSquare(object sender, EventArgs e)
        {

        }

        private void btnSqrt(object sender, EventArgs e)
        {

        }

        private void btnDivide(object sender, EventArgs e)
        {

        }

        private void btnNine(object sender, EventArgs e)
        {

        }

        private void btnFour(object sender, EventArgs e)
        {

        }
    }
}
