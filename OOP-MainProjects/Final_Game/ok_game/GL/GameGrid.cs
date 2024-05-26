using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ok_game
{
    class GameGrid
    {
        public GameCell[,] Cells;
        public int rows;
        public int columns;
        public GameGrid(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            Cells = new GameCell[rows, columns];
        }
        int counter = 0; 
        public void LoadGrid(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string record;
            for (int row = 0; row < rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < columns; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    char displayCharacter = record[col];
                    GameObjectType objectType = GameObject.GetGameObjectType(displayCharacter);
                    Image displayImage = null;
                    if (counter == 0)
                    {
                        displayImage = Game.GetGameObjectImage(displayCharacter);
                    }
                    else if (counter == 1)
                    {
                        displayImage = Game.GetGameObjectImage2(displayCharacter);
                    }
                    GameObject obj = new GameObject(objectType, displayImage);
                    obj.currentCell = cell;
                    cell.SetGameObject(obj);
                    Cells[row, col] = cell;
                }
            }
            counter++;
            fp.Close();
        }
        public GameCell GetCell(int row, int col)
        {
            return Cells[row, col];
        }
        public static double Get_Distance(GameCell cell1, GameCell cell2)
        {
            return Math.Sqrt(Math.Pow(cell2.x - cell1.x, 2) + Math.Pow(cell2.y - cell1.y, 2));
        }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
    }
}
