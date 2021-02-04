namespace Nutzerverwaltung {
    public class Employee {

        public Employee(string lastName, string givenName) {
            LastName = lastName;
            GivenName = givenName;
        }

        public string LastName { get; }
        public string GivenName { get; }
    }
}