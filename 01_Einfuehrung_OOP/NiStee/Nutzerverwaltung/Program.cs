using System;

namespace Nutzerverwaltung {
    class Program {
        static void Main(string[] args) {
            Mitarbeiter neuerMitarbeiter = new Mitarbeiter("Steenebrügge", "Nils");
            Console.WriteLine($"Ihr neuer Mitarbeiter {neuerMitarbeiter.Vorname} {neuerMitarbeiter.Nachname} wurde im System angelegt.");
            Console.ReadKey();
        }
    }
}
