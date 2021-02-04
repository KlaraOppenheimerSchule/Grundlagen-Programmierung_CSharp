using System;
using System.Linq;

namespace Kilometeter {
    class Program {
        static void Main(string[] args) {
            int[]  drivenDistanceWithSingleTankfulInKilometer = new int[] {1020, 923, 780, 890};
            double arithmeticMeanDistanceRange                = drivenDistanceWithSingleTankfulInKilometer.Average();
            int    singleTankfulInLiters                       = 70;
            double    aritmeticMeanFulRange                   = singleTankfulInLiters * arithmeticMeanDistanceRange;
            Console.WriteLine(aritmeticMeanFulRange);
        }
    }
}
