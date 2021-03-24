using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewaesseraufgabe
{
    public abstract class Gewaesser
    {
        private String name;
        private bool schiffbarkeit;
        private int schadstoffbelastung;

        public Gewaesser(String name, bool schiffbarkeit, int schadstoffbelastung)
        {
            this.name = name;
            this.schiffbarkeit = schiffbarkeit;
            this.schadstoffbelastung = schadstoffbelastung;
        }

        abstract public int getVerlauf();

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getSchadstoffbelastung()
        {
            return schadstoffbelastung;
        }

        public void setSchadstoffbelastung(int schadstoffbelastung)
        {
            this.schadstoffbelastung = schadstoffbelastung;
        }

        public bool getSchiffbarkeit()
        {
            return schiffbarkeit;
        }

        public void setSchiffbarkeit(bool schiffbarkeit)
        {
            this.schiffbarkeit = schiffbarkeit;
        }
    }

}
