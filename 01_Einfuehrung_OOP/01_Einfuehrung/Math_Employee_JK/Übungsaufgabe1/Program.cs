using System;


namespace Übungsaufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathForSchool myMath = new MyMathForSchool();


            //Aufgabe 1.a

            Console.WriteLine("Bitte geben Sie einen Integer-Wert ein :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie zweiten Integer-Wert ein :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Das Ergebnis der Summe ist : " + myMath.GetSum(a, b));



            Console.ReadLine();

            //Aufgabe 1.b
            Console.WriteLine("Bitte geben Sie eine Zahl vom Typ Double ein : ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Die Quadratzahl der Eingabe ist : " + myMath.GetSquaredNumber(c));


            Console.ReadLine();

            //Aufgabe 1.c

            Console.WriteLine("CheckPositiveFunction");
            Console.WriteLine("Bitte geben Sie eine Zahl ein : ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(myMath.CheckNumberPositive(d));

            Console.ReadLine();

            //Aufgabe 1.d

            Console.WriteLine("Bitte geben Sie eine Zahl ein : ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Die Fakultät ihrer Zahl lautet . " + myMath.GetFactorialNumber(e));


            Console.ReadLine();

            //Create Server-User

            Console.WriteLine("Bitte geben Sie ihren Nachnamen ein : ");
            string userLastName = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie ihren Vornamen ein : ");
            string userFirstName = Console.ReadLine();

            employee newemployee = new employee(userLastName, userFirstName);



            Console.WriteLine($"Der neue User heißt: {newemployee.getLastName()}, {newemployee.getFirstName()}");


        }

    





    }
    class employee
    {
        private string LastName;
        private string FirstName;

        public employee (string LastName, string FirstName)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
        }

        public string getLastName()
        {
            return this.LastName;
        }
        public string getFirstName()
        {
            return this.FirstName;
        }
        public void setLastName(string LastName)
        {
            this.LastName = LastName;

        }
        public void setFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        //public string LastName { get; set; }
        //public string FirstName { get; set; }

    }
    class MyMathForSchool
    {

        public double GetSum(double a, double b)
        {
            return (a + b);
        }

        public double GetAbsNumber(double a)
        {
            return (Math.Abs(a));
        }
        public double GetSquaredNumber(double a)
        {
            return (a * a);
        }

        public bool CheckNumberPositive(double a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public int GetFactorialNumber(int a)
        {
            int temp = 1;
            for (int i = a; i >= 1; i--)
            {
                temp = temp * i;  //temp *= i
            }
            return temp; 
        }


    
    }
}
