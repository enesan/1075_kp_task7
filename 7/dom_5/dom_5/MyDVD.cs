using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyDVD
    {
        double x0;
        double y0;
        double L;
        double angle;
        double Angle
        {
            get { return angle; }
            set {
                if (value < 0)
                {
                    value = 360 - value;
                }
                angle = value%360;
            }
        }
        int speed;
        Image image;
        Random rnd;

        public MyDVD(int x0, int y0, int L, int speed)
        {
            rnd = new Random(DateTime.Now.Millisecond);
            this.x0 = x0;
            this.y0 = y0;
            this.L = L;
            this.speed = speed;
            this.Angle = rnd.Next();
            image = Image.FromFile("./maxresdefault-round.png");
        }

        public void visual(Graphics g)
        {
            g.DrawImage(image,
                Convert.ToInt32(x0),
                Convert.ToInt32(y0),
                Convert.ToInt32(L),
                Convert.ToInt32(L));
        }

        public void Tick()
        {
            x0 = x0 + speed * Math.Cos(Angle * Math.PI / 180);
            y0 = y0 - speed * Math.Sin(Angle * Math.PI / 180);
        }

        public void Collision(Panel panel, MyDVD myDVD)
        {
            if (x0 + L > panel.Width)
            {
                var znak = Math.Sin(Angle * Math.PI / 180) / Math.Abs(Math.Sin(Angle * Math.PI / 180));
                Angle = Angle + 90 * znak;
                collision();
            }
            else if (x0 < 0)
            {
                var znak = Math.Sin(Angle * Math.PI / 180) / Math.Abs(Math.Sin(Angle * Math.PI / 180));
                Angle = Angle - 90 * znak;
                collision();
            }
            else if (y0 + L > panel.Height)
            {
                Angle = 360 - Angle;
                collision();
            }
            else if (y0 < 0)
            {
                Angle = 360 - Angle;
                collision();
            }
        }

        void collision()
        {
            var bmp = (Bitmap)image;
            var R = rnd.Next(0, 255);
            var G = rnd.Next(0, 255);
            var B = rnd.Next(0, 255);
            for (var x = 0; x < bmp.Width; x+=4)
            {
                for (var y = 0; y < bmp.Height; y+=4)
                {
                    var p = bmp.GetPixel(x, y);
                    if (p.A == 0){
                        continue;
                    }
                    var r = (p.R + R) % 255;
                    var g = (p.G + G) % 255;
                    var b = (p.B + B) % 255;
                    var color = Color.FromArgb(r, g, b);
                    bmp.SetPixel(x,y,color);
                }
            }

        }
    }
}
