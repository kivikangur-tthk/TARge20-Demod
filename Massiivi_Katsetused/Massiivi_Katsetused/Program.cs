using System;

namespace Massiivi_Katsetused
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] m = new int[] { 1, 2, 3, 7, 6, 5 };
			m[5] = 11;
			int summa = 0;
			for (int i = 0; i < m.Length; i++)
			{
				Console.WriteLine($"Väärtus positsioonil: m[{i}] == {m[i]}");
				summa += m[i];
			}
			//Console.WriteLine($"Väärtus positsioonil: m[{m.Length}] == {m[m.Length]}");
			Console.WriteLine($"Massiviis olevate väärtuste summa on {summa}.");
			Array.Sort(m);
			Array.Reverse(m);
			KuvaMassiiv(m);
			int[] m2 = m;
			Console.WriteLine($"m[0] == {m[0]} == m2[0] == {m2[0]}");
			m2[0] = 7;
			Console.WriteLine($"m[0] == {m[0]} == m2[0] == {m2[0]}");
			KuvaMassiiv(m);
			DubleeriMassiiv(m2);
			KuvaMassiiv(m);
			Console.WriteLine("Massiivi koopia");
			int[] m3 = (int[]) m.Clone(); 

		}

		private static void KuvaMassiiv(int[] m)
		{
			for (int i = 0; i < m.Length; i++)
			{
				Console.WriteLine($"Väärtus positsioonil: m[{i}] == {m[i]}");
			}
		}
		private static void DubleeriMassiiv(int[] arvud)
		{
			for (int i = 0; i < arvud.Length; i++)
			{
				// m[i] = m[i] * 2;
				arvud[i] *= 2; // samaväärne eelmisega
			}
		}
	}
}
