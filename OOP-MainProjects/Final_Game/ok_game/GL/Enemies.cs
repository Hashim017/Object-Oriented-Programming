using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    abstract class Enemies : GameObject
    {
        public int lives;
        public bool isEnemyAlive;
        public Enemies(GameObjectType type, Image displayImage, int lives, bool alive) : base(type, displayImage)
        {
            this.isEnemyAlive = alive;
            this.lives = lives;
        }
        public abstract GameCell Move();
    }
}
