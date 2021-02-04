using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BestFriends {
    class Program {
        static void Main(string[] args) {
            string[] baf = {"Bilbo", "Frodo", "Sauron"};
            foreach (string friend in baf) {
                Console.WriteLine(friend);
            }
            Console.WriteLine();


            string friendToRemove = "Sauron";
            baf = baf.Where(validationAttribute => validationAttribute != friendToRemove).ToArray();
            foreach (string friend in baf) {
                Console.WriteLine(friend);
            }
            Console.WriteLine();

            string[] bafN = new string[3];
            bafN[0] = "Uschi";
            int      index = 0;
            foreach (string friend in baf) {
                index++;
                if (index >= 0 && bafN.Length > index) bafN[index] = friend;
            }
            foreach (string friend in bafN) Console.WriteLine(friend);
            Console.WriteLine();
        }
    }
}
