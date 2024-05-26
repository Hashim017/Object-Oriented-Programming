using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace ok_game
{
        // level 2
    
    partial class Level2 : Form
    {
        //global variables, arrays and lists
        
        GameGrid grid = null;
        Spelunker spelunker;
        GameCell startCell;
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
        int score;
        int lives;
        bool isLevel2Complete = false;
        HorizontalEnemy enemyH1 = null;
        HorizontalEnemy enemyH2 = null;
        List<Enemies> enemies = new List<Enemies>();

        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            level2();
        }

        // fuction for initializing objects, player and enemies

        private void level2()
        {
            Image playerRight = Game.GetGameObjectImage('R');
            startCell = grid.GetCell(3, 3);
            spelunker = new Spelunker(playerRight, startCell);

            Image enemyH1Image = Game.GetGameObjectImage('B');
            GameCell enemyH1Cell = grid.GetCell(16, 50);
            enemyH1 = new HorizontalEnemy(enemyH1Image, enemyH1Cell, GameDirection.RIGHT, 3, true);

            Image enemyH2Image = Game.GetGameObjectImage('g');
            GameCell enemyH2Cell = grid.GetCell(7, 23);
            enemyH2 = new HorizontalEnemy(enemyH2Image, enemyH2Cell, GameDirection.RIGHT, 3, true);

            Image enemyV1Image = Game.GetGameObjectImage('f');
            GameCell enemyV1Cell = grid.GetCell(4, 18);
            VerticalEnemy enemyV1 = new VerticalEnemy(enemyV1Image, enemyV1Cell, GameDirection.DOWN, 3, true);

            Image enemyV2Image = Game.GetGameObjectImage('k');
            GameCell enemyV2Cell = grid.GetCell(8, 5);
            VerticalEnemy enemyV2 = new VerticalEnemy(enemyV2Image, enemyV2Cell, GameDirection.DOWN, 3, true);

            Image enemyV3Image = Game.GetGameObjectImage('b');
            GameCell enemyV3Cell = grid.GetCell(23, 20);
            VerticalEnemy enemyV3 = new VerticalEnemy(enemyV3Image, enemyV3Cell, GameDirection.DOWN, 3, true);

            Image enemyV4Image = Game.GetGameObjectImage('f');
            GameCell enemyV4Cell = grid.GetCell(25, 46);
            VerticalEnemy enemyV4 = new VerticalEnemy(enemyV4Image, enemyV4Cell, GameDirection.DOWN, 3, true);

            Image enemyRImage = Game.GetGameObjectImage('r');
            GameCell enemyR1Cell = grid.GetCell(3, 39);
            RandomEnemy enemyR1 = new RandomEnemy(enemyRImage, enemyR1Cell, 5, true);

            Image enemyR2Image = Game.GetGameObjectImage('r');
            GameCell enemyR2Cell = grid.GetCell(23, 15);
            RandomEnemy enemyR2 = new RandomEnemy(enemyR2Image, enemyR2Cell, 4, true);

            enemies.Add(enemyH1);
            enemies.Add(enemyH2);
            enemies.Add(enemyV1);
            enemies.Add(enemyV2);
            enemies.Add(enemyV3);
            enemies.Add(enemyV4);
            enemies.Add(enemyR1);
            enemies.Add(enemyR2);

            PrintMaze(grid);
        }

        // print maze for level 2

        private void PrintMaze(GameGrid grid)
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

        // pass the current progress info from level 1

        public void passInfo(GameGrid grid, int lives, int score)
        {
            this.grid = grid;
            this.lives = lives;
            this.score = score;
            this.grid.LoadGrid("maze2.txt");
        }

        // game running timer for player and bullets

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (isLevel2Complete == true)
            {
                GameLoop.Enabled = false;
                GhostTimer.Enabled = false;
                lbl_won.Visible = true;
                MessageBox.Show("You All Completed Levels ... !", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                Image playerLeft = Game.GetGameObjectImage('L');
                spelunker = new Spelunker(playerLeft, spelunker.currentCell);
                spelunker.Move(GameDirection.LEFT, ref score, ref lives, ref isLevel2Complete);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                Image playerRight = Game.GetGameObjectImage('R');
                spelunker = new Spelunker(playerRight, spelunker.currentCell);
                spelunker.Move(GameDirection.RIGHT, ref score, ref lives, ref isLevel2Complete);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                spelunker.Move(GameDirection.UP, ref score, ref lives, ref isLevel2Complete);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                spelunker.Move(GameDirection.DOWN, ref score, ref lives, ref isLevel2Complete);
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

        // generate enemy 2 bullets when moving left if enemy is alive

        private void generateEnemy2Bullet()
        {
            if (enemyH2.isEnemyAlive)
            {
                if (enemyH2.direction == GameDirection.RIGHT)
                {
                    if (enemyH2.isEnemyAlive)
                    {
                        Image image = Game.GetGameObjectImage('*');
                        GameCell enemy1BulletCell = grid.GetCell(enemyH2.currentCell.x, enemyH2.currentCell.y - 1);
                        enemy1Bullets[enemy1BulletCount] = new Bullet(image, enemy1BulletCell, GameDirection.LEFT, enemyH2.currentCell.x, enemyH2.currentCell.y - 1);
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

        // function for checking collosion of player with any enemy

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

        private void RestartButton_Click(object sender, EventArgs e)
        {
            GameLoop.Enabled = false;
            GhostTimer.Enabled = false;
            MessageBox.Show("Restarting the Game : All your progress will be lost", "RESTART", MessageBoxButtons.OK);
            Application.Run(new Level1());
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
    }
}
