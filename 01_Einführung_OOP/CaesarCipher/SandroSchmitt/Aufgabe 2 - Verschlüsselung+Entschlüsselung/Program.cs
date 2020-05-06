using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2___Verschlüsselung_Entschlüsselung
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool showMenu = true;

                while (showMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Bitte eine Option auswählen:");
                    Console.WriteLine("1) Verschlüsseln");
                    Console.WriteLine("2) Entschlüsseln");
                    Console.WriteLine("3) Wort herausfinden");
                    Console.WriteLine("4) Exit");
                    Console.Write("\r\nOption auswählen: ");



                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Bitte Text zum Verschlüsseln eingeben:");
                            string input = Console.ReadLine();

                            Console.WriteLine("Bitte Schlüssel eingeben:");
                            int key = Convert.ToInt32(Console.ReadLine());

                            Cryptograph cryptograph = new Cryptograph();
                            Console.WriteLine(cryptograph.Encrypt(input, key));
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Bitte Text zum Entschlüsseln eingeben:");
                            string input2 = Console.ReadLine();

                            Console.WriteLine("Bitte Schlüssel eingeben:");
                            int key2 = Convert.ToInt32(Console.ReadLine());

                            Cryptograph cryptograph2 = new Cryptograph();
                            Console.WriteLine(cryptograph2.Decrypt(input2, key2));
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Bitte Wort eingeben:");
                            string input3 = Console.ReadLine();

                            Cryptograph cryptograph3 = new Cryptograph();
                            cryptograph3.FindWord(input3);
                            Console.ReadLine();
                            break;

                        case "4":
                            showMenu = false;
                            break;
                        default:
                            showMenu = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
