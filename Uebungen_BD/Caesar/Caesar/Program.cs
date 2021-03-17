using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Möchten sie 1. Verschlüsseln oder 2. Entschlüsseln");

            int i = 0;

            while (i < 1)
            {
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Geben Sie den zu versclüsselnden Text ein");
                    string inputText = Console.ReadLine();
                    inputText = inputText.ToUpper();
                    Console.WriteLine(inputText);
                }
                else if (Console.ReadLine() == "2")
                {

                }
            }
        }
    }
}
