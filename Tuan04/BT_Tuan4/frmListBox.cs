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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
            // Tạo dữ liệu mẫu
            string[] months = { "January", "February", "March", "April", "May" };

            // ListBox Simple
            listSimple.Items.AddRange(months);
            listSimple.SelectionMode = SelectionMode.One;

            // ListBox MultiSimple
            listMustilSimple.Items.AddRange(months);
            listMustilSimple.SelectionMode = SelectionMode.MultiSimple;

            // ListBox MultiExtended
            listMutilExtended.Items.AddRange(months);
            listMutilExtended.SelectionMode = SelectionMode.MultiExtended;

        }
    }
}
