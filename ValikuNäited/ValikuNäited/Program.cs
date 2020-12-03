using System;

namespace ValikuNäited
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Sisesta oma nimi: ");
			string nimi = Console.ReadLine();
			if (nimi.ToLower() == "mari")
			{
				Console.WriteLine("Tule homme minu juurde!");
			}
			else
			{
				Console.WriteLine("Mind pole homme kodus");
			}
			Console.WriteLine("Sisesta oma vanus: ");
			int vanus = int.Parse(Console.ReadLine());

			if (vanus > 14)
			{
				Console.WriteLine("Tuleb osta täispilet");
			}
			else
			{
				Console.WriteLine("Oled 14 või noorem.");
			}
			if (vanus > 6 && vanus <= 14)
			{
				Console.WriteLine("Sinu jaoks on lapsepilet.");
			}
			if (vanus < 7 || vanus > 14)
			{
				Console.WriteLine("Sulle lapsepilet ei sobi");
			}
			Console.Write("Sisesta nädala päev: ");
			string päev = Console.ReadLine();

			if (päev.ToLower() == "esmaspäev")
			{
				Console.WriteLine("Ilusat töönädalat");
			}
			else if (päev.ToLower() == "kolmapäev")
			{
				Console.WriteLine("Pool nädalat on juba möödas");
			}
			else if (päev.ToLower() == "reede")
			{
				Console.WriteLine("Toredat nädalavahetust");
			}
			else if (päev.ToLower() == "laupäev" || päev.ToLower() == "pühapäev")
			{
				Console.WriteLine("Puhka hästi");
			}
			else
			{
				Console.WriteLine("Head tööpäeva");
			}

			switch (päev.ToLower())
			{
				case "esmaspäev":
					{
						Console.WriteLine("Ilusat töönädalat");
						break;
					}
				case "kolmapäev":
					{
						Console.WriteLine("Pool nädalat on juba möödas");
						break;
					}
				case "reede":
					{
						Console.WriteLine("Toredat nädalavahetust");
						break;
					}
				case "laupäev":
				case "pühapäev":
					{
						Console.WriteLine("Puhka hästi");
						break;
					}
				default:
					{
						Console.WriteLine("Head tööpäeva");
						break;
					}
			}
		}
	}
}
