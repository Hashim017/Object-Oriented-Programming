using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ok_game
{
    class Game
    {
        public static int counter = 0;
        public static GameObject GetBlankGameObject()
        {
            GameObject blankGameObject = null;
            if (counter == 0)
            {
                blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.SimplePurpleBox);
            }
            else if (counter == 1)
            {
                blankGameObject = new GameObject(GameObjectType.NONE, Properties.Resources.simpleRedBox);
            }
            return blankGameObject;
        }
        public static GameObject GetRewardGameObject()
        {
            GameObject rewardGameObject = new GameObject(GameObjectType.REWARD, Properties.Resources.Reward);
            return rewardGameObject;
        }
        public static GameObject GetLifeGameObject()
        {
            GameObject lifeGameObject = new GameObject(GameObjectType.Life, Properties.Resources.Life);
            return lifeGameObject;
        }
        public static GameObject GetWinGameObject()
        {
            GameObject WinGameObject = new GameObject(GameObjectType.WinChar, Properties.Resources.Girl1);
            return WinGameObject;
        }
        public static Image GetGameObjectImage(char displayCharacter)
        {
            Image img = Properties.Resources.SimplePurpleBox;
            if (displayCharacter == '#' || displayCharacter == '|' || displayCharacter == '\\')
                img = Properties.Resources.vertical;
            else if (displayCharacter == '/' || displayCharacter == '%' || displayCharacter == '-')
                img = Properties.Resources.horizontal;
            else if (displayCharacter == '$')
                img = Properties.Resources.Reward;
            else if (displayCharacter == '+')
                img = Properties.Resources.Life;
            else if (displayCharacter == '&')
                img = Properties.Resources.Girl1;
            else if (displayCharacter == 'R')
                img = Properties.Resources.PlayerRight;
            else if (displayCharacter == 'L')
                img = Properties.Resources.PlayerLeft;
            else if (displayCharacter == 'r')
                img = Properties.Resources.EnemyRed;
            else if (displayCharacter == 'b')
                img = Properties.Resources.EnemyBlue;
            else if (displayCharacter == 'B')
                img = Properties.Resources.Bat;
            else if (displayCharacter == 'g')
                img = Properties.Resources.EnemyGreen;
            else if (displayCharacter == 'f')
                img = Properties.Resources.EnemyFire;
            else if (displayCharacter == 'k')
                img = Properties.Resources.EnemyRock;
            else if (displayCharacter == '>')
                img = Properties.Resources.BulletRight;
            else if (displayCharacter == '<')
                img = Properties.Resources.BulletLeft;
            else if (displayCharacter == '.')
                img = Properties.Resources.Argano;
            else if (displayCharacter == '*')
                img = Properties.Resources.EnemyBullet;

            return img;
        }

        public static Image GetGameObjectImage2(char displayCharacter)
        {
            Image img = Properties.Resources.simpleRedBox;
            if (displayCharacter == '#' || displayCharacter == '|' || displayCharacter == '\\')
                img = Properties.Resources.vertical;
            else if (displayCharacter == '/' || displayCharacter == '%' || displayCharacter == '-')
                img = Properties.Resources.horizontal;
            else if (displayCharacter == '$')
                img = Properties.Resources.Reward;
            else if (displayCharacter == '+')
                img = Properties.Resources.Life;
            else if (displayCharacter == '&')
                img = Properties.Resources.Girl1;
            else if (displayCharacter == 'R')
                img = Properties.Resources.PlayerRight;
            else if (displayCharacter == 'L')
                img = Properties.Resources.PlayerLeft;
            else if (displayCharacter == 'r')
                img = Properties.Resources.EnemyRed;
            else if (displayCharacter == 'b')
                img = Properties.Resources.EnemyBlue;
            else if (displayCharacter == 'g')
                img = Properties.Resources.EnemyGreen;
            else if (displayCharacter == 'f')
                img = Properties.Resources.EnemyFire;
            else if (displayCharacter == 'k')
                img = Properties.Resources.EnemyRock;
            else if (displayCharacter == '>')
                img = Properties.Resources.BulletRight;
            else if (displayCharacter == '<')
                img = Properties.Resources.BulletLeft;
            else if (displayCharacter == '.')
                img = Properties.Resources.EnemyBullet;

            return img;
        }
    }
}
