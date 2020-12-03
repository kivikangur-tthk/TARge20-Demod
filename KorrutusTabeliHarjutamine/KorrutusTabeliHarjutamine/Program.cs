using System;

namespace KorrutusTabeliHarjutamine
{
	class Program
	{
		/* Koosta kahemõõtmeline massiiv ning täida korrutustabeli väärtustega.
						Küsi massiivist kontrollimiseks väärtusi.
		*/
		static void Main(string[] args)
		{
			int ridu = KysiArv("Mitme realist korrutustabelit soovid? ");
			int veerge = KysiArv("Mitu veergu selles tabeli peab olema? ");
			int[,] korrutusTabel = LooKorrutusTabel(ridu, veerge);
			//KuvaMassiiv(korrutusTabel);
			int arv1 = KysiArvVahemikus($"Sisesta korrutuse esimene tegur vahemikus 1-{ridu}: ", 1, ridu);
			int arv2 = KysiArvVahemikus($"Sisesta korrutuse teine tegur vahemikus 1-{veerge}: ", 1, veerge);
			Console.WriteLine("Korrutustabelis on antud kohal: "+
					korrutusTabel[arv1-1,arv2-1]);

		}



		private static int KysiArv(string küsimus)
		{
			Console.WriteLine(küsimus);
			if (int.TryParse(Console.ReadLine(),out int tulem))
			{
				return tulem;
			}
			return KysiArv(küsimus+"\nSisesta täisarv!");
		}

		private static void KuvaMassiiv(int[,] korrutusTabel)
		{
			for (int rida = 0; rida < korrutusTabel.GetLength(0); rida++)
			{
				for (int veerg = 0; veerg < korrutusTabel.GetLength(1); veerg++)
				{
					Console.Write($"{korrutusTabel[rida,veerg],5}");
				}
				Console.WriteLine();
			}
		}

		private static int[,] LooKorrutusTabel(int ridadeKogus, int veergudeKogus)
		{
			int[,] tulem = new int[ridadeKogus,veergudeKogus];
			for (int rida = 0; rida < ridadeKogus; rida++)
			{
				for (int veerg = 0; veerg < veergudeKogus; veerg++)
				{
					tulem[rida, veerg] = (rida + 1) * (veerg + 1);
				}
			}
			return tulem;
		}
		private static int KysiArvVahemikus(string küsimus, int miinimum, int maksimum)
		{
			int tulem;
			do
			{
				tulem = KysiArv(küsimus);
			} while (tulem<miinimum || tulem>maksimum);
			return tulem;
		}
	}
}
