namespace hwAirplane
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private Timer timer;
        private Plane plane1, plane2;
        private int screenWidth = 800, screenHeight = 600;

        public Form1()
        {
            InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            plane1.Move(screenWidth, screenHeight);
            plane2.Move(screenWidth, screenHeight);

            if (plane1.CheckCollision(plane2))
            {
                plane1.ResolveCollision(plane2);
            }

            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = screenWidth;
            Height = screenHeight;
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += Timer_Tick;

            plane1 = new Plane(50, 50, 5, 5, 75, 50, Color.Red);
            plane2 = new Plane(600, 450, -5, -5, 75, 50, Color.Blue);

            timer.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            plane1.Draw(e.Graphics);
            plane2.Draw(e.Graphics);
        }
    }
}