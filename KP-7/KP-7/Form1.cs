namespace KP_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mashinka mashinka = new();
        Samoletik samoletik = new(50, 250);
        Samoletik drugoi_samoletik = new(650, 250);
        Graphics g;
        bool MoveReverse, MoveReverseX, MoveReverseY, DrugoiMoveReverseX, DrugoiMoveReverseY;
        private void knopka_mashinka_Click(object sender, EventArgs e)
        {
            timer_mashinka.Enabled = !timer_mashinka.Enabled;
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            mashinka.x0 = 50;
            MoveReverse = false;
        }

        private void timer_mashinka_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            if (mashinka.x0 == 700) MoveReverse = true;
            else if (mashinka.x0 == 0) MoveReverse = false;
            if (MoveReverse == true)
            {
                mashinka.x0 -= 5;
                mashinka.Draw(g);
            }
            else
            {
                mashinka.x0 += 5;
                mashinka.Draw(g);
            }
        }

        private void knopka_samoletik_odin_Click(object sender, EventArgs e)
        {
            timer_odin_samoletik.Enabled = !timer_odin_samoletik.Enabled;
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            samoletik.x0 = 50;
            samoletik.y0 = 250;
            MoveReverseX = false;
            MoveReverseY = false;
        }

        private void timer_odin_samoletik_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            if (samoletik.x0 == 750) MoveReverseX = true;
            else if (samoletik.x0 == 0) MoveReverseX = false;
            if (samoletik.y0 == 400) MoveReverseY = true;
            else if (samoletik.y0 == 0) MoveReverseY = false;
            if (MoveReverseX == true && MoveReverseY == true)
            {
                samoletik.x0 -= 5;
                samoletik.y0 -= 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == false && MoveReverseY == false)
            {
                samoletik.x0 += 5;
                samoletik.y0 += 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == true && MoveReverseY == false)
            {
                samoletik.x0 -= 5;
                samoletik.y0 += 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == false && MoveReverseY == true)
            {
                samoletik.x0 += 5;
                samoletik.y0 -= 5;
                samoletik.Draw(g);
            }
        }

        private void knopka_dva_samoletika_Click(object sender, EventArgs e)
        {
            timer_dva_samoletika.Enabled = !timer_dva_samoletika.Enabled;
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            samoletik.x0 = 50;
            samoletik.y0 = 250;
            drugoi_samoletik.x0 = 650;
            drugoi_samoletik.y0 = 250;
            MoveReverseX = false;
            MoveReverseY = false; 
            DrugoiMoveReverseX = true;
            DrugoiMoveReverseY = false;
        }

        private void timer_dva_samoletika_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.DarkGray);
            if (samoletik.x0 == 750)
            {
                MoveReverseX = true;
                samoletik.ChangeBrush();
            }
            else if (samoletik.x0 == 0)
            {
                MoveReverseX = false;
                samoletik.ChangeBrush();
            }
            if (samoletik.y0 == 400)
            {
                MoveReverseY = true;
                samoletik.ChangeBrush();
            }
            else if (samoletik.y0 == 0)
            {
                MoveReverseY = false;
                samoletik.ChangeBrush();
            }
            if (MoveReverseX == true && MoveReverseY == true)
            {
                samoletik.x0 -= 5;
                samoletik.y0 -= 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == false && MoveReverseY == false)
            {
                samoletik.x0 += 5;
                samoletik.y0 += 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == true && MoveReverseY == false)
            {
                samoletik.x0 -= 5;
                samoletik.y0 += 5;
                samoletik.Draw(g);
            }
            else if (MoveReverseX == false && MoveReverseY == true)
            {
                samoletik.x0 += 5;
                samoletik.y0 -= 5;
                samoletik.Draw(g);
            }
            if (drugoi_samoletik.x0 == 750)
            {
                DrugoiMoveReverseX = true;
                drugoi_samoletik.ChangeBrush();
            }
            else if (drugoi_samoletik.x0 == 0)
            {
                DrugoiMoveReverseX = false;
                drugoi_samoletik.ChangeBrush();
            }
            if (drugoi_samoletik.y0 == 400)
            {
                DrugoiMoveReverseY = true;
                drugoi_samoletik.ChangeBrush();
            }
            else if (drugoi_samoletik.y0 == 0) 
            {
                DrugoiMoveReverseY = false;
                drugoi_samoletik.ChangeBrush();
            }
            if (DrugoiMoveReverseX == true && DrugoiMoveReverseY == true)
            {
                drugoi_samoletik.x0 -= 5;
                drugoi_samoletik.y0 -= 5;
                drugoi_samoletik.Draw(g);
            }
            else if (DrugoiMoveReverseX == false && DrugoiMoveReverseY == false)
            {
                drugoi_samoletik.x0 += 5;
                drugoi_samoletik.y0 += 5;
                drugoi_samoletik.Draw(g);
            }
            else if (DrugoiMoveReverseX == true && DrugoiMoveReverseY == false)
            {
                drugoi_samoletik.x0 -= 5;
                drugoi_samoletik.y0 += 5;
                drugoi_samoletik.Draw(g);
            }
            else if (DrugoiMoveReverseX == false && DrugoiMoveReverseY == true)
            {
                drugoi_samoletik.x0 += 5;
                drugoi_samoletik.y0 -= 5;
                drugoi_samoletik.Draw(g);
            }
            if (drugoi_samoletik.x0 >= samoletik.x0 && drugoi_samoletik.x0 <= samoletik.x0 + samoletik.dlina_kuzova &&
                drugoi_samoletik.y0 >= samoletik.y0 && drugoi_samoletik.y0 <= samoletik.y0 + samoletik.dlina_kuzova)
            {
                DrugoiMoveReverseX = !DrugoiMoveReverseX;
                MoveReverseX = !MoveReverseX;
            }
        }
    }
}
