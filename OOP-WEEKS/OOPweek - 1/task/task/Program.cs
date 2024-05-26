using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {

        static void checkIfAble(float age, float machinePrice, float toyPrice)
        {
            float toys = 0, brotherTake = 0, receivedMoney = 0, num = 1;
            for (int x = 1; x <= age; x++)
            {
                if (x % 2 != 0)
                {
                    toys++;
                }
                if (x % 2 == 0)
                {
                    brotherTake++;
                    receivedMoney = receivedMoney + 10 * num;
                    num++;
                }
            }
            receivedMoney = receivedMoney + toyPrice * toys;
            receivedMoney = receivedMoney - brotherTake;

            if (receivedMoney >= machinePrice)
            {
                Console.WriteLine();
                Console.WriteLine("Yes!");
                Console.Write(receivedMoney - machinePrice);
            }
            else if (receivedMoney < machinePrice)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
                Console.Write(machinePrice - receivedMoney);
            }

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            float age, machinePrice, toyPrice;
            Console.Write("Enter Age: ");
            age = float.Parse(Console.ReadLine());
            Console.Write("Enter Washing Machine Price: ");
            machinePrice = float.Parse(Console.ReadLine());
            Console.Write("Enter Sold Toy Unit Price: ");
            toyPrice = float.Parse(Console.ReadLine());
            checkIfAble(age, machinePrice, toyPrice);
           
        }
    }
}
