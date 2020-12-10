using System;
using System.IO;
namespace TekstiFailiDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(File.ReadAllText("DemoAndmed.txt"));
			// Projektile lisatud faili Properties -> Copy To Output : Copy if newer
			string failiNimi = $"nimed.txt";
			FileStream fileStream = new FileStream(failiNimi, FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			while (true)
			{
				Console.WriteLine("Sisesta nimi: ");
				string nimi = Console.ReadLine();
				if (nimi=="")
				{
					break;
				}
				streamWriter.WriteLine(nimi);
			} 
			streamWriter.Close();
			fileStream = new FileStream(failiNimi, FileMode.Open, FileAccess.Read);
			StreamReader lugeja = new StreamReader(fileStream);
			string rida = lugeja.ReadLine();
			while (rida != null)
			{
				Console.WriteLine(rida.ToUpper());
				rida = lugeja.ReadLine();
			}

			File.WriteAllText("tervitus.txt", "Hello World\nTere Maailm");
			File.AppendAllText("tervitus.txt", "\nPäivää Maailma");
			string[] tervitused = File.ReadAllLines("tervitus.txt");
			for (int i = 0; i < tervitused.Length; i++)
			{
				Console.WriteLine($"{i+1}. tervitus: {tervitused[i]}");
			}
		}
	}
}
