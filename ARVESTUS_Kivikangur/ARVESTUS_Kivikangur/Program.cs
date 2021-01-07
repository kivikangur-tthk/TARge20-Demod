using System;

namespace ARVESTUS_Kivikangur
{
	class Program
	{
		static void Main(string[] args)
		{
			//Hinne3_1();
			//Hinne3_2();
			//Hinne3_3();
			//Hinne5_A();
			Hinne5_B();
		}

		private static void Hinne5_B()
		{
			//Tee programm, mis küsib kuud ja annab vastuseks kuule vastava aastaaja.
			Console.WriteLine("Sisesta kuunimi.");
			string kuu = Console.ReadLine();
			switch (kuu.ToLower())
			{
				case "detsember":
				case "jaanuar":
				case "veebruar":
				{
					Console.WriteLine("Talve kuu.");
					break;
				}
				case "märts":
				case "aprill":
				case "mai":
				{
					Console.WriteLine("Kevad kuu.");
					break;
				}
				case "juuni":
				case "juuli":
				case "august":
				{
					Console.WriteLine("Suvi kuu.");
					break;
				}
				case "september":
				case "oktoober":
				case "november":
				{
					Console.WriteLine("Sügis kuu.");
					break;
				}
				default:
				{
					Console.WriteLine("Tundmatu kuunimi");
					break;
				}
			}
		}

		private static void Hinne5_A()
		{
			//Tee programm, mis küsib nädalapäeva ja igale päevale vastab erineva tervitusega
			Console.WriteLine("Sisesta nädalapäev.");
			string paev = Console.ReadLine();
			switch (paev.ToLower())
			{
				case "esmaspäev":
				{
					Console.WriteLine("Nädala algus");
					break;
				}
				case "teisipäev":
				{
					Console.WriteLine("Teine päev juba");
					break;
				}
				default:
				{
					Console.WriteLine("Tundmatu päev.");
					break;
				}
			}
		}

		private static void Hinne3_3()
		{
			int[] arvud = {1, 2, 3, 4, 5};
		}

		private static void Hinne3_2()
		{
			/*
			while (tingimus)
			{
				laused, mida korratakse kui tingimus täitub, peale täitmist vaadatakse tingimus uuesti üle
			}

			for(initsialiseerimine;tingimus;inkrementeerimine){
				laused, mida korratakse kui tingimus täitub, koodi lõppedes tehakse inkrementeerimine ja vaadatakse tingimus uuesti üle
			}
			NÄIDE: Küsi kasutajalt arvu vahemikus 1-10, jätka küsimist kuni arv on soovitud vahemikus
			*/
			int arv;
			do
			{
				Console.WriteLine("Sisesta arv vahemikus 1-10: ");
				arv = int.Parse(Console.ReadLine());
			} while (arv<1||arv>10);
		}

		private static void Hinne3_1()
		{
			/*
			if ( tingimus )
			{
				käsud, mida täidetakse kui tingimus täitub
			}
			else {
				käsud, mida täidetakse kui tingimus ei täitu
			}
			// Näidis: Küsi nime, kui nimi on mari, siis tervita muidu ütle headaega
			*/
			Console.WriteLine("Mis on sinu nimi? ");
			string name = Console.ReadLine();
			if (name == "mari")
			{
				Console.WriteLine("Tere Mari");
			}
			else
			{
				Console.WriteLine("head aega");
			}
		}
	}
}
