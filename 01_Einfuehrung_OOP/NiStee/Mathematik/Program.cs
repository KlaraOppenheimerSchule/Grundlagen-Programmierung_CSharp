using System;
using System.Runtime.CompilerServices;

namespace Mathematik {
    class Program {
        static void Main(string[] args) {
            var neueRechnung = new Mathe();    
            neueRechnung.Summe(5, 4);
            Console.WriteLine(neueRechnung.Ergebnis);

            var neueRechnung2 = new Mathe();
            neueRechnung2.Fakul(20);
            Console.WriteLine(neueRechnung2.Ergebnis);

            var neueRechnung3 = new Mathe();
            neueRechnung3.Quadrat(32);
            Console.WriteLine(neueRechnung3.Ergebnis);
        }
    }
}
