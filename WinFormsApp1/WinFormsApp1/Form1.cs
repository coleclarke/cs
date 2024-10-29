namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogBtn_Click_1(object sender, EventArgs e)
        {
            if (UserBox.Text != "" && PassBox.Text != "")
            {
                UserBox.Visible = false;
                PassBox.Visible = false;
                LogBtn.Visible = false;
                lblSucsess.Text = "Login Sucsessfull";
            }
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
