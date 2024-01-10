using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzerverwaltung
{
    class Basisnutzer : Nutzer
    {
        public Basisnutzer(String name, String vorname, Konto meinKonto) : base (name, vorname, meinKonto)
        {

        }
    }
}
