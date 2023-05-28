using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    
    internal class MyVagon : MyReqtangle
    {
        private double x;
        private double y;
        private double l;
        public double X
        {
            get { return x; }
            set
            {
                circle1.x0 = value + l / 7 + 1;
                circle2.x0 = value + l - l / 7 - 1;
                base.x1 = value;
                base.x2 = value + l;
                x = value;
            }
        }
        public double Y
        {
            get { return  y; }
            set
            {
                circle1.y0 = value + l/2 + l/7+ 2;
                circle2.y0 = value + l/2 + l/7 + 2;
                base.y1 = value ;
                base.y2 = value + l/2;
                y = value;
            }
        }
        public double L {
            get
            {
                return l;
            }
        }
        public int mass;
        MyCircle circle1;
        MyCircle circle2;

        public MyVagon(double x0, double y0, double L) : base(x0, x0+L, y0, y0+L/2)
        {
            l = L;
            double r = L / 7;
            x = x0;
            y = y0;
            circle1 = new MyCircle(x0 + r + 1, y0 + L / 2 + r + 2, Convert.ToInt32(r));
            circle2 = new MyCircle(x0 + L - r - 1, y0 + L / 2 + r + 2, Convert.ToInt32(r));
        }

        virtual public void visual(Graphics g)
        {
            base.visual_reqtungle(g);
            circle1.visual_circle(g);
            circle2.visual_circle(g);
        }
    }
}
