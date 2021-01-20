using System;

namespace Skript3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1,2,3,4,5,6,7,8,9 };
            PrintValues(array1);
            Array.Reverse(array1);
            PrintValues(array1);

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
