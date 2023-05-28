using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyCircle
    {
        public double x0 { get; set; }
        public double y0 { get; set; } 
        int R { get; set; }

        public MyCircle(double x0_, double y0_, int R_)
        {
            x0 = x0_;
            y0 = y0_;
            R = R_;
        }

        public void new_circle(double x, double y, int r)
        {
            x = x0;
            y = y0;
            r = R;
        }

        public void visual_circle(Graphics g)
        {
            Pen p = new Pen(Color.Black, 1);
            g.DrawEllipse(p, Convert.ToInt32(x0 -R), Convert.ToInt32(y0 -R), R*2, R*2);
        }

    }
}
