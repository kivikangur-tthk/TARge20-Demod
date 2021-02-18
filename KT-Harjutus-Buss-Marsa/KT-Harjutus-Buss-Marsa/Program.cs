using System;

namespace KT_Harjutus_Buss_Marsa
{
	class Program
	{
		static void Main(string[] args)
		{
			Buss väikebuss = new Buss("Kollane", 5, "Ford", 2000);
			Buss liiniBuss = new Buss("Roheline", 49, "Ikarus", 1977);
			väikebuss.KuvaAndmed();
			väikebuss.KuvaVanusAastal2030();
			väikebuss.LaeReisijaid(5);
			väikebuss.KuvaAndmed();
			väikebuss.LaeReisijaid(-5);
			väikebuss.KuvaAndmed();
			//väikebuss.Pikkus = "seitse";
			Console.WriteLine($"väikebussi pikkus: {väikebuss.Pikkus}");
			Console.WriteLine($"liini bussi pikkus: {liiniBuss.Pikkus}");
			Marsa marsa = new Marsa(5.55m, 7, "roosa", "VW", 2020);			
			Console.WriteLine("===== Marsa =====");
			for (int i = 0; i < 10; i++)
			{
				marsa.LaeReisijaid(i);
				marsa.KuvaAndmed();
			}
			for (int i = 1 - 1; i >= -10; i--)
			{
				marsa.LaeReisijaid(i);
				marsa.KuvaAndmed();
			}
		}
	}
}
