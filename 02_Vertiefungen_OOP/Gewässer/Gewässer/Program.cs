using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewaesseraufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Meer meer1 = new Meer("meer1", true, 12, 346352);
            Fluss fluss1 = new Fluss("fluss1", true, 9, meer1, 1354);
            Fluss fluss2 = new Fluss("fluss2", true, 4, fluss1, 146);
            Fluss fluss3 = new Fluss("fluss3", true, 43, fluss2, 521);
            Console.WriteLine("Die Länge ist: " + fluss3.getVerlauf());
            Console.WriteLine("Die Länge ist: " + meer1.getVerlauf());
            Console.ReadKey();
        }
    }
}
