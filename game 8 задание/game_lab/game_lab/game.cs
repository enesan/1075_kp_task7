using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_lab
{
    internal class game
    {
        int n;
        pole[,] matrix;
        player player;
        Random rnd;
        bool IsLive;
        int lvl;
        int chance;
        int x1, y1, x2, y2;
        Rectangle r;
        public game(int n)
        {
            lvl = 0;
            IsLive = true;
            player = new player(110, 110);
            rnd = new Random();
            this.n = n;
            matrix = new pole[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if ((i == 0 && j == 0) || (i == n - 1 && j == n - 1))
                        matrix[i, j] = new pole(100 + 50 * i, 100 + 50 * j, 0);
                    else
                    {
                        chance = rnd.Next(101);
                        if (chance <= 50)
                            matrix[i, j] = new pole(100 + 50 * i, 100 + 50 * j, 0);
                        else if (chance <= 80 && chance > 50)
                            matrix[i, j] = new pole(100 + 50 * i, 100 + 50 * j, 1);
                        else if (chance <= 90 && chance > 80)
                            matrix[i, j] = new pole(100 + 50 * i, 100 + 50 * j, 2);
                        else
                            matrix[i, j] = new pole(100 + 50 * i, 100 + 50 * j, 3);
                    }

                }
            x1 = matrix[0, 0].X;
            y1 = matrix[0, 0].Y;
            x2 = matrix[n - 1, n - 1].X;
            y2 = matrix[n - 1, n - 1].Y;
            r = new Rectangle(x1, y1, x2 - x1 + 50, y2 - y1 + 50);
        }
        public void Draw(Graphics g)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j].Draw(g);
            player.Draw(g);
        }
        public void Move(KeyEventArgs e)
        {
            if (player.X >= x1 && player.X <= x2 + 40 && player.Y >= y1 && player.Y <= y2 + 40)
                switch (e.KeyCode)
                {
                    case Keys.A:
                        player.Move(-5, 0);
                        break;
                    case Keys.D:
                        player.Move(5, 0);
                        break;
                    case Keys.W:
                        player.Move(0, -5);
                        break;
                    case Keys.S:
                        player.Move(0, 5);
                        break;
                }
            else if (player.X < x1)
            {
                player.Move(10, 0);
            }
            else if (player.X > x2 + 40)
            {
                player.Move(-10, 0);
            }
            else if (player.Y < y1)
            {
                player.Move(0, 10);
            }
            else if (player.Y > y2 + 40)
            {
                player.Move(0, -10);
            }
        }
        public bool Touch_red()
        {
            foreach (pole p in matrix)
                if (p.col == Color.Red)
                    if (player.PR.IntersectsWith(p.R))
                    {
                        IsLive = false;
                    }
            return IsLive;
        }
        public void Touch_black()
        {
            if (lvl < 5)
            {
                foreach (pole p in matrix)
                    if (p.col == Color.Black)
                    {
                        if (player.PR.IntersectsWith(p.R))
                        {
                            if (p.Y > player.Y)
                            {
                                player.Move(0, -5);
                            }
                            else if (p.Y + p.H < player.Y)
                            {
                                player.Move(0, 5);
                            }
                            else if (p.X < player.X)
                            {
                                player.Move(5, 0);
                            }
                            else if (p.X > player.X)
                            {
                                player.Move(-5, 0);
                            }
                        }
                    }
            }
            else
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j].col == Color.Black)
                        {
                            if (player.PR.IntersectsWith(matrix[i, j].R))
                            {
                                matrix[i, j] = new pole(matrix[i, j].X, matrix[i, j].Y, 4);
                            }
                        }
                    }
            }
        }
        public void Touch_g_w()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (matrix[i, j].col == Color.Green)
                    {
                        if (player.PR.IntersectsWith(matrix[i, j].R))
                        {
                            lvl++;
                            matrix[i, j] = new pole(matrix[i, j].X, matrix[i, j].Y, 4);
                        }
                    }
                    else if (matrix[i, j].col == Color.White)
                    {
                        if (player.PR.IntersectsWith(matrix[i, j].R))
                        {
                            matrix[i, j] = new pole(matrix[i, j].X, matrix[i, j].Y, 4);
                        }
                    }
                }
            }
        }
        bool win = false;
        public bool Win()
        {
            foreach (pole p in matrix)
            {
                if (p.col == Color.White || p.col == Color.Green)
                {
                    win = false;
                    break;
                }
                else
                {
                    win = true;
                }
            }
            return win;
        }
    }
}
