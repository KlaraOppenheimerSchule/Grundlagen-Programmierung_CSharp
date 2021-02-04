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
        /* oder als for-Schleife
        public static decimal Fakul(int zahl) {
            OutofRange(zahl);
            decimal Ergebnis = 1;
            for (int i = 1; i <= zahl; i++) {
                Ergebnis *= i;
                }
            return Ergebnis;
        }

        *oder als rekursive for-Schleife
        public static decimal Fakul(int zahl) {
            Console.WriteLine($"Aufruf mit {zahl}");
            if (zahl >= 1) {
                // rekursiver Aufruf (ruft sich selbst auf)
                var Ergebnis = zahl * Fakul(zahl - 1);
                return Ergebnis;
            } else {
                // Abbruchbedingung der Rekursion
                var Ergebnis = 1m;
                return Ergebnis;
            }
        }
        */
    }
}
