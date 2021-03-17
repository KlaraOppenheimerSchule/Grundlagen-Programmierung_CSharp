using System.Text.Json.Serialization;

namespace Bibliothek {
    public class Book {

        public Book(string isbn, string title, string author, double price) {
            Isbn = isbn;
            Title = title;
            Author = author;
            Price = price;
        }

        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
