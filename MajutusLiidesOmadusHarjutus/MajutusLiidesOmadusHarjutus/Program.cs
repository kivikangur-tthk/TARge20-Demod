using System;

namespace MajutusLiidesOmadusHarjutus
{
	class Program
	{
		static void Main(string[] args)
		{
			MajutusAsutus majutus = new MajutusAsutus(5.55m, 6);
			majutus.VabuKohti = 3;
			majutus.ArvutaMaksumus(2);
			Console.WriteLine($"Asutuses on vabu kohti: {majutus.VabuKohti}");
			Hotell hotell = new Hotell(99m, 100, 3);
			hotell.VabuKohti = 30;
			int tubeHõivati = hotell.ArvutaMaksumus(27);
			Console.WriteLine($"Tube hõivati {tubeHõivati}");
			Console.WriteLine($"Hotellis on vabu kohti: {hotell.VabuKohti}");
			Console.WriteLine($"Hotellis on vabu tube: {hotell.VabuTube}");

		}
	}
}
