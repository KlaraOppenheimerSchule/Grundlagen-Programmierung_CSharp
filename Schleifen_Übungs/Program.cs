using System;
using System.Collections;

namespace Schleifen_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Matheklasse = new Math();
            //Matheklasse.Zahlen_1_bis_1000();
            //Matheklasse.Einmal_eins_tabelle();
            /*
            Console.WriteLine("PIN - GENERATOR");
            Console.WriteLine("===============");
            Console.WriteLine("");
            Console.Write("Wie viele Pin-Codes möchten Sie erstellen ? :: ");
            int amount_Pin_Codes = int.Parse(Console.ReadLine());
            Console.Write("Wie viele Stellen sollen die Pin-Codes haben ? :: ");
            int amount_Nos = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            pin_Generator my_pin_Generator = new pin_Generator();
            my_pin_Generator.GeneratePinCodes(amount_Pin_Codes, amount_Nos);
            Console.ReadKey();
            */

            Console.WriteLine("Abschreibungsrechner");
            Console.WriteLine("====================");
            Console.WriteLine();
            Console.Write("Bitte geben sie den Gesamtwert ein : ");
            int Gesamtwert = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie die Abschreibungsdauer ein : ");
            int Abschreibungsdauer = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie das Anschaffungsjahr ein : ");
            int Anschaffungsjahr = int.Parse(Console.ReadLine());
            Abschreibungsrechner my_Abschreibungsrechner = new Abschreibungsrechner(Abschreibungsdauer, Gesamtwert, Anschaffungsjahr);
            my_Abschreibungsrechner.Show_Abschreibung_in_Se_Konsole();
            Console.ReadKey();
        }
    }
    public class Abschreibungsrechner
{
	private int Abschreibungsdauer;
	private int Gesamtwert;
	private int Abschreibungsbetrag;
	private int Anschaffungsjahr;

	public Abschreibungsrechner(int Abschreibungsdauer, int Gesamtwert,  int  Anschaffungsjahr)
	{
		this.Abschreibungsdauer = Abschreibungsdauer;
		this.Gesamtwert = Gesamtwert;
		this.Abschreibungsbetrag = Gesamtwert / Abschreibungsdauer;
		this.Anschaffungsjahr = Anschaffungsjahr;
	}

	public void Show_Abschreibung_in_Se_Konsole()
    {
        Console.WriteLine("\n" + "Abschreibejahr" + "\t" + "Anfangsbetrag" + "\t" + "Abschreibungsbetrag" + "\t" + "Restbetrag");
            Console.WriteLine("==============" + "\t" + "=============" + "\t" + "===================" + "\t" + "==========");
		for (int i = 0; i < this.Abschreibungsdauer; i++)
        {
			int Abschreibejahr = Anschaffungsjahr + i;
			int Anfangsbetrag = Gesamtwert - (i * this.Abschreibungsbetrag);
			int Restbetrag = Anfangsbetrag - this.Abschreibungsbetrag;
            Console.WriteLine();
			Console.Write(Abschreibejahr + "\t\t" + Anfangsbetrag +" $\t\t" +this.Abschreibungsbetrag + " $\t\t\t" + Restbetrag +" $\n");
        }
    }
}
    class Math
    {
        private int Zahl;
        public void Zahlen_1_bis_1000()
        {
            do
            {
                Console.WriteLine(Zahl);
                Zahl++;
            } while (Zahl <= 1000);
        }
        public void Einmal_eins_tabelle()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    Console.Write((i * z) + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
    class pin_Generator
    {
        public void GeneratePinCodes(int amount_Pin_Codes, int amount_Nos)
        {
            ArrayList Pin_Code_List = new ArrayList(amount_Pin_Codes);
            Random randNo = new Random();
            string Pin_code;
            for (int y = 1; y <= amount_Pin_Codes; y++)
            {
                do
                {
                    Pin_code = "";
                    for (int x = 1; x <= amount_Nos; x++)
                    {                        
                        int rand = randNo.Next(0, 10);
                        rand.ToString();
                        Pin_code += rand;
                    }
                    Console.WriteLine(Pin_code);
                }while (Pin_Code_List.Contains(Pin_code));
                Pin_Code_List.Add(Pin_code);
            }
            foreach (object Pin in Pin_Code_List)
            {
                Console.WriteLine(Pin);
            }
        }
    }
}
