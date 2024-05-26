using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chapters = new List<string>();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter Number of Pages: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            int price = int.Parse(Console.ReadLine());
            chapters.Add(name());
            chapters.Add(name());
            chapters.Add(name());
            BookRecords bookRecord = new BookRecords(author, pages, chapters, price);
            Console.Write("Enter Chapter Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(bookRecord.getChapter(number));
            Console.WriteLine("Book Price Is: " + bookRecord.getBookprice());
            Console.Write("Enter New Pice: ");
            int newPrice = int.Parse(Console.ReadLine());
            bookRecord.setBookprice(newPrice);
            Console.WriteLine("New Book Price: " + bookRecord.getBookprice());
            Console.WriteLine("Book Mark: " + bookRecord.getBookmark());
            Console.Write("Enter New Book Mark: ");
            int newBookMark = int.Parse(Console.ReadLine());
            bookRecord.setBookmark(newBookMark);
            Console.WriteLine("New Book Mark: " + bookRecord.getBookmark());
            Console.ReadKey();

        }

        static string name()
        {
            Console.Write("Enter Chapter Name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
