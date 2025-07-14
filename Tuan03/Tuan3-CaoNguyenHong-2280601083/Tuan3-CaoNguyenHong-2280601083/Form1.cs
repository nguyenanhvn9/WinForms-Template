namespace Tuan3_CaoNguyenHong_2280601083
{
    public partial class Form1 : Form
    {
        private Button firstGuess;
        private bool lockBoard = false;
        private int score = 0;
        private int timeLeft = 60;
        private List<string> icons = new List<string>
        {
            "1.jpg", "2.jpg", "3.jpg", "4.jpg",
            "5.jpg", "6.jpg", "7.jpg", "8.jpg",
            "9.jpg", "10.jpg"
        };
        private List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            buttons.Clear();
            buttons.AddRange(new Button[]
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20,
            });

            var allIcons = icons.Concat(icons).ToList(); // Tạo 20 ô (10 cặp)
            allIcons = allIcons.OrderBy(x => Guid.NewGuid()).ToList(); // Xáo trộn
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].BackgroundImage = null;
                buttons[i].Tag = allIcons[i];
                buttons[i].Click += Button_Click;
                buttons[i].BackgroundImageLayout = ImageLayout.Stretch;
                buttons[i].Size = new Size(120, 120); // Kích thước mỗi ô
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (lockBoard) return;

            Button current = sender as Button;
            if (current.BackgroundImage != null || current == firstGuess) return;

            current.BackgroundImage = Image.FromFile($"Images/{current.Tag}");
            if (firstGuess == null)
            {
                firstGuess = current;
            }
            else
            {
                lockBoard = true;
                if (firstGuess.Tag.ToString() == current.Tag.ToString())
                {
                    score += 10;
                    firstGuess = null;
                    lockBoard = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000); // Đợi 1 giây
                    firstGuess.BackgroundImage = null;
                    current.BackgroundImage = null;
                    firstGuess = null;
                    lockBoard = false;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
