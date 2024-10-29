namespace JPR_Shoe
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


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double amt = (double)numericUpDown1.Value;
             if (amt > 1000) { Price1.Text = "$" + (5.99 * 5).ToString("0.00"); }
            else if (amt > 500) { Price1.Text = "$" + (5.99 * 3).ToString("0.00"); }
            else if (amt > 100) { Price1.Text = "$" + (5.99 * 2.25).ToString("0.00"); }
            else if (amt > 50) { Price1.Text = "$" + (5.99 * 2).ToString("0.00"); }
            else { Price1.Text = "$" + (5.99 * 1.5).ToString("0.00"); }

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double amt = (double)numericUpDown2.Value;
            if (amt > 1000) { Price2.Text = "$" + (9.99 * 5).ToString("0.00"); }
            else if (amt > 500) { Price2.Text = "$" + (9.99 * 3).ToString("0.00"); }
            else if (amt > 100) { Price2.Text = "$" + (9.99 * 2.25).ToString("0.00"); }
            else if (amt > 50) { Price2.Text = "$" + (9.99 * 2).ToString("0.00"); }
            else { Price2.Text = "$" + (9.99 * 1.5).ToString("0.00"); }
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double amt = (double)numericUpDown3.Value;
            if (amt > 1000) { Price3.Text = "$" + (12.99 * 5).ToString("0.00"); }
            else if (amt > 500) { Price3.Text = "$" + (12.99 * 3).ToString("0.00"); }
            else if (amt > 100) { Price3.Text = "$" + (12.99 * 2.25).ToString("0.00"); }
            else if (amt > 50) { Price3.Text = "$" + (12.99 * 2).ToString("0.00"); }
            else { Price3.Text = "$" + (12.99 * 1.5).ToString("0.00"); }
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double amt = (double)numericUpDown4.Value;
            if (amt > 1000) { Price4.Text = "$" + (4.99 * 5).ToString("0.00"); }
            else if (amt > 500) { Price4.Text = "$" + (4.99 * 3).ToString("0.00"); }
            else if (amt > 100) { Price4.Text = "$" + (4.99 * 2.25).ToString("0.00"); }
            else if (amt > 50) { Price4.Text = "$" + (4.99 * 2).ToString("0.00"); }
            else { Price4.Text = "$" + (4.99 * 1.5).ToString("0.00"); }
        }

    }
}
