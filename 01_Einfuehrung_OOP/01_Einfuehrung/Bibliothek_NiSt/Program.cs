using System;

namespace Bibliothek {
    class Program {
        static void Main(string[] args) {
            Book myFirstBook = new Book("1234567890", "1984", "George Orwell", 20.4);
            Console.WriteLine($"Mein erstes Buch hat die ISBN {myFirstBook.Isbn}. Der Author heißt {myFirstBook.Author} und es trägt den Titel {myFirstBook.Title}. Das Buch kostet aktuell {myFirstBook.Price} Euro.");
            Console.ReadKey();
        }
    }
}
