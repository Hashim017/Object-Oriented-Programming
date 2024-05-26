using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using EZInput;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int spX = 35, spY = 23;
            int ghostX = 82, ghostY = 20;
            header();
            char[,] spelunker = new char[2, 7] {
{ ' ', ' ', '_', '0', '_', ' ', ' '},
{ '{', '/', '|', 'H', '|', '\\', '}' } };
            char[,] ghost = new char[2, 7] {
{ '/', '\\', '(', '*', ')', '/', '\\'},
{ ' ', ' ', '/', '/', ' ', ' ', ' '}
            };
            bool gameruning = true;
            int index = 0;
            int[] bulletX = new int[100];
            int[] bulletY = new int[100];
            int timer = 3;


            storeMaze(maze);
            //readData(maze);
            printMaze(maze);
            printSpelunker(maze, spelunker, ref spX, ref spY);
            //printGhost(ghost, ref ghostX, ref ghostY);

            
            while (gameruning)
            {
                if (timer == 3)
                {
                    moveGhost(ghost, ref ghostX, ref ghostY);
                    timer = 0;
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    
                    moveLeft(maze, spelunker, ref spX, ref spY);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {

                    moveRight(maze, spelunker, ref spX, ref spY);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {

                    moveUp(maze, spelunker, ref spX, ref spY);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {

                    moveDown(maze, spelunker, ref spX, ref spY);
                }
                if(Keyboard.IsKeyPressed(Key.Space))
                {
                    createBullet(maze, bulletX, bulletY, ref index, ref spX, ref spY);
                }
                moveBullet(maze, bulletX, bulletY, ref index, ref spX, ref spY);
                Thread.Sleep(100);
                timer++;
            }
        }

        static void moveLeft(char[,] maze, char[,] spelunker, ref int LX, ref int LY)
        {
                Console.SetCursorPosition(LX, LY);
                eraseSpelunker(maze, spelunker, ref LX, ref LY);
                LX = LX - 1;
                Console.SetCursorPosition(LY, LX);
                printSpelunker(maze, spelunker, ref LX, ref LY);
        }

        static void moveRight(char[,] maze, char[,] spelunker, ref int LX, ref int LY)
        {
                Console.SetCursorPosition(LX, LY);
                eraseSpelunker(maze, spelunker, ref LX, ref LY);
                LX = LX + 1;
                Console.SetCursorPosition(LY, LX);
                printSpelunker(maze, spelunker, ref LX, ref LY);
        }

        static void moveUp(char[,] maze, char[,] spelunker, ref int LX, ref int LY)
        {
                Console.SetCursorPosition(LX, LY);
                eraseSpelunker(maze, spelunker, ref LX, ref LY);
                LY = LY - 1;
                Console.SetCursorPosition(LY, LX);
                printSpelunker(maze, spelunker, ref LX, ref LY);
        }

        static void moveDown(char[,] maze, char[,] spelunker, ref int LX, ref int LY)
        {
                Console.SetCursorPosition(LX, LY);
                eraseSpelunker(maze, spelunker, ref LX, ref LY);
                LY = LY + 1;
                Console.SetCursorPosition(LY, LX);
                printSpelunker(maze, spelunker, ref LX, ref LY);
        }

        static void header()
        {
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

        static void createBullet(char[,] maze, int[] bulletX, int[] bulletY, ref int index, ref int spX, ref int spY)
        {
            bulletX[index] = spX + 7;
            bulletY[index] = spY + 1;
            index++;
        }

        static void moveBullet(char[,] maze, int[] bulletX, int[] bulletY, ref int index, ref int spX, ref int spY)
        {
            for (int x = 0; x < index; x++)
            {
                if(maze[bulletX[x]+1,bulletY[x]] == ' ')
                {
                    Console.SetCursorPosition(bulletX[x], bulletY[x]);
                    bulletX[x]++;
                    Console.SetCursorPosition(bulletX[x], bulletY[x]);
                    Console.Write(".");
                }
                else
                {
                    for(int y = 0; y < index; y++)
                    {
                        bulletX[y] = bulletX[y + 1];
                        bulletY[y] = bulletY[y + 1];
                    }
                    index--;
                }
            }

        }

        static void printGhost(char[,] ghost, ref int ghostX, ref int ghostY)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(ghostX, ghostY);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(ghost[x, y]);
                }
                Console.SetCursorPosition(ghostX, ghostY + 1);
            }
        }

        static void eraseGhost(char[,] ghost, ref int ghostX, ref int ghostY)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            
            Console.SetCursorPosition(ghostX, ghostY);
            for (int x = 0; x < ghost.GetLength(0); x++)
            {
                for (int y = 0; y < ghost.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(ghostX, ghostY + 1);
            }
        }

        static void moveGhost(char[,] ghost, ref int ghostX, ref int ghostY)
        {
            eraseGhost(ghost, ref ghostX, ref ghostY);
            if (ghostY < 31)
            {
                ghostY++;
                printGhost(ghost, ref ghostX, ref ghostY);
            }
            if (ghostY == 31)
            {
                 eraseGhost(ghost, ref ghostX, ref ghostY);
                 ghostY = 20;
            }
        }

        static void printSpelunker(char[,] maze,  char[,] spelunker, ref int spX, ref int spY)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(spX, spY);
            
            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(spelunker[x, y]);
                }
                Console.SetCursorPosition(spX, spY + 1);
            }
        }

        static void eraseSpelunker(char[,] maze, char[,] spelunker, ref int spX, ref int spY)
        {
            Console.SetCursorPosition(spX, spY);

            for (int x = 0; x < spelunker.GetLength(0); x++)
            {
                for (int y = 0; y < spelunker.GetLength(1); y++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(spX, spY + 1);
            }
        }

        static void storeMaze(char[,] maze)
        {
            StreamWriter file = new StreamWriter("maze.txt");
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    file.Write(maze[x,y]);
                    
                }
                file.WriteLine();
            }
            file.Close();
        }

        static void printMaze(char[,] maze)
        {
            int col = 18;
            Console.SetCursorPosition(32, col);
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x, y]);
                }
                col++;
                Console.SetCursorPosition(32, col);
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
    }

}
