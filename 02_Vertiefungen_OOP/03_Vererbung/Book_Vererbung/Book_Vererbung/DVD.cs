using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Vererbung
{
    class DVD : Medium
    {
        private double size;

        public DVD(string isbn, string title, string author, double price,
                   double size) : base(isbn, title, author, price)
        {
            this.size = size;

        }

        public double getSize()
        {
            return this.size;
        }

        public void setEdition(double size)
        {
            if (size > 0 && size < 1000)
            {
                this.size = size;
            }
        }
    }

}
