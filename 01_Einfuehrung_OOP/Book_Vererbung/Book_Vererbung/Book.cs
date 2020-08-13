using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Vererbung
{
    class Book : Medium
    {
        private int edition;

        public Book(string isbn, string title, string author, double price, int edition) : base(isbn, title, author, price)
        {
            this.edition = edition;

        }

        public int getEdition()
        {
            return this.edition;
        }

        public void setEdition(int edition)
        {
            if (edition > 0)
            {
                this.edition = edition;
            }
        }
    }

}
