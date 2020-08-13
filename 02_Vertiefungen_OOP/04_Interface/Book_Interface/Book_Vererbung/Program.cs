using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("123456789", "1984", "George Orwell", 20.4, 1);
            DVD dvd1 = new DVD("123456789", "1984", "George Orwell", 20.4, 650);
        }
    }
}
