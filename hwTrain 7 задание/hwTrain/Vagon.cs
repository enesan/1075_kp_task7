using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwTrain
{
    internal class Vagon : Rectangle
    {
        private Circle left;
        private Circle right;
        private int dx;
        
        public Vagon(int x, int y, int length) : base(x, y, x + length, y + 2 * length / 5)
        {
            left = new Circle(x + length / 7, y + 19 * length / 35, length / 7);
            right = new Circle(x + 6 * length / 7, y + 19 * length / 35, length / 7);
        }
        public virtual void Draw(Graphics g)
        {
            left.Draw(g);
            right.Draw(g);
            base.Draw(g);
        }
    }
}
