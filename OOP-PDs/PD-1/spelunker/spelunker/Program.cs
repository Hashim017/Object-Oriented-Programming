using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using spelunker;
using System.IO;
using EZInput;

namespace packman
{
    class Program
    {
        static int score = 0;
        static int playerLives = 5;
        static int enemyLives = 10;
        static int index1 = 0;
        static int index2 = 0;
        static int[] bulletx = new int[1000];
        static int[] bullety = new int[1000];
        static int[] bulletX = new int[1000];
        static int[] bulletY = new int[1000];


        static void Main(string[] args)
        {
            char[,] spelunker = new char[2, 7] {
                { ' ', ' ', '_', '0', '_', ' ', ' '},
                { '{', '/', '|', 'H', '|', '\\', '}' } };
            char[,] ghost = new char[2, 7] {
                { '/', '\\', '(', '*', ')', '/', '\\'},
                { ' ', ' ', '/', '/', ' ', ' ', ' '} };

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
            
            Spelunker coordinates = new Spelunker();
            coordinates.xPos = 6;
            coordinates.yPos = 10;
            coordinates.XPos = 4;
            coordinates.YPos = 49;
            int count = 3;
            int winGame = 0;
            int loseGame = 0;
            readData(maze);
            printMaze(maze);
            printSpelunker(spelunker, coordinates);
            printGhost(ghost, coordinates);
            printScore();
            printPlayerLives();
            printEnemyLives();
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
                if (count == 3 && enemyLives > 0)
                {
                    moveGhost(ghost, coordinates);
                    count = 0;
                }
                if (coordinates.XPos == 4 || coordinates.XPos == 12)
                {
                    createEnemyBullet(coordinates);
                }
                moveEnemyBullet(maze, coordinates);
                if (enemyLives <= 0)
                {
                    winGame = 1;
                    eraseGhost(ghost, coordinates);
                    gameRunning = false;
                }
                if (playerLives <= 0)
                {
                    loseGame = 1;
                    gameRunning = false;
                }
                moveBullet(maze, coordinates);
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

        static void printScore()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 6);
            Console.Write("Score: " + score);
        }

        static void printPlayerLives()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 7);
            Console.Write("Player Life: " + playerLives);
        }

        static void printEnemyLives()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(94, 8);
            Console.Write("Enemy Life: " + enemyLives);
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

        static void moveRight(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.xPos, coordinates.yPos + 7] == ' ' || maze[coordinates.xPos, coordinates.yPos + 7] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.yPos = coordinates.yPos + 1;
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveLeft(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.xPos, coordinates.yPos - 1] == ' ' || maze[coordinates.xPos, coordinates.yPos - 1] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.yPos = coordinates.yPos - 1;
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveUp(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.xPos - 1, coordinates.yPos] == ' ' || maze[coordinates.xPos - 1, coordinates.yPos] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.xPos = coordinates.xPos - 1;
                printSpelunker(spelunker, coordinates);
            }
        }

        static void moveDown(char[,] maze, Spelunker coordinates, char[,] spelunker)
        {
            if (maze[coordinates.xPos + 2, coordinates.yPos] == ' ' || maze[coordinates.xPos + 2, coordinates.yPos] == '.')
            {
                eraseSpelunker(spelunker, coordinates);
                coordinates.xPos = coordinates.xPos + 1;
                printSpelunker(spelunker, coordinates);
            }
        }

        static void printSpelunker(char[,] spelunker, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(coordinates.yPos, coordinates.xPos);

            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(spelunker[x, y]);
                }
                Console.SetCursorPosition(coordinates.yPos, coordinates.xPos + 1);
            }
        }

        static void eraseSpelunker(char[,] spelunker, Spelunker coordinates)
        {
            Console.SetCursorPosition(coordinates.yPos, coordinates.xPos);

            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(coordinates.yPos, coordinates.xPos + 1);
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

        static void printGhost(char[,] ghost, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(coordinates.YPos, coordinates.XPos);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(ghost[x, y]);
                }
                Console.SetCursorPosition(coordinates.YPos, coordinates.XPos + 1);
            }
        }

        static void eraseGhost(char[,] ghost, Spelunker coordinates)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(coordinates.YPos, coordinates.XPos);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(coordinates.YPos, coordinates.XPos + 1);
            }
        }

        static void moveGhost(char[,] ghost, Spelunker coordinates)
        {
            eraseGhost(ghost, coordinates);
            if (coordinates.XPos < 13)
            {
                coordinates.XPos++;
                printGhost(ghost, coordinates);
            }
            if (coordinates.XPos == 13)
            {
                eraseGhost(ghost, coordinates);
                coordinates.XPos = 4;
            }
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

        static void createBullet(Spelunker coordinates)
        {
            bullety[index1] = coordinates.yPos + 7;
            bulletx[index1] = coordinates.xPos + 1;
            index1++;
        }

        static void moveBullet(char[,] maze, Spelunker coordinates)
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
                if (bullety[x] + 1 == coordinates.YPos && bulletx[x] == coordinates.XPos)
                {
                    score = score + 10;
                    enemyLives--;
                    printScore();
                    printEnemyLives();
                }
            }
        }
        static void createEnemyBullet(Spelunker coordinates)
        {
            bulletY[index2] = coordinates.YPos - 1;
            bulletX[index2] = coordinates.XPos;
            index2++;
        }

        static void moveEnemyBullet(char[,] maze, Spelunker coordinates)
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
                if (maze[bulletX[x], bulletY[x] - 1] == '%')
                {
                    Console.SetCursorPosition(bulletY[x], bulletX[x]);
                    Console.Write(" ");
                }
                if ((bulletY[x] - 1 == coordinates.yPos + 4 && bulletX[x] == coordinates.xPos) || (bulletY[x] - 1 == coordinates.yPos + 7 && bulletX[x] == coordinates.xPos + 1))
                {
                    playerLives--;
                    printPlayerLives();
                }
            }
        }


    }
}



