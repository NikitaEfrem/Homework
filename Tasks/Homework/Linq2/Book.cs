using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public class Book
    {
        public string Author { get; }
        public string Title { get; }
        public int Year { get; }
        public int Pages { get; }

        public Book(string author, string title, int year, int pages)
        {
            Author = author;
            Title = title;
            Year = year;
            Pages = pages;
        }
    }
}
