using System;

namespace Überladung_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple Granny_Smith = new Apple("green", 2.56);
            Granny_Smith.SetProperty("red");
            Granny_Smith.SetProperty(1.456);
            Console.WriteLine(Granny_Smith.GetColour());
            Console.WriteLine(Granny_Smith.GetWheight());
        }
        class Apple
        {
            private string Colour;
            private double wheight;

            public Apple(string Colour, double wheight)
            {
                this.Colour = Colour;
                this.wheight = wheight;
            }

            public void SetProperty(string Colour)
            {
                this.Colour = Colour;
            }
            public void SetProperty(double wheight)
            {
                this.wheight = wheight;
            }
            public string GetColour()
            {
                return this.Colour;
            }

            public double GetWheight()
            {
                return this.wheight;
            }
        }
    }
}
