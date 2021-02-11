using System;

namespace LiidesedHarjutus
{
	class Program
	{
		static void Main(string[] args)
		{
			Riidelapp riidelapp = new Riidelapp();
			riidelapp.Laius = 20;
			riidelapp.Pikkus = 30;
			riidelapp.Toon = "Sinine";
			Console.WriteLine($"Riidelapp on {riidelapp.Toon} värvi");
			Console.WriteLine($"laius on {riidelapp.Laius}");
			Console.WriteLine($"pikkus on {riidelapp.Pikkus}");

			for (int i = 0; i < 20; i++)
			{
				riidelapp.KuvaAndmed();
			}
			
		}
	}
}
