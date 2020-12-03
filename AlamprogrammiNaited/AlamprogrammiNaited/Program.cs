using System;

namespace AlamprogrammiNaited
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 3, b = 4;
			Console.WriteLine($"{a} korda {b} on {Korruta(a,b)}");
			Console.WriteLine(Korruta(3,5));
		}

		private static int Korruta(int a, int b)
		{
			return a * b;
		}
	}
}
