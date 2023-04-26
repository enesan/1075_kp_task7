using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_7
{
    internal class Mashinka
    {
        public int x0, y0, radius, dlina_kuzova;

        public Mashinka()
        {
            x0 = 50;
            y0 = 250;
            dlina_kuzova = 100;
            radius = dlina_kuzova / 10;
        }

        public void Draw(Graphics g)
        {
            Point A = new Point(x0 + dlina_kuzova / 5, y0 + dlina_kuzova / 8);
            Point B = new Point(x0 + dlina_kuzova / 3, y0);
            Point C = new Point(x0 + 2 * dlina_kuzova / 3, y0);
            Point D = new Point(x0 + 4 * dlina_kuzova / 5, y0 + dlina_kuzova / 8);
            Point[] points = {A, B, C, D};
            g.FillPolygon(Brushes.BlueViolet, points);
            g.FillRectangle(Brushes.BlueViolet, x0, y0 + dlina_kuzova / 8, dlina_kuzova, dlina_kuzova / 4);
            g.FillEllipse(Brushes.Black, x0, y0 + 3 * dlina_kuzova / 8, 2 * radius, 2 * radius);
            g.FillEllipse(Brushes.Black, x0 + 4 * dlina_kuzova / 5, y0 + 3 * dlina_kuzova / 8, 2 * radius, 2 * radius);
        }
    }
}
