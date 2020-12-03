using System;

namespace AlamprogrammidArvutamine
{
	class Program
	{
		static void Main(string[] args)
		{
			// Küsi kasutajalt kaks arvu (5,6) ja tehe (+).
			// Tee arvutused alamprogrammis.
			// kuva tulemused ekraanile alamprogrammis - 5+6=11.
			double arv1 = KüsiArv("Sisesta esimene arv: ");
			double arv2 = KüsiArv("Sisesta teine arv: ");
			string tehe = Küsi("Sisesta tehe: [+,-,*,/,^] ");
			double tulemus = Arvuta(arv1, arv2, tehe);
			KuvaTulemus(arv1, arv2, tehe, tulemus);
		}

		private static void KuvaTulemus(double arv1, double arv2, string tehe, double tulemus)
		{
			Console.WriteLine($"{arv1}{tehe}{arv2}={tulemus}");
		}

		private static double Arvuta(double arv1, double arv2, string tehe)
		{
			double tulemus;
			switch (tehe)
			{
				case "+": {
						tulemus = Liida(arv1, arv2);
						break;
					}
				case "-":
					{
						tulemus = Lahuta(arv1, arv2);
						break;
					}
				case "*":
					{
						tulemus = Korruta(arv1, arv2);
						break;
					}
				case "/":
					{
						tulemus = Jaga(arv1, arv2);
						break;
					}
				case "^":
					{
						tulemus = Astenda(arv1, arv2);
						break;
					}
				default:
					{
						throw new Exception($"Tundmatu tehe: {tehe}");
					}
			}
			return tulemus;
		}

		private static double Astenda(double arv1, double arv2)
		{
			throw new NotImplementedException();
		}

		private static double Jaga(double arv1, double arv2)
		{
			throw new NotImplementedException();
		}

		private static double Korruta(double arv1, double arv2)
		{
			throw new NotImplementedException();
		}

		private static double Lahuta(double arv1, double arv2)
		{
			throw new NotImplementedException();
		}

		private static double Liida(double arv1, double arv2)
		{
			return arv1 + arv2;
		}

		private static string Küsi(string küsimus)
		{
			Console.WriteLine(küsimus);
			return Console.ReadLine();
		}

		private static double KüsiArv(string küsimus)
		{
			return int.Parse(Küsi(küsimus));
		}
	}
}
