using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsikukoodiHarjutus
{
	// 1. loo klass
	class Isikukood
	{
		// 2. loo väljad
		private string _ik;
		// 3. loo konstruktor
		public Isikukood(string isikukood) 
		{
			// 4. täida väljad
			_ik = isikukood;

			if (isikukood.Length != 11)
			{
				throw new ArgumentOutOfRangeException(nameof(isikukood), isikukood, "Isikukood peab olema 11 kohaline.");
			}
			if (!isikukood.All(c => c >= '0' && c <= '9'))
			{
				throw new ArgumentOutOfRangeException(nameof(isikukood), isikukood, "Isikukood peab sisaldama ainult numbreid.");
			}
			if (AnnaSuguArv()<1 || AnnaSuguArv()>6)
			{
				throw new ArgumentOutOfRangeException(nameof(isikukood), isikukood, "Isikukoodis esimene, sugu tähistav, arv peab olema vahemikus 1-6.");
			}
			try
			{
				AnnaSünnikuupäev();
			}
			catch (Exception e)
			{
				throw e;
			}
			if (!KontrollNrÕige())
			{
				throw new ArgumentOutOfRangeException(nameof(isikukood), isikukood, "Isikukoodi kontrollnumber on vale.");
			}
		}

		private bool KontrollNrÕige()
		{
			return ArvutaKontrollNr() == int.Parse(_ik.Substring(10, 1));
		}

		private int ArvutaKontrollNr()
		{
			int[] kordajad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
			int jääk = LeiaJääk(kordajad);
			if (jääk == 10)
			{
				jääk = LeiaJääk(new[] { 3, 4, 5, 6, 7, 8, 9, 1, 2 });
			}
			return jääk;
		}

		private int LeiaJääk(int[] kordajad)
		{
			int summa = 0;
			for (int i = 0; i < kordajad.Length; i++)
			{
				summa += int.Parse(_ik[i].ToString()) * kordajad[i];
			}
			int jääk = summa % 11;
			return jääk;
		}

		// 5. tee midagi kasulikku :)

		private int AnnaSuguArv()
		{
			return int.Parse(_ik.Substring(0, 1));
		}

		public DateTime AnnaSünnikuupäev()
		{
			return new DateTime(AnnaAasta(), AnnaKuu(), AnnaPaev());
		}
		public int AnnaPaev()
		{
			return int.Parse(_ik.Substring(5, 2));
		}

		public int AnnaKuu()
		{
			return int.Parse(_ik.Substring(3, 2));
		}
		public string AnnaKuuNimi()
		{
			string[] kuud = { "", "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "Oktoober", "November", "Destsember" };
			return kuud[AnnaKuu()];
		}

		public int AnnaAasta()
		{
			int aasta = int.Parse(_ik.Substring(1, 2));
			int sajand = int.Parse(_ik.Substring(0, 1));
			switch (sajand)
			{
				case 1:
				case 2:
					{
						aasta += 1800;
						break;
					}
				case 3:
				case 4:
					{
						aasta += 1900;
						break;
					}
				case 5:
				case 6:
					{
						aasta += 2000;
						break;
					}
				case 7:
				case 8:
					{
						aasta += 2100;
						break;
					}
				default:
					break;
			}
			return aasta;
		}



	}
}
