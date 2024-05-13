using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    public static class Library
    {
        public static Dictionary<string, Book> Books { get; } = new Dictionary<string, Book>
    {
        { "The Lord of the Rings", new Book("J.R.R. Tolkien", "The Lord of the Rings", 1954, 1178) },
        { "The Hobbit", new Book("J.R.R. Tolkien", "The Hobbit", 1937, 310) },
        { "Harry Potter and the Philosopher's Stone", new Book("J.K. Rowling", "Harry Potter and the Philosopher's Stone", 1997, 223) },
        { "Game of Thrones", new Book("George R.R. Martin", "Game of Thrones", 1996, 694) },
        { "1984", new Book("George Orwell", "1984", 1949, 328) }
    };

        public static void DisplayBooksByAuthor(string authorLastName)
        {
            var tolkienBooks = Books.Values
                .Where(book => book.Author.Split(' ').Last() == authorLastName);

            Console.WriteLine($"Books, written by '{authorLastName}':");
            foreach (var book in tolkienBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, year of publishing : {book.Year}, pages: {book.Pages}");
            }
        }

        public static int CountBooks()
        {
            return Books.Count;
        }

        public static Book FindBookWithMostPages()
        {
            return Books.Values.OrderByDescending(book => book.Pages).FirstOrDefault();
        }

        public static IEnumerable<Book> SortBooksByYearDescending()
        {
            return Books.Values.OrderByDescending(book => book.Year);
        }

        public static void DisplayBooksPublishedAfterYear(int year)
        {
            var booksPublishedAfterYear = Books.Values
                .Where(book => book.Year > year)
                .Select(book => book.Title);

            Console.WriteLine($"Books published after {year} :");
            foreach (var title in booksPublishedAfterYear)
            {
                Console.WriteLine(title);
            }
        }
    }
}
