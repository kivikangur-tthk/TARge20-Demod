using System;

namespace ArvestuseHarjutamine
{
	/// <summary>
	/// Ettevõte
//•	Osakondade arv
//•	Töötajate arv
//•	Ettevõtte nimi
//•	Tegevusala

//Klassimuutuja - ettevõteteKogus
//Omadus – TöötajateArv - Saab küsida töötajate arvu, aga mitte muuta, kui arv on negatiivne, siis väljastada error.
//Meetod – LisaTöötaja() - töötajate arvule lisada 1 töötaja
//Pärilus: Korporatsioon - lisaks ettevõtte väljadele on veel muutujaks tegutsemise riik, juhatuse suurus.
//Ülekate LisaTöötaja() – iga 100 töötaja jaoks peab olema üks juhatuse liige.


//Liides: Rahvusvaheline – TeataNimi(string keel);

	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Ettevõte ettevõte = new Ettevõte(5, -50, "Skype", "IT");
			Console.WriteLine(ettevõte);
			for (int i = 0; i < 50; i++)
			{
				ettevõte.LisaTöötaja();
			}
			Console.WriteLine(ettevõte.TöötajateArv);
			Korporatsioon korporatsioon = new Korporatsioon(100, 10000, "Microsoft", "IT", "USA", 100);
			Console.WriteLine(korporatsioon);
			for (int i = 0; i <= 99; i++)
			{
				korporatsioon.LisaTöötaja();
			}
korporatsioon.LisaTöötaja();
			Console.WriteLine(korporatsioon);
			IRahvusvaheline rahvusvaheline = korporatsioon;

			rahvusvaheline.TeataNimi("eesti");
		}
	}
}
