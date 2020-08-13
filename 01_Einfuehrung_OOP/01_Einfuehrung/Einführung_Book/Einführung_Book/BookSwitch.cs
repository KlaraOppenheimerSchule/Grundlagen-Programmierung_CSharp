using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einführung_Book
{
    class BookSwitch
    {
        private string isbn;
        private string title;
        private string author;
        private double price;
        private int category;

        public BookSwitch(string isbn, string title, string author, double price, int category)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.price = price;
            this.category = category;
        }

        public string getIsbn()
        {
            return this.isbn;
        }

        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public double calculateShippingCoasts()
        {
            if (this.price > 20)
            {
                return 0;
            }
            else
            {
                return 3.90;
            }
        }

        public String getBookKategorie()
        {
            string categoryName;

            switch(this.category)
            {
                case 1:
                    categoryName= "Action";
                    break;
                case 2:
                    categoryName = "Fantasy";
                    break;
                case 3:
                    categoryName = "Horror";
                    break;
                case 4:
                    categoryName = "Classics";
                    break;
                default:
                    categoryName = "Unknown";
                    break;
            }
            return categoryName;
        }

    }
}
