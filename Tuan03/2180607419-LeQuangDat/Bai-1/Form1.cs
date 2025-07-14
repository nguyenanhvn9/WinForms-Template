namespace _2180607419_LeQuangDat_BaiThucHanhTuan3
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<Image> images = new List<Image>();
        PictureBox firstClick = null, secondClick = null;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Random rnd = new Random();
        Image backImage = Properties.Resources.back;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void LoadImages()
        {
            images.Add(Properties.Resources.img1);
            images.Add(Properties.Resources.img2);
            images.Add(Properties.Resources.img3);
            images.Add(Properties.Resources.img4);
            images.Add(Properties.Resources.img5);
            images.Add(Properties.Resources.img6);
            images.Add(Properties.Resources.img7);
            images.Add(Properties.Resources.img8);

            Image backImage = Properties.Resources.back;

        }

        private void SetupPictureBoxes()
        {
            int index = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox pic)
                {
                    
                    if (index < images.Count)
                    {
                        pictureBoxes.Add(pic);
                        pic.Image = backImage;
                        pic.Tag = images[index];
                        pic.Click += Pic_Click;
                        index++;
                    }
                    else
                    {
                    
                        break;
                    }
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;

            if (clicked == null || clicked.Image != backImage || secondClick != null)
                return;

            clicked.Image = (Image)clicked.Tag;

            if (firstClick == null)
            {
                firstClick = clicked;
                return;
            }

            secondClick = clicked;

            if (firstClick.Tag == secondClick.Tag)
            {
                firstClick = null;
                secondClick = null;


                if (pictureBoxes.All(p => p.Image != backImage))
                {
                    MessageBox.Show("🎉 Bạn đã chiến thắng!", "Chiến thắng");
                }
            }
            else
            {
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            firstClick.Image = backImage;
            secondClick.Image = backImage;
            firstClick = null;
            secondClick = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImages();
            SetupPictureBoxes();
        }
    }
}


