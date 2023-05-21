using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KJLuKeP_TTpO
{
    internal class Game
    {
        private int score, passive, sila;
        
        public Game(int score, int passive, int sila)
        {
            this.score = score;
            this.passive = passive;
            this.sila = sila;
        }

        public void up_sila()
        {
            score -= sila * 250;
            sila += 1;
        }

        public int get_sila()
        {
            return sila;
        }

        public int get_up_value()
        {
            return sila * 250;
        }

        public int click()
        {
            score+= sila;
            return score;
        }

        public void get_passive()
        {
            score += passive;
        }
        public int get_passive_value()
        {
            return passive;
        }

        public int get_score()
        {
            return score;
        }

        public void get_grandmo()
        {
            score -= 20;
            passive += 1;
        }
        public void get_farm()
        {
            score -= 100;
            passive += 5;
        }

        public void get_zavod()
        {
            score -= 500;
            passive += 25;
        }

        public void get_office()
        {
            score -= 2500;
            passive += 120;
        }

    }
}
