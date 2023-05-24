using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwTrain
{
    internal class Rectangle
    {
        private int x1, y1, x2, y2;

        public int X1 { get => x1; }
        public int Y1 { get => y1; }
        public int X2 { get => x2; }
        public int Y2 { get => y2; }

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, x1, y1, x2 - x1, y2 - y1);
        }
    }
}
