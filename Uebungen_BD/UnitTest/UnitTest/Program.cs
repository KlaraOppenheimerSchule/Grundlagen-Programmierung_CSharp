using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b;

            while (a == 1)
            {
                Console.Clear();
                Console.WriteLine("Welche Fläche möchten sie berrechnen?");
                Console.WriteLine("\n");
                Console.WriteLine("1. Dreieck \n");
                Console.WriteLine("2. Viereck \n");
                string auswahl = Console.ReadLine();
                if (auswahl == "1")
                {
                    Dreieck();
                    Console.WriteLine("\n Möchten sie 1. Zum Start 2. Beenden?");
                    b = Console.ReadLine();
                    if (b == "2")
                    {
                        a = 0;
                    }

                }
                else if (auswahl == "2")
                {
                    Viereck();
                    Console.WriteLine("\n Möchten sie 1. Zum Start 2. Beenden?");
                    b = Console.ReadLine();
                    if (b == "2")
                    {
                        a = 0;
                    }
                }
                else
                {
                    Console.Clear();
                    a = 1;
                }
                }
            }
            

        
        public static void Dreieck()
        {
            double SeiteA;
            double SeiteB;
            double SeiteC;
            double Adreieck;
            double S;

            Console.Clear();
            Console.WriteLine("\n\t\tDie Fläche des Dreiecks:");
            Console.WriteLine("\n");
            Console.WriteLine("Bitte geben sie Seite A ein: \t");
            SeiteA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben sie Seite B ein: \t");
            SeiteB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben sie Seite C ein: \t");
            SeiteC = Double.Parse(Console.ReadLine());

            S = (SeiteA + SeiteB + SeiteC) / 2;
            Adreieck = Math.Sqrt(S * (S - SeiteA) * (S - SeiteB) * (S - SeiteC));
            Console.WriteLine("Die Fläche beträgt: \t" + Adreieck);
            
        }

        public static void Viereck()
        {
            double SeiteA;
            double SeiteB;
            double Aviereck;

            Console.Clear();
            Console.WriteLine("\n\t\tDie Fläche des Vierecks:");
            Console.WriteLine("\n");
            Console.WriteLine("Bitte geben Sie Seite A ein: \t");
            SeiteA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Seite B ein: \t");
            SeiteB = Double.Parse(Console.ReadLine());
            Aviereck = SeiteA * SeiteB;
            Console.WriteLine("Die Fläche beträgt: \t" + Aviereck);
                    
        }
    }
}
