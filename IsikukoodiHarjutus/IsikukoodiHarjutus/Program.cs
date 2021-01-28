using System;

namespace IsikukoodiHarjutus
{
	class Program
	{
		static void Main(string[] args)
		{
			Isikukood mina = new Isikukood("37908220120");
			Console.WriteLine($"Sünni päev: {mina.AnnaPaev()}");
			Console.WriteLine($"Sünni kuu: {mina.AnnaKuu()}, {mina.AnnaKuuNimi()}");
			Console.WriteLine($"Sünni aasta: {mina.AnnaAasta()}");
			Console.WriteLine($"Sünni kuupäev: {mina.AnnaSünnikuupäev().ToShortDateString()}");
		}
	}
}
