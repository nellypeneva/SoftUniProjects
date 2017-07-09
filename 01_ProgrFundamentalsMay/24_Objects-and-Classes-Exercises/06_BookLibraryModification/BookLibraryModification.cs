using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _06_BookLibraryModification
{
    class BookLibraryModification
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library("Library");            

            for (int i = 0; i < n; i++)
            {
                library.Books.Add(ReadBook());
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            
            PrintBooksByDate(library, date);          
        }

        private static void PrintBooksByDate(Library library, DateTime date)
        {
            var booksSorted = library.Books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title);
            
            foreach (var book in booksSorted)
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
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
