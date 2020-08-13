using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einführung_Book
{
    class Book
    {
        private string isbn;
        private string title;
        private string author;
        private double price;
  
        public Book(string isbn, string title, string author, double price)
        {
            this.isbn =isbn;
            this.title =title;
            this.author =author;
            this.price = price;
        }

        public string getIsbn()
        {
            return this.isbn;
        }

        public void setIsbn(string isbn)
        {
            this.isbn=isbn;   
        }

        public double calculateShippingCoasts() 
        {
            if(this.price>20)        
            {
                return 0;
            }
            else
            {
                return 3.90;
            }
        }

   

    //...
    }
}
