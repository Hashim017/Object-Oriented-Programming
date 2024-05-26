using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace ok_game
{
        // LEVEL 1
    partial class Level1 : Form
    {
        // Global variables, arrays and lists

        public Spelunker spelunker;
        public GameCell startCell;
        public GameGrid grid = new GameGrid(28, 63);
        Bullet[] bulletsRight = new Bullet[1000];
        Bullet[] bulletsLeft = new Bullet[1000];
        bool[] isBulletRightActive = new bool[1000];
        bool[] isBulletLeftActive = new bool[1000];
        int bulletRightCount = 0;
        int bulletLeftCount = 0;
        Bullet[] enemy1Bullets = new Bullet[1000];
        int enemy1BulletCount = 0;
        Bullet[] enemy2Bullets = new Bullet[1000];
        int enemy2BulletCount = 0;
        int score = 0;
        int lives = 3;
        bool isLevel1Complete = false;
        public HorizontalEnemy enemyH1 = null;
        public HorizontalEnemy enemyH3 = null;
        public List<Enemies> enemies = new List<Enemies>();

        public Level1()
        {
            InitializeComponent();
            grid.LoadGrid("maze1.txt");
        }


        // game running timer for player and bullets

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if(isLevel1Complete == true)
            {
                GameLoop.Enabled = false;
                GhostTimer.Enabled = false;
                MessageBox.Show("You Completed Level ... !", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                Level2 level = new Level2();
                level.passInfo(grid, this.lives, this.score);
                Game.counter++;
                level.Show();
            }
            if (enemyH1.isEnemyAlive == false)
            {
                for (int x = 0; x < enemy1BulletCount; x++)
                {
                    enemy1Bullets[x].currentCell.SetGameObject(Game.GetBlankGameObject());
                }
            }
            if (enemyH3.isEnemyAlive == false)
            {
                for (int x = 0; x < enemy2BulletCount; x++)
                {
                    enemy2Bullets[x].currentCell.SetGameObject(Game.GetBlankGameObject());
                }
            }
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                storeData();
                this.Close();
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                Image playerLeft = Game.GetGameObjectImage('L');
                spelunker = new Spelunker(playerLeft, spelunker.currentCell);
                spelunker.Move(GameDirection.LEFT, ref score, ref lives, ref isLevel1Complete);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                Image playerRight = Game.GetGameObjectImage('R');
                spelunker = new Spelunker(playerRight, spelunker.currentCell);
                spelunker.Move(GameDirection.RIGHT, ref score, ref lives, ref isLevel1Complete);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                spelunker.Move(GameDirection.UP, ref score, ref lives, ref isLevel1Complete);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                spelunker.Move(GameDirection.DOWN, ref score, ref lives, ref isLevel1Complete);
            }
            if (Keyboard.IsKeyPressed(Key.S))
            {
                generateBulletRight();
            }
            if (Keyboard.IsKeyPressed(Key.A))
            {
                generateBulletLeft();
            }

            generateEnemy1Bullet();

            generateEnemy2Bullet();

            moveBulletLeft();

            moveBulletRight();

            ScoreBox.Text = score.ToString();
            LivesBox.Text = lives.ToString();

            if (lives <= 0)
            {
                GameLoop.Enabled = false;
                GhostTimer.Enabled = false;
                GameOverLabel.Visible = true;
            }
        }

        // store current progress into file

        private void storeData()
        {
            StreamWriter data = new StreamWriter("SpelunkerInformation.txt");
            data.WriteLine(spelunker.currentCell.x + "," + spelunker.currentCell.y + "," + lives + "," + score + "," + isLevel1Complete);
            data.Close();

            StreamWriter file = new StreamWriter("EnemiesInformation.txt");
            for (int x = 0; x < enemies.Count; x++)
            {
                file.WriteLine(enemies[x].isEnemyAlive);
            }
            file.Close();
        }

        // load data from file for game load

        public void loadData()
        {
            string record = "";
            string X = "", Y = "", live = "", score = "";
            StreamReader data = new StreamReader("SpelunkerInformation.txt");
            while ((record = data.ReadLine()) != null)
            {
                X = (findData(record, 1));
                Y = (findData(record, 2));
                live = (findData(record, 3));
                score = (findData(record, 4));
            }
            data.Close();
            Image img = Game.GetGameObjectImage('R');
            startCell = grid.GetCell(int.Parse(X), int.Parse(Y));
            this.lives = int.Parse(live);
            this.score = int.Parse(score);
            spelunker = new Spelunker(img, startCell);
            Image enemyH1Image = Game.GetGameObjectImage('B');
            GameCell enemyH1Cell = grid.GetCell(3, 19);
            enemyH1 = new HorizontalEnemy(enemyH1Image, enemyH1Cell, GameDirection.RIGHT, 3, true);

            Image enemyH2Image = Game.GetGameObjectImage('g');
            GameCell enemyH2Cell = grid.GetCell(16, 50);
            HorizontalEnemy enemyH2 = new HorizontalEnemy(enemyH2Image, enemyH2Cell, GameDirection.RIGHT, 3, true);

            Image enemyH3Image = Game.GetGameObjectImage('r');
            GameCell enemyH3Cell = grid.GetCell(15, 35);
            enemyH3 = new HorizontalEnemy(enemyH3Image, enemyH3Cell, GameDirection.RIGHT, 3, true);

            Image enemyH4Image = Game.GetGameObjectImage('b');
            GameCell enemyH4Cell = grid.GetCell(21, 45);
            HorizontalEnemy enemyH4 = new HorizontalEnemy(enemyH4Image, enemyH4Cell, GameDirection.RIGHT, 3, true);

            Image enemyV1Image = Game.GetGameObjectImage('f');
            GameCell enemyV1Cell = grid.GetCell(8, 34);
            VerticalEnemy enemyV1 = new VerticalEnemy(enemyV1Image, enemyV1Cell, GameDirection.DOWN, 3, true);

            Image enemyV2Image = Game.GetGameObjectImage('k');
            GameCell enemyV2Cell = grid.GetCell(8, 5);
            VerticalEnemy enemyV2 = new VerticalEnemy(enemyV2Image, enemyV2Cell, GameDirection.DOWN, 3, true);

            Image enemyV3Image = Game.GetGameObjectImage('f');
            GameCell enemyV3Cell = grid.GetCell(25, 51);
            VerticalEnemy enemyV3 = new VerticalEnemy(enemyV3Image, enemyV3Cell, GameDirection.DOWN, 3, true);

            Image enemySImage = Game.GetGameObjectImage('b');
            GameCell enemySCell = grid.GetCell(10, 15);
            SmartEnemy enemyS = new SmartEnemy(enemySImage, enemySCell, spelunker, 4, true);

            Image enemyRImage = Game.GetGameObjectImage('r');
            GameCell enemyRCell = grid.GetCell(3, 43);
            RandomEnemy enemyR = new RandomEnemy(enemyRImage, enemyRCell, 5, true);

            enemies.Add(enemyH1);
            enemies.Add(enemyH2);
            enemies.Add(enemyH3);
            enemies.Add(enemyH4);
            enemies.Add(enemyV1);
            enemies.Add(enemyV2);
            enemies.Add(enemyV3);
            enemies.Add(enemyR);
            enemies.Add(enemyS);

            PrintMaze(grid);

            StreamReader file = new StreamReader("EnemiesInformation.txt");
            int index = 0;
            while ((record = file.ReadLine()) != null)
            {
                enemies[index].isEnemyAlive = bool.Parse(record);
                index++;
            }
            file.Close();

            for (int x = 0; x < enemies.Count; x++)
            {
                if (enemies[x].isEnemyAlive == false)
                {
                    enemies[x].currentCell.SetGameObject(Game.GetBlankGameObject());
                }
            }
        }

        static string findData(string record, int field)
        {
            int comma = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }

                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        // code for start game

        public void startGame()
        {
            Image playerRight = Game.GetGameObjectImage('R');
            startCell = grid.GetCell(3, 3);
            spelunker = new Spelunker(playerRight, startCell);

            Image enemyH1Image = Game.GetGameObjectImage('B');
            GameCell enemyH1Cell = grid.GetCell(3, 19);
            enemyH1 = new HorizontalEnemy(enemyH1Image, enemyH1Cell, GameDirection.RIGHT, 3, true);

            Image enemyH2Image = Game.GetGameObjectImage('g');
            GameCell enemyH2Cell = grid.GetCell(16, 50);
            HorizontalEnemy enemyH2 = new HorizontalEnemy(enemyH2Image, enemyH2Cell, GameDirection.RIGHT, 3, true);

            Image enemyH3Image = Game.GetGameObjectImage('r');
            GameCell enemyH3Cell = grid.GetCell(15, 35);
            enemyH3 = new HorizontalEnemy(enemyH3Image, enemyH3Cell, GameDirection.RIGHT, 3, true);

            Image enemyH4Image = Game.GetGameObjectImage('b');
            GameCell enemyH4Cell = grid.GetCell(21, 45);
            HorizontalEnemy enemyH4 = new HorizontalEnemy(enemyH4Image, enemyH4Cell, GameDirection.RIGHT, 3, true);

            Image enemyV1Image = Game.GetGameObjectImage('f');
            GameCell enemyV1Cell = grid.GetCell(8, 34);
            VerticalEnemy enemyV1 = new VerticalEnemy(enemyV1Image, enemyV1Cell, GameDirection.DOWN, 3, true);

            Image enemyV2Image = Game.GetGameObjectImage('k');
            GameCell enemyV2Cell = grid.GetCell(8, 5);
            VerticalEnemy enemyV2 = new VerticalEnemy(enemyV2Image, enemyV2Cell, GameDirection.DOWN, 3, true);

            Image enemyV3Image = Game.GetGameObjectImage('f');
            GameCell enemyV3Cell = grid.GetCell(25, 51);
            VerticalEnemy enemyV3 = new VerticalEnemy(enemyV3Image, enemyV3Cell, GameDirection.DOWN, 3, true);

            Image enemySImage = Game.GetGameObjectImage('b');
            GameCell enemySCell = grid.GetCell(10, 15);
            SmartEnemy enemyS = new SmartEnemy(enemySImage, enemySCell, spelunker, 4, true);

            Image enemyRImage = Game.GetGameObjectImage('r');
            GameCell enemyRCell = grid.GetCell(3, 43);
            RandomEnemy enemyR = new RandomEnemy(enemyRImage, enemyRCell, 5, true);

            enemies.Add(enemyH1);
            enemies.Add(enemyH2);
            enemies.Add(enemyH3);
            enemies.Add(enemyH4);
            enemies.Add(enemyV1);
            enemies.Add(enemyV2);
            enemies.Add(enemyV3);
            enemies.Add(enemyR);
            enemies.Add(enemyS);

            PrintMaze(grid);
        }

        // generate enemy 1 bullets when moving left if enemy is alive

        private void generateEnemy1Bullet()
        {
            if (enemyH1.isEnemyAlive)
            {
                if (enemyH1.direction == GameDirection.RIGHT)
                {
                    if (enemyH1.isEnemyAlive)
                    {
                        Image image = Game.GetGameObjectImage('.');
                        GameCell enemy2BulletCell = grid.GetCell(enemyH1.currentCell.x, enemyH1.currentCell.y - 1);
                        enemy2Bullets[enemy2BulletCount] = new Bullet(image, enemy2BulletCell, GameDirection.LEFT, enemyH1.currentCell.x, enemyH1.currentCell.y - 1);
                        enemy2BulletCount++;
                    }
                }

                for (int x = 0; x < enemy2BulletCount; x++)
                {
                    enemy2Bullets[x].MoveBulletLeft();
                    if (Collision.EnemyBulletCollisionWithSpelunker(spelunker, enemy2Bullets[x]))
                    {
                        if (lives > 0)
                        {
                            lives--;
                        }
                    }
                }
            }
        }

        // generate enemy 3 bullets when moving left if enemy is alive

        private void generateEnemy2Bullet()
        {
            if (enemyH3.isEnemyAlive)
            {
                if (enemyH3.direction == GameDirection.RIGHT)
                {
                    if (enemyH3.isEnemyAlive)
                    {
                        Image image = Game.GetGameObjectImage('*');
                        GameCell enemy1BulletCell = grid.GetCell(enemyH3.currentCell.x, enemyH3.currentCell.y - 1);
                        enemy1Bullets[enemy1BulletCount] = new Bullet(image, enemy1BulletCell, GameDirection.LEFT, enemyH3.currentCell.x, enemyH3.currentCell.y - 1);
                        enemy1BulletCount++;
                    }
                }

                for (int x = 0; x < enemy1BulletCount; x++)
                {
                    enemy1Bullets[x].MoveBulletLeft();
                    if (Collision.EnemyBulletCollisionWithSpelunker(spelunker, enemy1Bullets[x]))
                    {
                        if (lives > 0)
                        {
                            lives--;
                        }
                    }
                }
            }
        }

        // generate player bullets towards left

        private void generateBulletLeft()
        {
            Image bulletImage = Game.GetGameObjectImage('<');
            GameCell bullet = grid.GetCell(spelunker.currentCell.x, spelunker.currentCell.y - 1);
            bulletsLeft[bulletLeftCount] = new Bullet(bulletImage, bullet, GameDirection.LEFT, spelunker.currentCell.x, spelunker.currentCell.y - 1);
            isBulletLeftActive[bulletLeftCount] = true;
            bulletLeftCount++;
        }

        // generate player bullets towards Right 

        private void generateBulletRight()
        {
            Image bulletImage = Game.GetGameObjectImage('>');
            GameCell bullet = grid.GetCell(spelunker.currentCell.x, spelunker.currentCell.y + 1);
            bulletsRight[bulletRightCount] = new Bullet(bulletImage, bullet, GameDirection.RIGHT, spelunker.currentCell.x, spelunker.currentCell.y + 1);
            isBulletRightActive[bulletRightCount] = true;
            bulletRightCount++;
        }

        // move player bullets towards left

        private void moveBulletLeft()
        {
            for (int x = 0; x < bulletLeftCount; x++)
            {
                if (isBulletLeftActive[x])
                {
                    bulletsLeft[x].MoveBulletLeft();
                    for (int y = 0; y < enemies.Count; y++)
                    {
                        if (Collision.EnemyCollisionWithSpelunkerBullet(bulletsLeft[x], enemies[y]))
                        {
                            if (enemies[y].lives > 0)
                            {
                                isBulletLeftActive[x] = false;
                                enemies[y].lives--;
                            }
                            else if (enemies[y].lives <= 0)
                            {
                                enemies[y].isEnemyAlive = false;
                                enemies[y].currentCell.currentGameObject = Game.GetBlankGameObject();
                                bulletsLeft[x].currentCell.currentGameObject = Game.GetBlankGameObject();
                            }
                            score++;
                        }
                    }
                }
            }
        }

        // generate player bullets towards Right

        private void moveBulletRight()
        {
            for (int x = 0; x < bulletRightCount; x++)
            {
                if (isBulletRightActive[x])
                {
                    bulletsRight[x].MoveBulletRight();
                    for (int y = 0; y < enemies.Count; y++)
                    {
                        if (Collision.EnemyCollisionWithSpelunkerBullet(bulletsRight[x], enemies[y]))
                        {
                            if (enemies[y].lives > 0)
                            {
                                isBulletRightActive[x] = false;
                                enemies[y].lives--;
                            }
                            else if (enemies[y].lives <= 0)
                            {
                                enemies[y].isEnemyAlive = false;
                                enemies[y].currentCell.currentGameObject = Game.GetBlankGameObject();
                                bulletsRight[x].currentCell.currentGameObject = Game.GetBlankGameObject();
                            }
                            score++;
                        }
                    }
                }
            }
        }

        // print maze for level 1

        public void PrintMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    Controls.Add(cell.PictureBox);
                }
            }
        }

        // function for checking collision of enemy with player

        private void GameRunning(Enemies enemy)
        {
            if (Collision.EnemyCollisionWithSpelunker(spelunker, enemy))
            {
                if (lives > 0)
                {
                    lives--;
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
        }

        // game running timer for enemies

        private void GhostTimer_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < enemies.Count; x++)
            {
                if (enemies[x].isEnemyAlive)
                {
                    enemies[x].Move();
                    GameRunning(enemies[x]);
                }

            }
        }

        // code for restart game

        private void RestartButton_Click_1(object sender, EventArgs e)
        {
            GameLoop.Enabled = false;
            GhostTimer.Enabled = false;
            MessageBox.Show("Restarting the Game : All your progress will be lost", "RESTART", MessageBoxButtons.OK);
            Application.Restart();
        }

        private void GameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void LivesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LivesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ScoreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
