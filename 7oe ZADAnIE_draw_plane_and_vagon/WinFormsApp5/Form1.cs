using System.Numerics;
using System.Transactions;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private Rectangle dvdRect;
        int dx = 15;
        int dy = 15;
        public Form1()
        {
            InitializeComponent();
            dvdRect = new Rectangle(plane.x, plane.y, plane.dlina_kuzova_pro, 200);
        }

        Graphics gr;

        Vagon vagon = new Vagon();
        PlaneForm plane = new PlaneForm();
        private void button1_Click(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            Vagon vagon = new Vagon();
            timer4.Start();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.Clear(Color.White);
            if (vagon.X < 716)
            {
                vagon.Visual(gr);
                vagon.X += 15;
            }
            else
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.Clear(Color.White);
            if (vagon.X > 0)
            {
                vagon.Visual(gr);
                vagon.X -= 15;
            }
            else
            {
                timer5.Stop();
                timer4.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            timer5.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.Clear(Color.White);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.Clear(Color.White);
            plane.Visual(gr);
            timer6.Start();
            

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.Clear(Color.White);
            plane.Visual(gr);
            plane.y += dy;
            dvdRect.Y += dy;
            plane.x += dx;
            dvdRect.X += dx;
            if (dvdRect.Right >= this.ClientSize.Width || dvdRect.Left <= 0)
            {
                dx = -dx;
                plane.color = getColor();
            }
            if (dvdRect.Bottom >= this.ClientSize.Height || dvdRect.Top <= 0)
            {
                dy = -dy;
                plane.color = getColor();
            }
        }

        public Color getColor()
        {
            Random r = new Random();
            return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }
        private void timer7_Tick(object sender, EventArgs e)
        {

        }

        private void timer8_Tick(object sender, EventArgs e)
        {

        }
    }
}