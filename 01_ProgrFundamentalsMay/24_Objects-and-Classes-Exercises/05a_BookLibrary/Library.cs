using System.Collections.Generic;

namespace _05a_BookLibrary
{
    public class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
