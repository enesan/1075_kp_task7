using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace hwTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grafics = CreateGraphics();
            timer1.Enabled = true;
        }

        Graphics grafics;
        Vagon vagon;
        int x = 50;
        int dx = 30;
        private int screenWidth = 1000, screenHeight = 600;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += dx;
            vagon = new(x, 300, 210);

            Refresh();

            bool driveLeft = true;

            if (x >= this.Width - (vagon.X2 - vagon.X1) || (x < 0))
            {
                driveLeft = false;
                dx = -dx;
            }

            vagon.Draw(grafics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = screenWidth;
            Height = screenHeight;
        }
    }
}