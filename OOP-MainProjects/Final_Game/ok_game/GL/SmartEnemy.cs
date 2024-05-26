using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class SmartEnemy : Enemies
    {
        GameObject Spelunker;
        public SmartEnemy(Image image, GameCell CurrentCell, GameObject s, int lives, bool alive) : base(GameObjectType.ENEMY, image, lives, alive)
        {
            Spelunker = s;
            this.CurrentCell = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell returnCell;
            GameCell currentCell = CurrentCell;
            GameCell upCell = currentCell.NextCell(GameDirection.UP);
            GameCell downCell = currentCell.NextCell(GameDirection.DOWN);
            GameCell leftCell = currentCell.NextCell(GameDirection.LEFT);
            GameCell rightCell = currentCell.NextCell(GameDirection.RIGHT);

            double UpCD = GameGrid.Get_Distance(upCell, Spelunker.currentCell);
            double DownCD = GameGrid.Get_Distance(downCell, Spelunker.currentCell);
            double LeftCD = GameGrid.Get_Distance(leftCell, Spelunker.currentCell);
            double RightCD = GameGrid.Get_Distance(rightCell, Spelunker.currentCell);

            if (RightCD < DownCD && RightCD < LeftCD && RightCD < UpCD)
            {
                returnCell = rightCell;
            }
            else if (DownCD < UpCD && DownCD < LeftCD && DownCD < RightCD)
            {
                returnCell = downCell;
            }
            else if (LeftCD < RightCD && LeftCD < UpCD && LeftCD < DownCD)
            {
                returnCell = leftCell;
            }
            else
            {
                returnCell = upCell;
            }
            currentCell.SetGameObject(Game.GetBlankGameObject());

            GameObjectType type = returnCell.CurrentGameObject.GameObjectType;
            CurrentCell = returnCell;
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());

            return returnCell;
        }
    }
}
