using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzerverwaltung
{
    class Premiumnutzer : Nutzer, ISpezialfunktion 
    {
        public Premiumnutzer(String name, String vorname, Konto meinKonto) : base(name, vorname, meinKonto)
        {
        }
        public void werbungAusschalten()
        {
            Console.WriteLine("Ohne Werbung");
        }

        override public string getNachname()
        {
            return "Klaus";
        }

    }

    //Soll eine besondere Methode besitzen, die der Basisnutzer nicht hat.
    //Weitere Nutzerklassen werden entstehen (z.B. Deluxenutzer), die auch diese zusätzliche Methoden haben soll
    //Dies soll programmiertechnisch sichergestellt sein.
}

