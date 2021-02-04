using System;

namespace Nutzerverwaltung {
    class Program {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "q")
            {
                Console.WriteLine("Please enter the new employee's last name or (q)uit");
                input = Console.ReadLine();
                var lastName = input.Trim();
                Console.WriteLine("Please enter the new employee's first name");
                input = Console.ReadLine();
                var givenName = input.Trim();
                Employee mitarbeiter = new Employee(lastName, givenName);
                Console.WriteLine($"New employee {mitarbeiter.LastName}, {mitarbeiter.GivenName} was created.");
            }
        }
    }
}