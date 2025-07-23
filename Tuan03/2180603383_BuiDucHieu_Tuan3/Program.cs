using _2180603383_BuiDucHieu_Tuan3.Tuan3_Bai2;
using System;
using System.Windows.Forms;
using Tuan3_Bai2;


namespace _2180603383_BuiDucHieu_Tuan3
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form()); // Gọi Form1, không phải Form (trống)
        }
    }

   
}