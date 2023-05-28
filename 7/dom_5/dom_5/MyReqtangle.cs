using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyReqtangle
    {
        Pen p = new Pen(Color.Black, 1);
        Brush b = new SolidBrush(Color.White);
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }

        public MyReqtangle(double x1_, double x2_, double y1_, double y2_)
        {
            x1= x1_;
            x2= x2_;
            y1= y1_;
            y2= y2_;
        }

        public MyReqtangle(double x1_, double x2_, double y1_, double y2_, Brush brush)
        {
            x1 = x1_;
            x2 = x2_;
            y1 = y1_;
            y2 = y2_;
            b = brush;
        }

        public void new_rectangle(double X1, double Y1, double X2, double Y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public void visual_reqtungle(Graphics g)
        {
            g.FillRectangle(b, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2 - x1), Convert.ToInt32(y2 - y1));
            g.DrawRectangle(p, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2 -x1), Convert.ToInt32(y2 -y1));
      
        }

    }
}
