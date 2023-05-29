using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class PlaneForm 
    {
        private int x0, y0, dlina_kuzova;

        private Color BrushColor = Color.Red;

        public Color color { get { return BrushColor; } set { BrushColor = value; } }

        public PlaneForm() 
        {
            x0 = 100;
            y0 = 100;
            dlina_kuzova = 200;
        }

        public int x { get { return x0; } set {  x0 = value; } }
        public int y { get { return y0; } set {  y0 = value; } }

        public int dlina_kuzova_pro { get { return dlina_kuzova; } set { dlina_kuzova = value; } }



        public void Visual(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
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
            Point[] points = { A, B, C, D, E, F, G, H, I, J, K, L, M, N };
            Brush brush = new SolidBrush(BrushColor);
            g.FillPolygon(brush, points);
        }
    }
}
