using System;

namespace Mathematik {
    public class Mathe {

        public decimal Ergebnis { get; set; }

        public Mathe() {

        }

        public void OutofRange(int zahl) {
            if (zahl <= 0) {
                throw new ArgumentOutOfRangeException(nameof(zahl), $"Eingabewert \"{zahl}\" muss eine Natürliche Zahl (größer Null) sein");
            }
        }

        public decimal Summe(int zahl, int zahl2) {
            OutofRange(zahl);
            OutofRange(zahl2);
            this.Ergebnis = zahl + zahl2;
            return this.Ergebnis;
        }
        public decimal Quadrat(int zahl) {
            OutofRange(zahl);
            this.Ergebnis = zahl * zahl;
            return this.Ergebnis;
        }


        public decimal Fakul(int zahl) {
            OutofRange(zahl);
            this.Ergebnis = 1;
            while (zahl > 0)
                this.Ergebnis *= zahl--;
            return this.Ergebnis;
        }
        /* public ulong FakulRek(uint zahl) {
            if (zahl < 0)
                throw new ArgumentOutOfRangeException("Zahl darf nicht kleiner 0 sein");

            ulong fakultät = 1;

            if (zahl == 0 || zahl == 1)
                fakultät = 1;
            else {
                for (ulong i = 1; i <= zahl; i++)
                    fakultät *= i;
            }

            return fakultät;
        */
    }
}
