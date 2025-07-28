using System;
using System.Windows.Forms;

namespace QLSinhVien_ADO_Disconnected
{
    internal static class Program
    {
        /// <summary>
        /// Điểm khởi đầu chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Bật giao diện đẹp
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Chạy Form1 là form chính
        }
    }
}
