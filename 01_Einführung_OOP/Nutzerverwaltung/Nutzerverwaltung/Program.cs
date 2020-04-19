using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzerverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vorname:");
            string vorname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nachname = Console.ReadLine();

            Nutzer ersterNutzer = new Nutzer(vorname, nachname);
            Console.WriteLine(ersterNutzer.getVorname());
            Console.WriteLine(ersterNutzer.getNachname());

            Console.ReadLine();
        }
    }
}
