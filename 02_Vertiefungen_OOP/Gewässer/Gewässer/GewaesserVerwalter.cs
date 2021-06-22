using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewaesseraufgabe
{
    class GewaesserVerwalter
    {
        private List<Gewaesser> gewaesserListe = new List<Gewaesser>();

        public void listeErgaenzen(Gewaesser neuesGewaesser)
        {
            gewaesserListe.Add(neuesGewaesser);
        }

        public void zeigeGewaesserAn()
        {
            foreach (Gewaesser einzelGewaesser in gewaesserListe)
            {
                Console.WriteLine(einzelGewaesser.getName() + " " + einzelGewaesser.getVerlauf());
            }
        }
    }
}
