using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        game g;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = new game(Convert.ToInt32(numericUpDown1.Value));
            numericUpDown1.Enabled = true;
            Start.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form1_Load(this, null);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Draw(e.Graphics);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            g.Move(e);
            Refresh();
            if (g.Touch_red() == false)
            {
                MessageBox.Show("Вы проиграли.");
                Form1_Load(this, null);
            }
            g.Touch_black();
            g.Touch_g_w();
            if(g.Win())
            {
                MessageBox.Show("Вы победили");
                Form1_Load(this, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            Start.Enabled = false;
        }
    }
}
