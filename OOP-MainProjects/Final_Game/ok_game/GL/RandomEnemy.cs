using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class RandomEnemy : Enemies
    {
        public RandomEnemy(Image image, GameCell CurrentCell, int lives, bool alive) : base(GameObjectType.ENEMY, image, lives, alive)
        {
            this.CurrentCell = CurrentCell;
        }

        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = null;
            GameObjectType type = GameObjectType.NONE;
            while (nextCell == null)
            {
                GameDirection random = Get_Random_Direction();
                nextCell = currentCell.NextCell(random);
                type = nextCell.CurrentGameObject.GameObjectType;
                CurrentCell = nextCell;
                currentCell.SetGameObject(Game.GetBlankGameObject());
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());
            else
                currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
        private GameDirection Get_Random_Direction()
        {
            GameDirection randomDirection;
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if (number == 1)
                randomDirection = GameDirection.UP;
            else if (number == 2)
                randomDirection = GameDirection.DOWN;
            else if (number == 3)
                randomDirection = GameDirection.LEFT;
            else
                randomDirection = GameDirection.RIGHT;

            return randomDirection;
        }
    }
}
