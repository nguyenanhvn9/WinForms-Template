using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmComBobox : Form
    {
        public frmComBobox()
        {
            InitializeComponent();
        }

        string[] days_one = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        string[] days_two = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        string[] days_three = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        string[] days_four = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] years = { "2020", "2021", "2022", "2023", "2024", "2025" };
        string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        private void frmComBobox_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu vào các ComboBox
            cboSimple.Items.AddRange(days_one);
            cboDropDown.Items.AddRange(days_two); 
            cboDropdownList.Items.AddRange(days_three);
            cboAutoComplete.Items.AddRange(days_four);

            // Thiết lập kiểu ComboBox
            cboSimple.DropDownStyle = ComboBoxStyle.Simple;
            cboDropDown.DropDownStyle = ComboBoxStyle.DropDown;
            cboDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutoComplete.DropDownStyle = ComboBoxStyle.DropDown;
            cboAutoComplete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAutoComplete.AutoCompleteSource = AutoCompleteSource.ListItems;
            // Xử lý sự kiện gợi ý cho ComboBox
            cboAutoComplete.AutoCompleteCustomSource.AddRange(months);
            cboAutoComplete.AutoCompleteCustomSource.AddRange(years);
            cboAutoComplete.AutoCompleteCustomSource.AddRange(numbers);
            // Thiết lập giá trị mặc định cho ComboBox
            cboSimple.SelectedIndex = 0;
            cboDropDown.SelectedIndex = 0;
            cboDropdownList.SelectedIndex = 0;
            cboAutoComplete.SelectedIndex = 0;
            // Hiển thị thông báo
            MessageBox.Show("ComboBox đã được nạp dữ liệu và thiết lập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
