namespace dom_5
{
    public partial class Form1 : Form
    {

        Graphics g1;
        Graphics g2;
        MyAnimatedVagon vagon;
        MyDVD dvd;

        public Form1()
        {
            vagon = new MyAnimatedVagon(0, 100, 70, 5);
            dvd = new MyDVD(100, 100, 100, 15);
            InitializeComponent();
            g1 = panel1.CreateGraphics();
            g2 = panel2.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vagon.Collision(panel1);
            vagon.Tick();
            dvd.Collision(panel2, null);
            dvd.Tick();
            g1.Clear(panel1.BackColor);
            g2.Clear(panel2.BackColor);
            vagon.visual(g1);
            dvd.visual(g2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}