using System;

namespace Skript3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[6];
            Random rnd = new Random();

            int n = 0;
            while (n < 6)
            {
                int a = 0;
                a = rnd.Next(1, 50);
                array1[n] = a;
                n++;
            }

            Console.WriteLine("Was ist ihr Tip? Zahlen von 1 bis 49!");
            int[] array2 = new int[6];

            n = 0;
            while (n<6)
            {
                Console.WriteLine("Tip " + (n+1));
                array2[n] = Int32.Parse(Console.ReadLine());
                while(array2[n]>49 || array2[n]<0)
                {
                    Console.WriteLine("Diese Eingabe is nicht Gültig bitte eine Zahl zwischen 1 und 49 wählen!");
                    Console.WriteLine("Tip " + (n + 1));
                    array2[n] = Int32.Parse(Console.ReadLine());
                }
                n++;
            }

            Console.WriteLine("Die Lotozahlen lauten:");
            for (n = 0; n < 6; n++)
            {
                Console.WriteLine(array1[n]);
            }

            Console.WriteLine("Zum Vergleichen:");
            PrintValues(array1);
            PrintValues(array2);
        }
        public static void PrintValues(int[] myArr)
        {
            foreach (int i in myArr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
        }
    }

}

