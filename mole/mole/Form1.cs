namespace mole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Go.Visible = false;
            Restart.Visible = false;
        }


        public static void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Left = rnd.Next(964);
            button1.Top = rnd.Next(215, 594);
            int score = Int32.Parse(Scorelb.Text);
            score++;
            Scorelb.Text = score.ToString("0");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            Scorelb.Text = "0";
            Misslb.Text = "0";

            Game();
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Go.Visible = false;
            Restart.Visible = false;
            Scorelb.Text = "0";
            Misslb.Text = "0";

            Game();
        }
        private void Game()
        {
            Random rnd = new Random();
            int time = 120;

            int tm = 0;

            while (time >= 0)
            {

                if (time > 60)
                {
                    Wait(1000);
                    button1.Left = rnd.Next(964);
                    button1.Top = rnd.Next(215, 594);

                    Timelb.Text = time.ToString("0");
                    tm++;
                    if (tm == 1)
                    {
                        time--;
                        tm = 0;
                    }
                }
                else
                {
                    Wait(500);
                    button1.Left = rnd.Next(964);
                    button1.Top = rnd.Next(215, 594);

                    Timelb.Text = time.ToString("0");
                    tm++;
                    if (tm == 2)
                    {
                        time--;
                        tm = 0;
                    }
                }
            }
            Go.Visible = true;
            Restart.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Miss_Click(object sender, EventArgs e)
        {
            int miss = Int32.Parse(Misslb.Text);
            miss++;
            Misslb.Text = miss.ToString("0");
        }


    }
}
