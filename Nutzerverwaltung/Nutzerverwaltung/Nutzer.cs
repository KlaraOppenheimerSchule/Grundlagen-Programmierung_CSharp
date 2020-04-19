using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzerverwaltung
{
    class Nutzer
    {
        private string vorname;    
        private string nachname;
        
        /* Definition des Konstruktors der Klasse Mitarbeiter */
        public Nutzer(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public string getVorname()
        {
            return this.vorname;
        }

        public string getNachname()
        {
            return this.nachname;
        }
    }
}
