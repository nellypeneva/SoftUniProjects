using System; 

namespace _05a_BookLibrary
{
    public class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.IsbnNumber = isbnNumber;
            this.Price = price;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IsbnNumber { get; set; }
        public decimal Price { get; set; }
    }
     
}
