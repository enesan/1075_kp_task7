using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_lab
{
    internal class pole
    {
        int x, y, w, h;
        Color[] c;
        int color;
        Brush br;
        public pole(int x, int y, int col)
        {
            this.x = x;
            this.y = y;
            w = 50;
            h = 50;
            this.color = col;
            this.c = new Color[] { Color.White, Color.Green, Color.Red, Color.Black, Color.Orange };
            br = new SolidBrush(this.c[col]);
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(br, x, y, w, h);
        }
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int W { get { return w; } }
        public int H { get { return h; } }
        public Rectangle R
        {
            get { return new Rectangle(x, y, w, h); }
        }
        public Color col
        {
            get { return c[color]; }
        }
    }
}
