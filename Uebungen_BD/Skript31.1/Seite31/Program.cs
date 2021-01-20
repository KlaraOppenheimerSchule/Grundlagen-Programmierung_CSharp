using System;

namespace Seite31
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3];
            array1[0] = "Freund A";
            array1[1] = "Freund B";
            array1[2] = "Freund C";

            Console.WriteLine(array1[0]+" "+array1[1]+" "+array1[2]);

            for (int i = 0; i == 0;)
            {
                Console.WriteLine("Welcher Freund fiel in Ungnade?");
                string ungnade = Console.ReadLine();
                if (ungnade == array1[0])
                {
                    array1[0] = "";
                    Console.WriteLine("Ihre Feunde sind: ");
                    Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);
                    i = 1;
                }
                else if (ungnade == array1[1])
                {
                    array1[1] = "";
                    Console.WriteLine("Ihre Feunde sind: ");
                    Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);
                    i = 1;
                }
                else if (ungnade == array1[2])
                {
                    array1[2] = "";
                    Console.WriteLine("Ihre Feunde sind: ");
                    Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Keiner ihrer Freunde!");
                }
            }

            Console.WriteLine("Ist Uschi deine neue Freundin?");
            string uschi = Console.ReadLine();
            if(uschi == "ja" || uschi == "Ja")
            {
                Console.WriteLine("Ihre Freunde sind: ");
                Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2] + " " + "Uschi");
            }
            else
            {
                Console.WriteLine("Ihre Freunde sind: ");
                Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);
            }

        }
    }
}
