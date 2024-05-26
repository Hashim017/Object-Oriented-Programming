using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class Collision
    {
        // collision check of any enemy with player

        public static bool EnemyCollisionWithSpelunker(GameObject player, GameObject enemy)
        {
            if (player.currentCell.X == enemy.currentCell.X && player.currentCell.Y == enemy.currentCell.Y)
                return true;
            return false;
        }

        // collision check of any enemy with player bullets

        public static bool EnemyCollisionWithSpelunkerBullet(GameObject bullet, GameObject enemy)
        {
            if ((bullet.currentCell.X == enemy.currentCell.X && bullet.currentCell.Y == enemy.currentCell.Y) || (bullet.currentCell.X == enemy.currentCell.X && bullet.currentCell.Y == enemy.currentCell.Y - 1) || (bullet.currentCell.X == enemy.currentCell.X && bullet.currentCell.Y == enemy.currentCell.Y + 1))
                return true;
            return false;
        }

        // collision check of any enemy bullets with player

        public static bool EnemyBulletCollisionWithSpelunker(Spelunker spelunker, GameObject bullet)
        {
            if ((bullet.currentCell.X == spelunker.currentCell.X && bullet.currentCell.Y == spelunker.currentCell.Y))
            {
                return true;
            }
            return false;
        }
    }
}
