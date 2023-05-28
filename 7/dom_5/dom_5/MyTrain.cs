using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom_5
{
    internal class MyTrain
    {
        int k;
        List<MyVagon> MyVagons;
        int x0, y0, l = 50;

        public MyTrain(int x0_, int y0_, int k_)
        {
            x0 = x0_;
            y0 = y0_;
            k = k_;
            random_mass();
        }


        public void random_mass()
        {
            Random random = new Random();
            MyVagons = new List<MyVagon>(k+1);
            int poss = x0;
            for (int i = 0; i < k; i++)
            {
                int type = random.Next(0, 3);
                if (type == 0)
                {
                    MyVagons.Add(new MyVagon(poss, y0, l));
                }
                else if (type == 1)
                {
                    MyVagons.Add(new MyVagonCoal(poss, y0, l));
                }
                else if (type == 2)
                {
                    MyVagons.Add(new MyVagonSand(poss, y0, l));
                }
                MyVagons[i].mass = random.Next(1, 10);
                poss = poss + l + 10;
            }
        }
        public void sum_mass()
        {
            int sum = 0;
            for(int i=0; i<k; i++)
            {
                sum = sum + MyVagons[i].mass;
            }
        }

        public void visual(Graphics g)
        {
            for(int i=0; i < k; i++)
            {
                MyVagons[i].visual(g);
            }
        }
    }
}
