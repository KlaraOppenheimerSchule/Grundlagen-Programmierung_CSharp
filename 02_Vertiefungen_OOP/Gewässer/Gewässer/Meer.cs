using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewaesseraufgabe
{
    public class Meer : Gewaesser
    {
        private float flache;

        public Meer(String name, bool schiffbarkeit, int schadstoffbelastung, float flache): base (name, schiffbarkeit, schadstoffbelastung)
        {    
            this.flache = flache;
        }

        public float getFlache()
        {
            return flache;
        }

        public void setFlache(float flache)
        {
            this.flache = flache;
        }

        public override int getVerlauf()
        {
            return 0;
        }
    }
}
