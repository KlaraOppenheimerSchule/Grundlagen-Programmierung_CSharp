using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Math mathobj = new Math();
			Console.WriteLine(mathobj.sum(3, 4));
			Console.WriteLine(mathobj.square(3));
			Console.WriteLine(mathobj.fac(3));
			Console.WriteLine(mathobj.facrec(3));
			//TowersOfHanoi Towers = new();


		}
	}
	public class Math
	{
		public int sum( int a, int b)
		{
			return a + b;
		}
		public int square(int a)
		{
			return a * a;
		}
		public bool checkPos(int a)
		{
			return a > 0; //returns true if positive
		}
		public int fac(int a)
		{
			int result = 1;
			for (int i = 0; i <= a; i++)
			{
				result *= i;
			}
			return result;
		}
		public int facrec(int a)
		{
			if (a == 1)
			{
				return 1;
			}
			else
			{
				return a * facrec(a-1);
			}
		}
	}
	public class TowersOfHanoi
	{
		List<int> A = new();
		List<int> B = new();
		List<int> C = new();



		//public void TOH(int n, List<int> src, List<int> dest, List<int> temp)
		//{
		//	if (n == 1)
		//	{
		//		var last = A.Last();
		//		Console.WriteLine($"moving disc 1 from {src} to {dest}");

		//		return;
		//	}
		//	else
		//	{
		//		TOH(n - 1, src, temp, dest);
		//		Console.WriteLine($"moving disc {n} from {src} to {dest}");
		//		TOH(n - 1, temp, dest, src);
		//	}
		//}
	}
}
