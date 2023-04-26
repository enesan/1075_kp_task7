using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_7
{
    internal class Samoletik
    {
        public int x0, y0, dlina_kuzova;
        public Color color = Color.BlueViolet;
        Random rnd = new Random();

        public Samoletik(int x, int y)
        {
            x0 = x;
            y0 = y;
            dlina_kuzova = 50;
        }

        public void Draw(Graphics g)
        {
            Point A = new Point(x0, y0 + dlina_kuzova / 5);
            Point B = new Point(x0 + dlina_kuzova / 5, y0);
            Point C = new Point(x0 + 2 * dlina_kuzova / 5, y0 + 3 * dlina_kuzova / 10);
            Point D = new Point(x0 + 7 * dlina_kuzova / 10, y0);
            Point E = new Point(x0 + dlina_kuzova, y0);
            Point F = new Point(x0 + dlina_kuzova, y0 + 3 * dlina_kuzova / 10);
            Point G = new Point(x0 + 7 * dlina_kuzova / 10, y0 + 3 * dlina_kuzova / 5);
            Point H = new Point(x0 + dlina_kuzova, y0 + 4 * dlina_kuzova / 5);
            Point I = new Point(x0 + 4 * dlina_kuzova / 5, y0 + dlina_kuzova);
            Point J = new Point(x0 + 3 * dlina_kuzova / 5, y0 + 7 * dlina_kuzova / 10);
            Point K = new Point(x0, y0 + dlina_kuzova);
            Point L = new Point(x0, y0 + 4 * dlina_kuzova / 5);
            Point M = new Point(x0 + dlina_kuzova / 10, y0 + 4 * dlina_kuzova / 5);
            Point N = new Point(x0 + 3 * dlina_kuzova / 10, y0 + 2 * dlina_kuzova / 5);
            Point[] points = {A, B, C, D, E, F, G, H, I, J, K, L, M, N};
            Brush brush = new SolidBrush(color);
            g.FillPolygon(brush, points);
        }

        public void ChangeBrush()
        {
            int red = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            color = Color.FromArgb(red, green, blue);
        }
    }
}
