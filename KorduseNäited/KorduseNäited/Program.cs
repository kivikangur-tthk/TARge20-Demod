using System;

namespace KorduseNäited
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int i = 0; i < 10; i++)
			{
			Console.WriteLine($"{i+1}. Hello World!");
			}
			int nr = 1;
			while (nr<=10)
			{
				Console.WriteLine($"While {nr}.");
				nr++;
			}
			//do
			//{
			//	Console.WriteLine("sisesta arv, mis on suurem kui 10");
			//	nr = int.Parse(Console.ReadLine());
			//} while (nr<=10);
			// Korduse katkestamine (break) ja vahele jätmine (continue)			
			for (int i = 0; i < 20; i++)
			{
				if (i==3 || i==6) // kui i on paarisarv
				{
					continue; // vahele jätmine
				}
				Console.Write(i);
				if (i == 7)
				{
					break; // katkesta tsükkel
				}
			}
			Console.WriteLine();

			// kordus, mis kuvab järgmise jada 1,3,5,7,9,11,13,15
			for (int i = 1; i < 16; i+=2)
			{
				Console.Write(i);
			}

			// Küsi inimese käest arve kuni tühja sisestuseni
			// liida kõik kokku ja kirjuta tulemus ekraanile
			//int arv = int.Parse(string.Empty);
			
			// HINDELINE
			/* Küsi kasutajalt nime ja vanust, kuni tühja sisestuseni.
			 * Teata, kes on kõige vanem ja kui vana ta on.
			 */
			int summa = 0;
			while (true)
			{
				Console.WriteLine("Sisesta summale lisatav täisarv või mitte midagi summa saamiseks:");
				string sisestus = Console.ReadLine();
				if (sisestus==string.Empty)
				{
					break;
				}
				summa += int.Parse(sisestus);
			}
			Console.WriteLine($"Sisestatud arvude summa on {summa}");
		}
	}
}
