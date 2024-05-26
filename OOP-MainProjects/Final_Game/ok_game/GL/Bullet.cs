﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class Bullet : GameObject
    {
        GameDirection direction;
        int bulletX;
        int bulletY;
        public Bullet(Image image, GameCell CurrentCell, GameDirection direction, int bulletX, int bulletY) : base(GameObjectType.Bullet, image)
        {
            this.direction = direction;
            this.CurrentCell = CurrentCell;
            this.bulletX = bulletX;
            this.bulletY = bulletY;
        }

        public GameCell MoveBulletRight()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell = nextCell;
            if (nextCell == currentCell)
            {
                nextCell = currentCell.NextCell(direction);
                CurrentCell = nextCell;
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());
            else if (type == GameObjectType.Life)
                currentCell.SetGameObject(Game.GetLifeGameObject());
            else if (type == GameObjectType.WinChar)
                currentCell.SetGameObject(Game.GetWinGameObject());
            else
                currentCell.SetGameObject(Game.GetBlankGameObject());

            return nextCell;
        }

        public GameCell MoveBulletLeft()
        {
            GameCell currentCell = CurrentCell;
            GameCell nextCell = currentCell.NextCell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell = nextCell;
            if (nextCell == currentCell)
            {
                nextCell = currentCell.NextCell(direction);
                CurrentCell = nextCell;
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.GetRewardGameObject());
            else if (type == GameObjectType.Life)
                currentCell.SetGameObject(Game.GetLifeGameObject());
            else if (type == GameObjectType.WinChar)
                currentCell.SetGameObject(Game.GetWinGameObject());
            else
                currentCell.SetGameObject(Game.GetBlankGameObject());

            return nextCell;
        }
    }
}