namespace Bibliothek {
    public class Book {
        // private string Isbn();
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string isbn, string title, string author, double price) {
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        /* public string getIsbn{
         * return this.Isbn;
         * }
         * 
         * public string setIsbn(string isbn){
         * this.Isbn = isbn;
         * }
         */
    }
}
