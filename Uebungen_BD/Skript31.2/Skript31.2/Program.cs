using System;

namespace Skript31._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double durchschnitt = (1020 + 923 + 780 + 890) / 4;
            double verbrauch = 70 / (durchschnitt / 100);
            Console.WriteLine("Die Druschnittliche Reichweite beträgt: "+ durchschnitt);
            Console.WriteLine("Der Durschnittsverbrauch beträgt: " + verbrauch + " Liter auf 100km");
        }
    }
}
