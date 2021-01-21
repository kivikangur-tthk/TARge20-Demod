using System;

namespace PärilusDemo
{
	class Program
	{
		static bool MahubSuguvõsa(Elamu elamu)
		{
			if (elamu is Korter && elamu.AnnaTubadeArv() > 3)
			{
				return true;
			}
			else if (elamu.AnnaTubadeArv() > 5)
			{
				return true;
			}
			return false;
		}

		static void Main(string[] args)
		{
			Elamu elamu = new Elamu(6, "Metsatuka 7, Kiili", 2,true);
			Korter korter = new Korter(4, "Metsatuka 12, Kiili", 7);
			elamu.KuvaAndmed();
			korter.KuvaAndmed();
			korter.KuvaAadress();
			if (MahubSuguvõsa(elamu))
			{
				Console.WriteLine("Jah mahub elamusse");
			}
			if (MahubSuguvõsa(korter))
			{
				Console.WriteLine("Jah mahub korterisse");
			}
		}
	}
}
