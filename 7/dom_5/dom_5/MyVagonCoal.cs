using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyVagonCoal: MyVagon
    {
        MyReqtangle coal;
        public MyVagonCoal(int x0, int y0, int L): base(x0, y0, L)
        {
            coal = new MyReqtangle(x0 + 5, x0 + L - 5, y0 - L / 4, y0, new SolidBrush(Color.Black));
        }

        public override void visual(Graphics g)
        {
            base.visual(g);
            coal.visual_reqtungle(g);
        }
    }
}
