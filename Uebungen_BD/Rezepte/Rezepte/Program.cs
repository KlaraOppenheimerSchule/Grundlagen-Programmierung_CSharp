using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezepte
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            while(a=="1")
                    {
                Console.Clear();
                Console.WriteLine("\n\t Wilkommen bei der Rezeptausgabe:");
                Console.WriteLine("\nBitte beantworten sie Folgende Fragen:");
                Console.WriteLine("\n\nSind sie 1. Gesetzlich oder 2. Privat Versichert?");
                string V1 = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("\n Ist es 1. ein Verschreibungspflichtiges Rezept oder 2. kein Verschreibungspflichtiges Rezept?");
                string V2 = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("\nFällt das Rezept unter das Betäubungsmittelgesetz? \t 1. Ja 2. Nein");
                string BTM = Console.ReadLine();

                if (V1 == "1" && V2 == "1" && BTM == "2")
                {
                    Console.WriteLine("\n ROSA");
                }
                else if (V1 == "1" && V2 == "2" && BTM == "2")
                {
                    Console.WriteLine("\n GRÜN");
                }
                else if (V1 == "2" && (V2 == "1" || V2 == "2") && BTM == "2")
                {
                    Console.WriteLine("\n BLAU");
                }
                else if ((V1 == "1" || V1 == "2") && V2 == "1" && BTM == "1")
                {
                    Console.WriteLine("\n GELB");
                }
                Console.WriteLine("\n Gaben sie noch ein Rezept? 1. Ja 2. Nein");
                a = Console.ReadLine();
            }

        }
    }
}
