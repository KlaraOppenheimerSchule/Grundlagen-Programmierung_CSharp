namespace Nutzerverwaltung {
    public class Mitarbeiter {
        public string Nachname { get; set; }
        public string Vorname { get; set; }

        public Mitarbeiter(string nachname, string vorname) {
            this.Nachname = nachname;
            this.Vorname = vorname;
        }
    }
}
