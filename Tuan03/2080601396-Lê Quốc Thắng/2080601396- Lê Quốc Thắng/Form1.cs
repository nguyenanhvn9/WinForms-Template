using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _2080601396__Lê_Quốc_Thắng
{
    public partial class Form1 : Form
    {
        private Button firstButton = null;
        private Button secondButton = null;
        private int score = 0;
        private List<string> images = new List<string>();
        private Dictionary<Button, string> buttonImages = new Dictionary<Button, string>();
        private Button button2;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void InitializeGame()
        {
            // Tạo danh sách hình (dùng chuỗi, có thể thay bằng hình ảnh thật)
            images.AddRange(new[] { "Hinh1", "Hinh2", "Hinh3", "Hinh4", "Hinh5", "Hinh6" });
            images.AddRange(images); // Tạo cặp

            // Trộn hình ngẫu nhiên
            Random rand = new Random();
            images = images.OrderBy(x => rand.Next()).ToList();

            // Lấy danh sách button đúng tên Designer
            var buttons = new[] { Hinh1, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 };

            // Gán hình cho từng button
            for (int i = 0; i < buttons.Length; i++)
            {
                buttonImages[buttons[i]] = images[i];
                buttons[i].Text = ""; // Ẩn tên hình
                buttons[i].Enabled = true;
                buttons[i].Click -= button1_Click; // Đảm bảo không bị double event
                buttons[i].Click += Button_Click;
            }

           
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.Text != "") return; // Đã mở rồi

            btn.Text = buttonImages[btn]; // Hiện tên hình

            if (firstButton == null)
            {
                firstButton = btn;
                return;
            }

            secondButton = btn;

            // Kiểm tra trùng nhau
            if (buttonImages[firstButton] == buttonImages[secondButton])
            {
                score++;
                firstButton.Enabled = false;
                secondButton.Enabled = false;
                firstButton = null;
                secondButton = null;
            }
            else
            {
                // Ẩn lại sau 1 giây
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += (s, args) =>
                {
                    firstButton.Text = "";
                    secondButton.Text = "";
                    firstButton = null;
                    secondButton = null;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        // Các event mặc định
        private void Form1_Shown(object sender, EventArgs e) { }
        private void Form1_StyleChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}