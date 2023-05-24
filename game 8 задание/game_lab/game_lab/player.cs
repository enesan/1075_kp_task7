using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_lab
{
    internal class player
    {
        int x, y, w, h;
        public player(int x, int y)
        {
            this.x = x;
            this.y = y;
            w = 8;
            h = 16;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), x, y, w, h);
            g.DrawRectangle(new Pen(Color.Black, 1), x, y, w, h);

            g.FillRectangle(new SolidBrush(Color.Blue), x - w / 2, y, w / 2, h);
            g.DrawRectangle(new Pen(Color.Black, 1), x - w / 2, y, w / 2, h);

            g.FillRectangle(new SolidBrush(Color.Blue), x + w, y, w / 2, h);
            g.DrawRectangle(new Pen(Color.Black, 1), x + w, y, w / 2, h);

            g.FillRectangle(new SolidBrush(Color.Blue), x, y + h, w / 2, h);
            g.DrawRectangle(new Pen(Color.Black, 1), x, y + h, w / 2, h);

            g.FillRectangle(new SolidBrush(Color.Blue), x + w / 2, y + h, w / 2, h);
            g.DrawRectangle(new Pen(Color.Black, 1), x + w / 2, y + h, w / 2, h);

            g.FillRectangle(new SolidBrush(Color.Blue), x, y - h / 2, w, h / 2);
            g.DrawRectangle(new Pen(Color.Black, 1), x, y - h / 2, w, h / 2);
        }
        public void Move(int speed_x, int speed_y)
        {
            x += speed_x;
            y += speed_y;
        }
        public Rectangle PR
        {
            get { return new Rectangle(x-w/2, y-h/2, 2*w, 2*h+h/2); }
        }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }
}
