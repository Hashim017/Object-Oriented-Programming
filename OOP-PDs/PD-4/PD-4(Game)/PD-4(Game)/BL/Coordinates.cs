﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_4_Game_.BL
{
    class Coordinates
    {
        public int playerX;
        public int playerY;
        public int enemyX;
        public int enemyY;

        public Coordinates()
        {
            playerX = 6;
            playerY = 10;
            enemyX = 4;
            enemyY = 49;
        }

        public void moveRight(ref int playerY)
        {
            playerY = playerY + 1;
        }

        public void moveLeft(ref int playerY)
        {
            playerY = playerY - 1;
        }

        public void moveUp(ref int playerX)
        {
            playerX = playerX - 1;
        }

        public void moveDown(ref int playerX)
        {
            playerX = playerX + 1;
        }

        public void moveEnemy(ref int enemyX)
        {
            enemyX = enemyX + 1;
        }
    }
}
