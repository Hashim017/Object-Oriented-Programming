using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class BookRecords
    {
        public string Author;
        public int Pages;
        public List<string> Chapters;
        public int BookMark;
        public int Price;

        public BookRecords(string author, int pages, List<string> chapters, int price)
        {
            Author = author;
            Pages = pages;
            Chapters = chapters;
            Price = price;
        }

        public string getChapter(int chapterNumber)
        {
            string result = "";
            for (int x = 0; x < Chapters.Count; x++)
            {
                if (x == chapterNumber)
                {
                    result = Chapters[x];
                    break;
                }
            }
            return result;
        }

        public int getBookmark()
        {
            return BookMark;
        }

        public void setBookmark(int pageNumber)
        {
            BookMark = pageNumber;
        }

        public int getBookprice()
        {
            return Price;
        }

        public void setBookprice(int price)
        {
            Price = price;
        }
    }


}

