using System.Collections.Generic; 

namespace _06_BookLibraryModification
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
