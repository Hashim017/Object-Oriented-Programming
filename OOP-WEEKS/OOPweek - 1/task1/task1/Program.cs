using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\C#\\customers.txt";
            int[] priceS = new int[100];
            char[] priceB = new char[100];
            int orders = 0;
            float orderPrice = 0;
            int count = 0;

            Console.Write("Enter Minimum Number Of Orders: ");
            orders = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Order Price: ");
            orderPrice = float.Parse(Console.ReadLine());

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                int add = 0;
                while ((record = file.ReadLine()) != null)
                {
                    for (int x = 0; record[x] != ']'; x++)
                    {
                        if (record[x] == '[')
                        {
                            for (int y = x + 1; record[y] != ']'; y++)
                            {
                                if (record[y] == ',')
                                {
                                    add++;
                                    continue;
                                }
                                else if (record[y] != ',')
                                {
                                    priceS[add] =  priceS[add] + (record[y]);
                                }
                                Console.WriteLine(priceS[add]);
                                break;
                            }
                        }
                    }
                    Console.WriteLine();
                }
                file.Close();
                
            }
            else
            {
                Console.WriteLine("Not Exists.");
            }
            Console.ReadKey();
        }
    }
}
