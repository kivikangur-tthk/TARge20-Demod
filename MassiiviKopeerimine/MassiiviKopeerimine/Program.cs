using System;

namespace MassiiviKopeerimine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Massiivi kopeerimine.");
			int[] m = new int[] { 1,2,3,4,5,6,7 };
			int[] m_koopia = (int[])m.Clone();
			KuvaMassiiv(m);
			KuvaMassiiv(m_koopia);
			Console.WriteLine("Toimub koopia poolitamine");
			Poolita(m_koopia);
			KuvaMassiiv(m);
			KuvaMassiiv(m_koopia);
		}

		private static void Poolita(int[] arvud)
		{
			for (int i = 0; i < arvud.Length; i++)
			{
				arvud[i] /= 2;
			}
		}

		private static void KuvaMassiiv(int[] arvud)
		{
			foreach (var arv in arvud)
			{
				Console.Write($"{arv}, ");
			}
			Console.WriteLine();
		}
	}
}
