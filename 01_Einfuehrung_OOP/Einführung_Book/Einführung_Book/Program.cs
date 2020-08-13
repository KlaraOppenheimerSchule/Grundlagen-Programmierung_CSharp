using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einführung_Book
{
    class Program
    {
        static void Main(string[] args)
        {         
            Book myFirstBook = new Book("123456789", "1984", "George Orwell", 20.4);
            Console.WriteLine(myFirstBook.getIsbn());
            Console.ReadLine();


            BookSwitch mySwitchBook = new BookSwitch("123456789", "1984", "George Orwell", 20.4 ,4);
            Console.WriteLine(mySwitchBook.getBookKategorie());
            Console.ReadLine();
        }
    }
}
