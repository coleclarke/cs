using System.IO;

namespace Chips_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Fill data into Form
            string filePath = @"C:\Users\cole.clarke\Desktop\Sharpie C\Form c#\Chips Inventory\Chips Inventory\Inventory.csv";
            {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        
                        string line;
                        string[] parts;
                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Ruf1.Text = parts[0];
                        Ruf1p.Text = parts[1];
                        Ruf1rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Ruf2.Text = parts[0];
                        Ruf2p.Text = parts[1];
                        Ruf2rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Ruf3.Text = parts[0];
                        Ruf3p.Text = parts[1];
                        Ruf3rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Ruf4.Text = parts[0];
                        Ruf4p.Text = parts[1];
                        Ruf4rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Lay1.Text = parts[0];
                        Lay1p.Text = parts[1];
                        Lay1rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Lay2.Text = parts[0];
                        Lay2p.Text = parts[1];
                        Lay2rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Lay3.Text = parts[0];
                        Lay3p.Text = parts[1];
                        Lay3rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Lay4.Text = parts[0];
                        Lay4p.Text = parts[1];
                        Lay4rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Dor1.Text = parts[0];
                        Dor1p.Text = parts[1];
                        Dor1rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Dor2.Text = parts[0];
                        Dor2p.Text = parts[1];
                        Dor2rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Dor3.Text = parts[0];
                        Dor3p.Text = parts[1];
                        Dor3rp.Text = parts[2];

                        line = reader.ReadLine();
                        parts = line.Split(',');
                        Dor4.Text = parts[0];
                        Dor4p.Text = parts[1];
                        Dor4rp.Text = parts[2];
                    }
            }
        }




        //Update retail price when unit cost is changed
        private void Ruf1p_TextChanged(object sender, EventArgs e)
        {
            Ruf1rp.Text = Convert.ToString(Math.Round(double.Parse(Ruf1p.Text) * 1.43, 2));
        }
        private void Ruf2p_TextChanged(object sender, EventArgs e)
        {
            Ruf2rp.Text = Convert.ToString(Math.Round(double.Parse(Ruf2p.Text) * 1.43, 2));

        }
        private void Ruf3p_TextChanged(object sender, EventArgs e)
        {
            Ruf3rp.Text = Convert.ToString(Math.Round(double.Parse(Ruf3p.Text) * 1.43, 2));
        }
        private void Ruf4p_TextChanged(object sender, EventArgs e)
        {
            Ruf4rp.Text = Convert.ToString(Math.Round(double.Parse(Ruf4p.Text) * 1.43, 2));

        }
        private void Lay1p_TextChanged(object sender, EventArgs e)
        {
            Lay1rp.Text = Convert.ToString(Math.Round(double.Parse(Lay1p.Text) * 1.43, 2));
        }
        private void Lay2p_TextChanged(object sender, EventArgs e)
        {
            Lay2rp.Text = Convert.ToString(Math.Round(double.Parse(Lay2p.Text) * 1.43, 2));

        }
        private void Lay3p_TextChanged(object sender, EventArgs e)
        {
            Lay3rp.Text = Convert.ToString(Math.Round(double.Parse(Lay3p.Text) * 1.43, 2));
        }
        private void Lay4p_TextChanged(object sender, EventArgs e)
        {
            Lay4rp.Text = Convert.ToString(Math.Round(double.Parse(Lay4p.Text) * 1.43, 2));

        }
        private void Dor1p_TextChanged(object sender, EventArgs e)
        {
            Dor1rp.Text = Convert.ToString(Math.Round(double.Parse(Dor1p.Text) * 1.43, 2));
        }
        private void Dor2p_TextChanged(object sender, EventArgs e)
        {
            Dor2rp.Text = Convert.ToString(Math.Round(double.Parse(Dor2p.Text) * 1.43, 2));

        }
        private void Dor3p_TextChanged(object sender, EventArgs e)
        {
            Dor3rp.Text = Convert.ToString(Math.Round(double.Parse(Dor3p.Text) * 1.43, 2));
        }
        private void Dor4p_TextChanged(object sender, EventArgs e)
        {
            Dor4rp.Text = Convert.ToString(Math.Round(double.Parse(Dor4p.Text) * 1.43, 2));

        }

        //Update Csv file
        private void button1_Click(object sender, EventArgs e)
        {
            string csvw = 
                Ruf1.Text + "," + Ruf1p.Text + "," + Ruf1rp.Text + "\n" +
                Ruf2.Text + "," + Ruf2p.Text + "," + Ruf2rp.Text + "\n" +
                Ruf3.Text + "," + Ruf3p.Text + "," + Ruf3rp.Text + "\n" +
                Ruf4.Text + "," + Ruf4p.Text + "," + Ruf4rp.Text + "\n" +
                Lay1.Text + "," + Lay1p.Text + "," + Lay1rp.Text + "\n" +
                Lay2.Text + "," + Lay2p.Text + "," + Lay2rp.Text + "\n" +
                Lay3.Text + "," + Lay3p.Text + "," + Lay3rp.Text + "\n" +
                Lay4.Text + "," + Lay4p.Text + "," + Lay4rp.Text + "\n" +
                Dor1.Text + "," + Dor1p.Text + "," + Dor1rp.Text + "\n" +
                Dor2.Text + "," + Dor2p.Text + "," + Dor2rp.Text + "\n" +
                Dor3.Text + "," + Dor3p.Text + "," + Dor3rp.Text + "\n" +
                Dor4.Text + "," + Dor4p.Text + "," + Dor4rp.Text;
            string filePath = @"C:\Users\cole.clarke\Desktop\Sharpie C\Form c#\Chips Inventory\Chips Inventory\Inventory.csv";
            using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(csvw);
                };
        }
    }
}
