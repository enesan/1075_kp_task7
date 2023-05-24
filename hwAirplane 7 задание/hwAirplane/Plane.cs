using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwAirplane
{
    internal class Plane
    {
        private int x, y, dx, dy, width, height;
        private Color color;
        private Random random = new Random();

        public Plane(int x, int y, int dx, int dy, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.width = width;
            this.height = height;
            this.color = color;
        }

        public void Draw(Graphics g)
        {
            Point[] points = new Point[5];
            points[0] = new Point(x, y + height / 2);
            points[1] = new Point(x + width / 2, y);
            points[2] = new Point(x + width, y + height / 2);
            points[3] = new Point(x + width / 2, y + height);
            points[4] = new Point(x, y + height / 2);

            g.FillPolygon(new SolidBrush(color), points);
        }

        public void Move(int screenWidth, int screenHeight)
        {
            x += dx;
            y += dy;

            if (x < 0 || x > screenWidth)
            {
                dx = -dx;
                color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            }
            if (y < 0 || y > screenHeight)
            {
                dy = -dy;
                color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            }
        }

        public bool CheckCollision(Plane other)
        {
            Rectangle rect1 = new Rectangle(x, y, width, height);
            Rectangle rect2 = new Rectangle(other.x, other.y, other.width, other.height);
            return rect1.IntersectsWith(rect2);
        }

        public void ResolveCollision(Plane other)
        {
            dx = -dx;
            dy = -dy;
            other.dx = -other.dx;
            other.dy = -other.dy;
        }
    }

}
