using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05a_BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library("Library");

            for (int i = 0; i < n; i++)
            {
                library.Books.Add(ReadBook());
            }

            var books = library.Books;
            Dictionary<string, decimal> salesByAuthor = new Dictionary<string, decimal>();

            foreach (string author in books.Select(x => x.Author).Distinct())
            {
                salesByAuthor.Add( author, books.Where(x => x.Author == author).Select(x => x.Price).Sum() );
            }

            foreach (var pair in salesByAuthor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            } 
        }
 
        private static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split(' ');

            return new Book(input[0],
                            input[1],
                            input[2],
                            DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                            input[4],
                            decimal.Parse(input[5])
                            );

        } 
    }
}
