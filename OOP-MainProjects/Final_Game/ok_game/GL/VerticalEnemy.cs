using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class VerticalEnemy :Enemies
    {
        GameDirection direction;
        public VerticalEnemy(Image image, GameCell CurentCell, GameDirection direction, int lives, bool alive) : base(GameObjectType.ENEMY, image, lives, alive)
        {
            this.direction = direction;
            this.CurrentCell = CurentCell;
        }
        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell = nextCell;
            if (nextCell == currentCell)
            {
                if (direction == GameDirection.UP)
                    direction = GameDirection.DOWN;
                else
                    direction = GameDirection.UP;

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
