using Bibliothek;
using System;
using Xunit;

namespace Bibliothek.Tests {
    public class BookTest {
        
        [Fact]
        public void CanSetAttributesFromReference() {
            var book1 = GetBook("000 000 001", "Buch 1", "Autor 1", 1);
            
            SetTitle(book1, "New Name");
            SetIsbn(book1, "New ISBN");
            SetAuthor(book1, "New Author");
            SetPrice(book1, 99.99);
            
            Assert.Equal("New Name", book1.Title);
            Assert.Equal("New ISBN", book1.Isbn);
            Assert.Equal("New Author", book1.Author);
            Assert.Equal(99.99, book1.Price);
        }

        private void SetTitle(Book book, string title) {
            book.Title = title;
        }
        private void SetAuthor(Book book, string author) {
            book.Author = author;
        }
        private void SetPrice(Book book, double price) {
            book.Price = price;
        }
        private void SetIsbn(Book book, string isbn) {
            book.Isbn = isbn;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects() {
            var book1 = GetBook("000 000 001", "Buch 1", "Autor 1", 1.1);
            var book2 = GetBook("000 000 002", "Buch 2", "Autor 2", 2.2);

            Assert.Equal("Buch 1", book1.Title);
            Assert.Equal("Buch 2", book2.Title);
            Assert.NotSame(book1, book2);
        }

        Book GetBook(string isbn, string title, string author, double price) {
            return new Book(isbn, title, author, price);
        }
    }
}
