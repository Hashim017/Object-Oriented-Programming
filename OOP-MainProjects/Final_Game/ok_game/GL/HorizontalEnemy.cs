using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class HorizontalEnemy : Enemies
    {
        public GameDirection direction;
        public HorizontalEnemy(Image image, GameCell CurrentCell, GameDirection direction, int lives, bool alive) : base(GameObjectType.ENEMY, image, lives, alive)
        {
            this.direction = direction;
            this.CurrentCell = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell = nextCell;
            if (nextCell == currentCell)
            {
                if (direction == GameDirection.RIGHT)
                {
                    direction = GameDirection.LEFT;
                }
                else
                {
                    direction = GameDirection.RIGHT;

                }

                nextCell = currentCell.NextCell(direction);
                CurrentCell = nextCell;
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());
            else
                currentCell.SetGameObject(Game.GetBlankGameObject());

            return nextCell;
        }
    }
}
