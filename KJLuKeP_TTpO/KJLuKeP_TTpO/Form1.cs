namespace KJLuKeP_TTpO
{
    public partial class Form1 : Form
    {
        Game clicker = new(250, 0, 1);
        int sila = 1;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        public event EventHandler Tick;
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(clicker.click());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(clicker.get_score());
            clicker.get_passive();
            label4.Text = Convert.ToString(clicker.get_passive_value());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicker.get_score() > 20)
            {
                clicker.get_grandmo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicker.get_score() > 100)
            {
                clicker.get_farm();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clicker.get_score() > 500)
            {
                clicker.get_zavod();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clicker.get_score() > 2500)
            {
                clicker.get_office();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clicker.get_score() > clicker.get_up_value())
            {
                clicker.up_sila();
                label6.Text = Convert.ToString(clicker.get_sila());
            }
        }
    }
}