using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD___3__Game_
{
    class LivesNscore
    {
        public int score;
        public int playerLives;
        public int enemyLives;

        public LivesNscore()
        {
            score = 0;
            playerLives = 5;
            enemyLives = 10;
        }

        public void addScore(ref int score)
        {
            score = score + 10;
        }

        public void enemyLife(ref int life)
        {
            life = life - 1;
        }

        public void playerLife(ref int life)
        {
            life = life - 1;
        }
    }
}
