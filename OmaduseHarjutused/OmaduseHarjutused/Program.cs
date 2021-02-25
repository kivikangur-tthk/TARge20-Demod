using System;

namespace OmaduseHarjutused
{
	class Program
	{
		static void Main(string[] args)
		{
			//*Kui temperatuuriks märgitakse üle 35, trüki hoiatusteade kahtlase väärtuse kohta
			IlmaAndmed ilma = new IlmaAndmed
			{
				Temperatuur = 35
			};
			Console.WriteLine(ilma);
			ilma.Temperatuur = 36;
			Console.WriteLine(ilma);
			//* Loo klass Kasutaja. Kasutajanimi määratakse konstruktoris, ning seda on hiljem võimalik ainult omadusena küsida, mitte muuta(set - osa puudub).Parooli saab ainult määrata, aga küsida pole võimalik(get-osa puudub). Lisa käsklus parooli kontrolliks. Lisa omadusena kasutaja telefoninumber, mida on võimalik küsida ja muuta.Kontrolli, et töötaksid vaid määratud tehted(st.et kord pandud parooli ei saaks küsida).
			Kasutaja mina = new Kasutaja("kristjan", "Kristjan123");
			//mina.Kasutajanimi = "tema";
			Console.WriteLine($"Kasutajanimi: {mina.Kasutajanimi}");
			//Console.WriteLine($"Parool: {mina.Parool}");
			if (mina.OnÕige("Kristjan123"))
			{
				Console.WriteLine("Tere "+ mina.Kasutajanimi);
			}
			else
			{
				Console.WriteLine("Tere. Sind ma ei tunne.");
			}
			Console.Write("Sisesta parool: ");
			mina.MuudaParool(Console.ReadLine());
			mina.Telefoninumber = "123-456-aff";
			Console.WriteLine(mina.Telefoninumber);

		}
	}
}
