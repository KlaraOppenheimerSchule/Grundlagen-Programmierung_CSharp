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

            Konto tempKonto = new Konto();

            Basisnutzer ersterNutzer = new Basisnutzer(vorname, nachname, tempKonto);
            Console.WriteLine(ersterNutzer.getVorname());
            Console.WriteLine(ersterNutzer.getNachname());

            Premiumnutzer zweiterNutzer= new Premiumnutzer(vorname, nachname, tempKonto);
            zweiterNutzer.werbungAusschalten();
            Console.WriteLine(zweiterNutzer.getNachname());
            Console.WriteLine(zweiterNutzer.getKontodaten());
            Console.ReadLine();
        }
    }
}
