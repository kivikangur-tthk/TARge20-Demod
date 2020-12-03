using System;

namespace TekstDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string juku = "Juku tuli kooli";
			Console.WriteLine("Sõne pikkus: "+juku.Length);
			Console.WriteLine("Alamsõne substring(algus,pikkus): "+juku.Substring(5,4));
			Console.WriteLine("\"tuli\" kohal "+juku.IndexOf("tuli"));

			// Muutmine
			string lisatud = juku.Insert(9, " vara");
			Console.WriteLine(lisatud);
			string eemaldatud = juku.Remove(5, 5);
			Console.WriteLine(eemaldatud);

			if (juku.StartsWith("Juku"))
			{
				Console.WriteLine("Algab sõnaga \"Juku\"");
			}
			if (juku.IndexOf("kala") == -1)
			{
				Console.WriteLine("Siin ei ole kala");
			}
			Console.WriteLine(juku.Replace("tuli","jooksis"));

			// Veel lisaks
			string a = "abraham";
			string b = "bill";
			string x = "xena   ";
			Console.WriteLine(a.CompareTo(b));
			Console.WriteLine(b.CompareTo(a));
			Console.WriteLine(a.CompareTo(a));
			Console.WriteLine(a.CompareTo(x));

			Console.WriteLine(x.Trim()+"lõpp");
			//Console.WriteLine(a.Trim(new char[]{'a','m'}));
			Console.WriteLine(juku.ToLower());

			if (juku.ToLower().StartsWith("juku"))
			{
				Console.WriteLine("Sõltumata tähe suurusest on tegemist jukuga");
			}
			var xenaTähed = x.Trim().ToCharArray();
			for (int i = 0; i < xenaTähed.Length; i++)
			{
				Console.WriteLine(xenaTähed[i]);
			}

			// Tükeldamine 
			string linnaNimedeCSV = "Tallinn,Tartu,Narva,";
			var sep = new char[] { ',' };
			string[] linnad = linnaNimedeCSV.TrimEnd(sep).Split(sep);
			foreach (var linn in linnad)
			{
				Console.WriteLine(linn);
			}
			Console.WriteLine($"Linnasid on {linnad.Length}");
			Console.WriteLine(string.Join(";",linnad));
		}
	}
}
