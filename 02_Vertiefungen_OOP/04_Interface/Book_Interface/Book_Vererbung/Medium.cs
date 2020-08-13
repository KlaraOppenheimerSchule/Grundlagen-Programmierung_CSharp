using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Interface
{
    abstract class Medium
    {
        private string isbn;
        private string title;
        private string author;
        private double price;

        public Medium(string isbn, string title, string author, double price)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public string getIsbn()
        {
            return this.isbn;
        }

        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }
    }

}
