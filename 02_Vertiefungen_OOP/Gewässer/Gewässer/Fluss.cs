using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewaesseraufgabe
{
    public class Fluss : Gewaesser
    {
        private Gewaesser mundung;
        private int laenge;

        public Fluss(String name, bool schiffbarkeit, int schadstoffbelastung, Gewaesser mundung, int laenge): base(name, schiffbarkeit, schadstoffbelastung)
        { 
            this.mundung = mundung;
            this.laenge = laenge;
        }
    
        public override int getVerlauf()
        {
            int meineLange = laenge;
            if (mundung is Fluss)
            {
                meineLange += mundung.getVerlauf();
            }
            return meineLange;
        }

        public int getLange()
        {
            return this.laenge;
        }

        public void setLange(int lange)
        {
            this.laenge = lange;
        }

        public Gewaesser getMundung()
        {
            return this.mundung;
        }

        public void setMundung(Gewaesser mundung)
        {
            this.mundung = mundung;
        }

    }
}
