using System;

namespace AbstraktneKlassDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Kujund kujund = new Tikutops();
			Console.WriteLine(kujund);
			kujund = new Vorstijupp(5, 10);
			Console.WriteLine(kujund);
			Kujund teineJupp = new Vorstijupp(5, 10.00001);
			if (kujund.Equals(teineJupp))
			{
				Console.WriteLine("On võrdsed");
			}
			else
			{
				Console.WriteLine("Erinevad");
			}
			kujund = new Tikutops();
			Console.WriteLine(kujund);
			kujund = new Risttahukas(2,4,1.5);
			Console.WriteLine(kujund);

			Kujund[] kujundid = new Kujund[100];
			for (int i = 0; i < kujundid.Length; i++)
			{
				if (i%3 == 0)
				{
					kujundid[i] = new Tikutops();
				}
				else if (i%3 == 1)
				{
					kujundid[i] = new Vorstijupp(i, i);
				}
				else
				{
					kujundid[i] = new Risttahukas(i, i, i);
				}
				Console.WriteLine(kujundid[i]);
			}
			decimal ruumaladeSumma = ArvutaRuumaladeSumma(kujundid);
			double pindaladeSumma = ArvutaPindaladeSumma(kujundid);
			Console.WriteLine($"Kujundite kogupindalade summa on {pindaladeSumma}");
			Console.WriteLine($"Kujundite ruumalade summa on {ruumaladeSumma}");
		}

		private static double ArvutaPindaladeSumma(Kujund[] kujundid)
		{
			double summa = 0;
			foreach (var kujund in kujundid)
			{
				summa += kujund.AnnaKogupindala();
			}
			return summa;
		}

		private static decimal ArvutaRuumaladeSumma(Kujund[] kujundid)
		{
			decimal summa = 0;
			foreach (var kujund in kujundid)
			{
				summa += (decimal)kujund.AnnaRuumala();
			}
			return summa;
		}
	}
}
