using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_TÜrme_von_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int>[] Stab = new Stack<int>[3];
            Stack<int> Eins = new Stack<int>();
            Stack<int> Zwei = new Stack<int>();
            Stack<int> Drei = new Stack<int>();

            Stab[0] = Eins;
            Stab[1] = Zwei;
            Stab[2] = Drei;

            Console.WriteLine("Bitte geben Sie die Anzahl der Scheiben ein: ");

            int zahlScheiben = Int32.Parse(Console.ReadLine());
            if (zahlScheiben < 0 || zahlScheiben > 15)
            {
                Console.WriteLine("Bitte gültige Zahl eingeben!!!");
                Console.ReadKey();
            }
            else
            {
                for (int i = zahlScheiben; i > 0; i--)
                {
                    Eins.Push(i);
                }
                Bewegung(zahlScheiben, Eins, Zwei, Drei, Stab);
                Console.ReadKey();
            }

        }

        public static void Bewegung(int ScheibenZahl, Stack<int> Eins, Stack<int> Zwei, Stack<int> Drei, Stack<int>[] Stab)
        {
            if (ScheibenZahl > 0)
            {

                Bewegung(ScheibenZahl - 1, Eins, Drei, Zwei, Stab);

                Drei.Push(Eins.Pop());
                int[] stabArray1 = Stab[0].ToArray();
                int[] stabArray2 = Stab[1].ToArray();
                int[] stabArray3 = Stab[2].ToArray();
                for (int i = 0; i < stabArray1.Length; i++)
                {
                    Console.Write(stabArray1[i]);
                }
                Console.WriteLine("");
                for (int i = 0; i < stabArray2.Length; i++)
                {
                    Console.Write(stabArray2[i]);
                }
                Console.WriteLine("");
                for (int i = 0; i < stabArray3.Length; i++)
                {
                    Console.Write(stabArray3[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("---");

                Bewegung(ScheibenZahl - 1, Zwei, Eins, Drei, Stab);
            }
        }

    }
}
