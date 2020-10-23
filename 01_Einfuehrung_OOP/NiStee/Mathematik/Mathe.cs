using System;

namespace Mathematik {
    public static class Mathe {
                
        private static void OutofRange(int zahl) {
            if (zahl <= 0) {
                throw new ArgumentOutOfRangeException(nameof(zahl), $"Eingabewert \"{zahl}\" muss eine Natürliche Zahl (größer Null) sein");
            }
        }

        public static decimal Summe(int zahl, int zahl2) {
            OutofRange(zahl);
            OutofRange(zahl2);
            decimal Ergebnis = zahl + (decimal)zahl2;
            return Ergebnis;
        }
        public static decimal Quadrat(int zahl) {
            OutofRange(zahl);
            var Ergebnis = zahl * zahl;
            return Ergebnis;
        }


        public static decimal Fakul(int zahl) {
            OutofRange(zahl);
            decimal Ergebnis = 1;
            while (zahl > 0) { 
                Ergebnis *= zahl--; 
            }
            return Ergebnis;
        }


        /* oder:
        public static decimal FakulRek(int zahl) {
            OutofRange(zahl);
            this.Ergebnis = 1;
            for (ulong i = 1; i <= zahl; i++) {
                this.Ergebnis *= i;
                }
            return this.Ergebnis;
        }
        */
    }
}
