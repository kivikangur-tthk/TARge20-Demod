using System;

namespace EsimeneHarjutus
{
	class Program
	{
		/*
		 •	Muuda väljatrükitavat teksti
•	Kirjuta ekraanile kaks rida (kaks järjestikust Console.WriteLine käsklust, kumbki omal real)
•	Tekita programmi sisse väikeseid vigu, ja vaata, mis kompilaator selle peale teatab. Paranda tagasi ja veendu, et programm töötab jälle. Näiteks kaota ära n-täht sõnast Console, üks jutumärk "Tere" ümbert, üks sulg, semikoolon, muuda klassi nime. Ja igal korral jäta meelde või soovi korral suisa märgi üles, kas ja milline viga oli tegelikult ning millise veateate andis kompilaator. Sellised on kõige tüüpilisemad kompileerimisel tekkivad vead. Kord väikese programmi juures läbi katsetatuna on kergem sellistest veateadetest ka suures rakenduses aru saada.
 */

		static void Main(string[] args)
		{
			Console.WriteLine("Sisesta oma nimi:");
			string nimi = Console.ReadLine();

			Console.WriteLine("Sisesta oma vanus täisarvuna:");
			string vanuseTekst = Console.ReadLine();
			int vanus = int.Parse(vanuseTekst);
			Console.WriteLine($"Viie aasta pärast oled {vanus+5} aastane");

			Console.WriteLine("Tere Hommikust "+nimi+".");
			Console.WriteLine($"Tere hommikust {nimi}.");
						
			Console.WriteLine("Tere Õhtust.");
		}
	}
}
