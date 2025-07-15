using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace _1911064890_HaNguyenGiaMinh
{
    public partial class frmDoanHinh : Form
    {
        List<Button> buttons = new List<Button>();
        List<Image> images = new List<Image>();
        Button firstClick = null;
        Button secondClick = null;
        Random rand = new Random();
        private Image? questionImage;




        public frmDoanHinh()
        {
            InitializeComponent();
            Load += frmDoanHinh_Load;

        }



        private async void Button_Click(object sender, EventArgs e)
        {
            if (sender is not Button clicked || secondClick != null)
                return;

            if (questionImage == null)
            {
                string questionPath = Path.Combine(Application.StartupPath, "Images", "question.png");
                questionImage = Image.FromFile(questionPath);
            }

            // Nếu nút đã được lật rồi thì bỏ qua
            if (clicked.BackgroundImage != questionImage)
                return;

            // Lật hình ảnh thật từ tên file trong Tag
            string imageFileName = (string)clicked.Tag!;
            string imagePath = Path.Combine(Application.StartupPath, "Images", imageFileName);
            clicked.BackgroundImage = Image.FromFile(imagePath);
            clicked.Refresh();

            if (firstClick == null)
            {
                firstClick = clicked;
                return;
            }

            secondClick = clicked;

            // So sánh tên file ảnh
            if ((string)firstClick.Tag == (string)secondClick.Tag)
            {
                firstClick = null;
                secondClick = null;
            }
            else
            {
                await Task.Delay(1000);
                firstClick.BackgroundImage = questionImage;
                secondClick.BackgroundImage = questionImage;
                firstClick = null;
                secondClick = null;
            }

            if (CheckWin())
            {
                MessageBox.Show("🎉 Bạn đã đoán hết hình! Chúc mừng!");
            }
        }

        private bool CheckWin()
        {
            if (questionImage == null)
            {
                string questionPath = Path.Combine(Application.StartupPath, "Images", "question.png");
                questionImage = Image.FromFile(questionPath);
            }

            return buttons.All(btn => btn.BackgroundImage != questionImage);
        }


        private void frmDoanHinh_Load(object sender, EventArgs e)
        {
            buttons.AddRange(new[]
            {
                btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8,
                btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16

                // btn1, btn2, btn3, btn5, btn6, btn7,
                //btn9, btn10, btn11, btn13, btn14, btn15

            });

            string folderPath = Path.Combine(Application.StartupPath, "Images");
            //string[] files = Directory.GetFiles(folderPath, "*.jpg");
            string[] files =
            {
                "Images\\1.jpg",
                "Images\\2.jpg",
                "Images\\3.jpg",
                "Images\\4.jpg",
                "Images\\5.jpg",
                "Images\\6.jpg",
                "Images\\7.jpg",
                "Images\\8.jpg",
                "Images\\9.jpg",
                "Images\\10.jpg",
                "Images\\11.jpg",
                "Images\\12.jpg",
                "Images\\13.jpg",
                "Images\\14.jpg",
                "Images\\15.jpg",
                "Images\\16.jpg"

            };

            foreach (string file in files.Take(8))
            {
                Image img = Image.FromFile(file);
                images.Add(img);
                images.Add(img); // tạo cặp
            }
            images = images.OrderBy(x => rand.Next()).ToList();

            string questionPath = Path.Combine(folderPath, "question.png");
            questionImage = Image.FromFile(questionPath);

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Tag = Path.GetFileName(files[i % 8]); // gán tên file làm Tag
                buttons[i].BackgroundImage = questionImage;
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                buttons[i].Click += Button_Click;
            }

            // random vị trí ảnh cặp cho các nút
            //for (int i = 0; i < buttons.Count; i++)
            //{
            //    // Lấy chỉ số ngẫu nhiên từ danh sách hình ảnh
            //    int randomIndex = rand.Next(images.Count);
            //    // Gán hình ảnh cho nút
            //    buttons[i].BackgroundImage = images[randomIndex];
            //    buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
            //    // Xóa hình ảnh đã sử dụng để tránh lặp lại
            //    images.RemoveAt(randomIndex);
            //}


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            KhoiTaoHinhAnh();

            // Gọi lại hàm frmDoanHinh_Load để khởi tạo lại hình ảnh
            //frmDoanHinh_Load(this, EventArgs);
        }

        private void KhoiTaoHinhAnh()
        {
            // làm mới lại các nút
            firstClick = null;
            secondClick = null;
            foreach (Button btn in buttons)
            {
                btn.BackgroundImage = questionImage;
                btn.Refresh();
                // làm mới hình ảnh cho các nút bằng cách gọi frmDoanHinh_Load
                btn.Image = null; // Xóa hình ảnh hiện tại
                btn.Image = questionImage; // Đặt lại hình ảnh câu hỏi

            }
            // Gọi lại hàm frmDoanHinh_Load để khởi tạo lại hình ảnh
            frmDoanHinh_Load(this, EventArgs.Empty);

        }
    }
}
