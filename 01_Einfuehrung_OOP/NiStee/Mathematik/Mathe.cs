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


        /* oder:
        public decimal FakulRek(int zahl) {
            OutofRange(zahl);
            this.Ergebnis = 1;
            if (zahl == 0 || zahl == 1) {
                this.Ergebnis = 1;
            } else {
                for (ulong i = 1; i <= zahl; i++) {
                    this.Ergebnis *= i;
                }
            }
            return this.Ergebnis;
        }
        */
    }
}
