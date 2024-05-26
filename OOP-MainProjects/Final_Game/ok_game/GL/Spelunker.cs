using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class Spelunker : GameObject
    {
        public Spelunker(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.PLAYER, DisplayImage)
        {
            this.CurrentCell = CurrentCell;
        }
        public GameCell Move(GameDirection direction, ref int score, ref int lives, ref bool isLevelComplete)
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            if(nextCell.currentGameObject.gameObjectType == GameObjectType.WinChar)
            {
                isLevelComplete = true;
            }
            if (nextCell.currentGameObject.gameObjectType == GameObjectType.REWARD)
                score = score + 10;
            else if (nextCell.currentGameObject.gameObjectType == GameObjectType.Life)
                lives = lives + 1;
            CurrentCell = nextCell;
            if (currentCell != nextCell)
                currentCell.SetGameObject(Game.GetBlankGameObject());
            return nextCell;
        }
    }
}
