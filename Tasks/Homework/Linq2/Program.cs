namespace Linq2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;





    class Program
    {
        static void Main(string[] args)
        {
            Library.DisplayBooksByAuthor("Tolkien");

            int bookCount = Library.CountBooks();
            Console.WriteLine($"\nAmmount of books: {bookCount}");

            Book bookWithMostPages = Library.FindBookWithMostPages();
            Console.WriteLine($"\nBook with most pages: {bookWithMostPages.Title}");

            var sortedBooks = Library.SortBooksByYearDescending();
            Console.WriteLine("\nBooks sorted by year of publication in descending order:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Year of publication: {book.Year}");
            }


            Library.DisplayBooksPublishedAfterYear(2000);
        }

    }
}
