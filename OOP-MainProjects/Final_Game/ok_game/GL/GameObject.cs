﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class GameObject
    {
        public char displayCharacter;
        public GameCell currentCell;
        public GameObjectType gameObjectType;
        public Image image;
        public GameObject(GameObjectType gameObjectType, Image Image)
        {
            this.gameObjectType = gameObjectType;
            this.Image = Image;
        }
        public static GameObjectType GetGameObjectType(char DisplayCharacter)
        {
            if (DisplayCharacter == '|' || DisplayCharacter == '#' || DisplayCharacter == '%' || DisplayCharacter == '/')
                return GameObjectType.WALL;
            else if (DisplayCharacter == '$')
                return GameObjectType.REWARD;
            else if (DisplayCharacter == '&')
                return GameObjectType.WinChar;
            else if (DisplayCharacter == '+')
                return GameObjectType.Life;
            else
                return GameObjectType.NONE;
        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.SetGameObject(this);
            }
        }
        public Image Image { get => image; set => image = value; }
    }
}
