using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
using System.IO;
using PD___3__Game_;
using EZInput;

namespace PD___3__Game_
{
    class Program
    {
        static int index1 = 0;
        static int index2 = 0;
        static int[] bulletx = new int[1000];
        static int[] bullety = new int[1000];
        static int[] bulletX = new int[1000];
        static int[] bulletY = new int[1000];

        static void Main(string[] args)
        {
            char[,] spelunker = new char[2, 7] 
            {
                { ' ', ' ', '_', '0', '_', ' ', ' '},
                { '{', '/', '|', 'H', '|', '\\', '}' } 
            };
            char[,] ghost = new char[2, 7] 
            {
                { '/', '\\', '(', '*', ')', '/', '\\'},
                { ' ', ' ', '/', '/', ' ', ' ', ' '}
            };

            char[,] maze = new char[20, 64]{
                { '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%' },
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '%'},
                { '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%', '%'} };

            readData(maze );
            int count = 3;
            int winGame = 0;
            int loseGame = 0;
            Spelunker coordinates = new Spelunker();
            LivesNscore data = new LivesNscore();
            printMaze(maze);
            printSpelunker(spelunker, coordinates);
            printGhost(ghost, coordinates);
            printScore(data);
            printPlayerLives(data);
            printEnemyLives(data);
            header();
            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveRight(maze, coordinates, spelunker);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveLeft(maze, coordinates, spelunker);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveUp(maze, coordinates, spelunker);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveDown(maze, coordinates, spelunker);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    createBullet(coordinates);
                }
                if (count == 3 && data.enemyLives > 0)
                {
                    moveGhost(ghost, coordinates);
                    count = 0;
                }
                if (coordinates.enemyX == 4 || coordinates.enemyX == 12)
                {
                    createEnemyBullet(coordinates);
                }
                if (data.enemyLives <= 0)
                {
                    winGame = 1;
                    eraseGhost(ghost, coordinates);
                    gameRunning = false;
                }
                if (data.playerLives <= 0)
                {
                    loseGame = 1;
                    gameRunning = false;
                }
                moveEnemyBullet(maze, coordinates, data);
                moveBullet(maze, coordinates, data);
                count++;
            }
            if (winGame == 1)
            {
                Console.SetCursorPosition(94, 12);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("MASHA ALLAH YOU WON. ");
                Thread.Sleep(4000);
            }
            else if (loseGame == 1)
            {
                Console.SetCursorPosition(94, 12);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("INNA LILAH YOU DIED. ");
                Thread.Sleep(4000);
            }
            storeMaze(maze);
        }

        static void createEnemyBullet(Spelunker coordinates)
        {
            bulletY[index2] = coordinates.enemyY - 1;
            bulletX[index2] = coordinates.enemyX;
            index2++;
        }

        static void moveEnemyBullet(char[,] maze, Spelunker coordinates, LivesNscore data)
        {
            for (int x = 0; x < index2; x++)
            {
                if (maze[bulletX[x], bulletY[x] - 1] == ' ')
                {
                    Console.SetCursorPosition(bulletY[x], bulletX[x]);
                    Console.Write(" ");
                    bulletY[x]--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(bulletY[x], bulletX[x]);
                    Console.Write(".");
                }
                if (maze[bulletX[x], bulletY[x] - 1] != ' ')
                {
                    Console.SetCursorPosition(bulletY[x], bulletX[x]);
                    Console.Write(" ");
                }
                if ((bulletY[x] - 1 == coordinates.playerY + 4 && bulletX[x] == coordinates.playerX) || (bulletY[x] - 1 == coordinates.playerY + 7 && bulletX[x] == coordinates.playerX + 1))
                {
                    data.playerLife(ref data.playerLives);
                    printPlayerLives(data);
                }
            }
        }

        static void createBullet(Spelunker coordinates)
        {
            bullety[index1] = coordinates.playerY + 7;
            bulletx[index1] = coordinates.playerX + 1;
            index1++;
        }

        static void moveBullet(char[,] maze, Spelunker coordinates, LivesNscore data)
        {
            for (int x = 0; x < index1; x++)
            {
                if (maze[bulletx[x], bullety[x] + 1] == ' ')
                {
                    Console.SetCursorPosition(bullety[x], bulletx[x]);
                    Console.Write(" ");
                    bullety[x]++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(bullety[x], bulletx[x]);
                    Console.Write(">");
                }
                if (maze[bulletx[x], bullety[x] + 1] == '%')
                {
                    Console.SetCursorPosition(bullety[x], bulletx[x]);
                    Console.Write(" ");
                }
                if (bullety[x] + 1 == coordinates.enemyY && bulletx[x] == coordinates.enemyX)
                {
                    data.addScore(ref data.score);
                    data.enemyLife(ref data.enemyLives);
                    printScore(data);
                    printEnemyLives(data);
                }
            }
        }

        static void moveRight(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.playerX, coordinates.playerY + 7] == ' ' || maze[coordinates.playerX, coordinates.playerY - 1] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.moveRight(ref coordinates.playerY);
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveLeft(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.playerX, coordinates.playerY - 1] == ' ' || maze[coordinates.playerX, coordinates.playerY - 1] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.moveLeft(ref coordinates.playerY);
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveUp(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.playerX - 1, coordinates.playerY] == ' ' || maze[coordinates.playerX - 1, coordinates.playerY] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.moveUp(ref coordinates.playerX);
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveDown(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.playerX + 2, coordinates.playerY] == ' ' || maze[coordinates.playerX + 2, coordinates.playerY] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.moveDown(ref coordinates.playerX);
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveGhost(char[,] ghost, Spelunker coordinates)
        {
            eraseGhost(ghost, coordinates);
            if (coordinates.enemyX < 13)
            {
                coordinates.moveEnemy(ref coordinates.enemyX);
                printGhost(ghost, coordinates);
            }
            if (coordinates.enemyX == 13)
            {
                eraseGhost(ghost, coordinates);
                coordinates.enemyX = 4;
            }
        }

        static void printScore(LivesNscore data)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 6);
            Console.Write("Score: " + data.score);
        }

        static void printPlayerLives(LivesNscore data)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 7);
            Console.Write("Player Life: " + data.playerLives);
        }

        static void printEnemyLives(LivesNscore data)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 8);
            Console.Write("Enemy Life: " + data.enemyLives);
        }

        static void header()
        {
            Console.SetCursorPosition(0, 23);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("            ||                                                                                                                                 ||");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("            ||                     $$$$$$\\                      $$\\                     $$\\                                                    ||");
            Console.WriteLine("            ||                    $$  __$$\\                     $$ |                    $$ |                                                   ||");
            Console.WriteLine("            ||                    $$ /  \\__| $$$$$$\\   $$$$$$\\  $$ |$$\\   $$\\ $$$$$$$\\  $$ |  $$\\  $$$$$$\\   $$$$$$\\                           ||");
            Console.WriteLine("            ||                    \\$$$$$$\\  $$  __$$\\ $$  __$$\\ $$ |$$ |  $$ |$$  __$$\\ $$ | $$  |$$  __$$\\ $$  __$$\\                          ||");
            Console.WriteLine("            ||                     \\____$$\\ $$ /  $$ |$$$$$$$$ |$$ |$$ |  $$ |$$ |  $$ |$$$$$$  / $$$$$$$$ |$$ |  \\__|                         ||");
            Console.WriteLine("            ||                    $$\\   $$ |$$ |  $$ |$$   ____|$$ |$$ |  $$ |$$ |  $$ |$$  _$$<  $$   ____|$$ |                               ||");
            Console.WriteLine("            ||                    \\$$$$$$  |$$$$$$$  |\\$$$$$$$\\ $$ |\\$$$$$$  |$$ |  $$ |$$ | \\$$\\ \\$$$$$$$\\ $$ |                               ||");
            Console.WriteLine("            ||                     \\______/ $$  ____/  \\_______|\\__| \\______/ \\__|  \\__|\\__|  \\__| \\_______|\\__|                               ||");
            Console.WriteLine("            ||                               $$ |                                                                                              ||");
            Console.WriteLine("            ||                               $$ |                                                                                              ||");
            Console.WriteLine("            ||                               \\__|                                                                                              ||");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            ||                                                                                                                                 ||");
            Console.WriteLine("            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }

        static void printMaze(char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }
        }

        static void printSpelunker(char[,] spelunker, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(coordinates.playerY, coordinates.playerX);

            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(spelunker[x, y]);
                }
                Console.SetCursorPosition(coordinates.playerY, coordinates.playerX + 1);
            }
        }

        static void eraseSpelunker(char[,] spelunker, Spelunker coordinates)
        {
            Console.SetCursorPosition(coordinates.playerY, coordinates.playerX);

            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(coordinates.playerY, coordinates.playerX + 1);
            }
        }

        static void storeMaze(char[,] maze)
        {
            StreamWriter file = new StreamWriter("maze.txt");
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    file.Write(maze[x, y]);

                }
                file.WriteLine();
            }
            file.Close();
        }

        static void readData(char[,] maze)
        {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 10; x++)
                {
                    maze[row, x] = record[x];
                }
                row++;
            }
            fp.Close();
        }

        static void printGhost(char[,] ghost, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(coordinates.enemyY, coordinates.enemyX);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(ghost[x, y]);
                }
                Console.SetCursorPosition(coordinates.enemyY, coordinates.enemyX + 1);
            }
        }

        static void eraseGhost(char[,] ghost, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(coordinates.enemyY, coordinates.enemyX);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(coordinates.enemyY, coordinates.enemyX + 1);
            }
        }
    }
}
