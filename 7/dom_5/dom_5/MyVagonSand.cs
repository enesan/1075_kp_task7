using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyVagonSand: MyVagon
    {
        int x0_, y0_, l_;
        public MyVagonSand(int x0, int y0, int L) : base(x0, y0, L)
        {
            x0_ = x0;
            y0_ = y0;
            l_ = L;
        }

        public override void visual(Graphics g)
        {
            base.visual(g);
            Brush b = new SolidBrush(Color.SandyBrown);
            Point A = new Point(x0_, y0_);
            Point B = new Point(x0_ + l_/2, y0_ - l_/4);
            Point C = new Point(x0_ + l_, y0_);
            PointF[] points = { A, B, C };
            g.FillPolygon(b, points);
        }
    }
}
