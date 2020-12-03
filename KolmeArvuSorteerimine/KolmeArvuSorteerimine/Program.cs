using System;

namespace KolmeArvuSorteerimine
{
	class Program
	{
		static void Main(string[] args)
		{
			// Küsi kolm arvu ja kuva need suurimast väikseimani.
			Console.WriteLine("Sisesta esimene täisarv: ");
			int arv1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Sisesta teine täisarv: ");
			int arv2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Sisesta kolmas täisarv: ");
			int arv3 = int.Parse(Console.ReadLine());
			if (arv1<arv2 && arv1<arv3)
			{
				Console.WriteLine($"Väikseim: {arv1}");
			}
			else if (arv2<arv1 && arv2<arv3)
			{
				Console.WriteLine($"Väikseim: {arv2}");
			}
			else
			{
				Console.WriteLine($"Väikseim: {arv3}");
			}
			if((arv1>arv2 && arv1 < arv3)||(arv1>arv3 && arv1 < arv2))
			{
				Console.WriteLine($"Keskmine: {arv1}");
			}
			else if ((arv2 > arv1 && arv2 < arv3) || (arv2 > arv3 && arv2 < arv1))
			{
				Console.WriteLine($"Keskmine: {arv2}");
			}
			else
			{
				Console.WriteLine($"Keskmine: {arv3}");
			}
			if (arv1 > arv2 && arv1 > arv3)
			{
				Console.WriteLine($"Suurim: {arv1}");
			}
			else if (arv2 > arv1 && arv2 > arv3)
			{
				Console.WriteLine($"Suurim: {arv2}");
			}
			else
			{
				Console.WriteLine($"Suurim: {arv3}");
			}
		}
	}
}
