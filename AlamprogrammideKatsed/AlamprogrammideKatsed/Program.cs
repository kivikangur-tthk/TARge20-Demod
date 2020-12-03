using System;

namespace AlamprogrammideKatsed
{
	class Program
	{
		static void Main(string[] args)
		{
			int arv = KüsiArv("Sisesta arv: ");
			Console.WriteLine(arv);
			// Tee alamprogramm, mis küsib arvu antud vahemikus
			arv = KüsiArv(1,5);

		}

		private static int KüsiArv(int aluminePiir,int üleminePiir)
		{
			int tulemus;
			do
			{
				tulemus = KüsiArv($"Sisesta Arv vahemikus {aluminePiir}-{üleminePiir}: ");
			} while (tulemus<aluminePiir || tulemus>üleminePiir );
			return tulemus;
		}

		private static int KüsiArv(string küsimus)
		{
			Console.WriteLine(küsimus);
			return int.Parse(Console.ReadLine());
		}
	}
}
