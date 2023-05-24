using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwTrain
{
    internal class Circle
    {
        private int x, y;
        private int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);
        }
    }
}
