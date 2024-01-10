using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzerverwaltung
{
    abstract class Nutzer
    {
        private string vorname;    
        private string nachname;
        private Konto meinKonto;

        /* Definition des Konstruktors der Klasse Mitarbeiter */
        public Nutzer(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public Nutzer(string vorname, string nachname, Konto meinKonto)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.meinKonto = meinKonto;
        }

        public string getVorname()
        {
            return this.vorname;
        }

        virtual public string getNachname()
        {
            return this.nachname;
        }
        
        public string getKontodaten()
        {
            //Zugriff auf Konto des Kunden und Abruf der Daten
            return meinKonto.getData();
        }

    }
}
