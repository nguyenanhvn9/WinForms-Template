using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180603383_BuiDucHieu_Tuan3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private PictureBox firstClicked = null;
        private PictureBox secondClicked = null;
        private List<Image> images = new List<Image>();
        private Random random = new Random();

        public Form()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Thêm các cặp hình từ Resources (bạn phải tự thêm img1, img2... vào Resources)
            images.Add(Properties.Resources.img1);
            images.Add(Properties.Resources.img1);
            images.Add(Properties.Resources.img2);
            images.Add(Properties.Resources.img2);
            images.Add(Properties.Resources.img3);
            images.Add(Properties.Resources.img3);
            images.Add(Properties.Resources.img4);
            images.Add(Properties.Resources.img4);
            images.Add(Properties.Resources.img5);
            images.Add(Properties.Resources.img5);
            images.Add(Properties.Resources.img6);
            images.Add(Properties.Resources.img6);
            images.Add(Properties.Resources.img7);
            images.Add(Properties.Resources.img7);
            images.Add(Properties.Resources.img8);
            images.Add(Properties.Resources.img8);

            // Trộn ngẫu nhiên
            var shuffledImages = images.OrderBy(x => random.Next()).ToList();

            int index = 0;

            // Gán tag và sự kiện click cho tất cả PictureBox trên form
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pic)
                {
                    pic.Tag = shuffledImages[index];
                    pic.Image = null; // ban đầu úp xuống
                    pic.Click += PictureBox_Click;
                    index++;
                }
            }
        }

        private async void PictureBox_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return; // Đang đợi úp xuống

            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox.Image != null)
                return; // Đã lật rồi

            clickedBox.Image = (Image)clickedBox.Tag; // Lật lên

            if (firstClicked == null)
            {
                firstClicked = clickedBox;
                return;
            }

            secondClicked = clickedBox;

            // So sánh
            if (firstClicked.Tag == secondClicked.Tag)
            {
                // Trúng -> để nguyên
                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                // Sai -> đợi 1 giây rồi úp xuống
                await Task.Delay(1000);
                firstClicked.Image = null;
                secondClicked.Image = null;
                firstClicked = null;
                secondClicked = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chưa dùng
        }
    }
}
