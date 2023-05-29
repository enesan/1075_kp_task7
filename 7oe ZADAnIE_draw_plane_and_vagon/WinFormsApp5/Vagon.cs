using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Vagon
    {
        private int x, y, h, w;
        private int y1, r1;
        public int X { get { return x; } set { x = value; } }
        public Vagon()
        {
            x = 100;
            y = 100; 
            h = 60;
            w = 100;
            y1 = 160;
            r1 = 30;
        }
        public void Visual(Graphics gr)
        {
            Pen blackpen = new Pen(Color.Black, 3);
            gr.DrawRectangle(blackpen, x, y, w, h);
            gr.DrawEllipse(blackpen, x, y1, r1, r1);
            gr.DrawEllipse(blackpen, x + 70, y1, r1, r1);
        }
    }
}
