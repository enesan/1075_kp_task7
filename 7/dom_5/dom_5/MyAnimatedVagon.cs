using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyAnimatedVagon : MyVagon
    {
        double x0 => base.X;
        double y0 => base.Y;
        double L => base.L;
        double angle = 0;
        int speed;
        public MyAnimatedVagon(int x0, int y0, int L, int speed) : base(x0, y0, L)
        {
            this.speed = speed;
        }

        public void Tick()
        {
            base.X = base.X + speed * Math.Cos(angle * Math.PI / 180);
            base.Y = base.Y + speed * Math.Sin(angle * Math.PI / 180);
        }

        public void Collision(Panel panel)
        {
            if (x0 + L > panel.Width)
            {
                angle = 180;
            }
            else if (x0 < 0)
            {
                angle = 0;
            }
        }
    }
}
