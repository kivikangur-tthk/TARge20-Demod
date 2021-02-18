using System;
using System.Collections.Generic;
using System.Text;

namespace KT_Harjutus_Buss_Marsa
{
	class Buss
	{
		protected string _värv;
		protected int _kohtadeArv;
		protected string _mudel;
		protected int _aasta;
		protected int _reisijaid;
		private static int _kohtadeKoguarv = 0;
		public Buss(string värv, int kohtadeArv,string mudel,int aasta)
		{
			if (kohtadeArv<0)
			{
				throw new ArgumentOutOfRangeException(nameof(kohtadeArv), "Bussis ei saa olla vähem kui 0 kohta. Antud väärtus on: " + kohtadeArv);
			}
			_värv = värv;
			_kohtadeArv = kohtadeArv;
			_mudel = mudel;
			_aasta = aasta;
			_reisijaid = 0;
			_kohtadeKoguarv += kohtadeArv;
		}
		public virtual void KuvaAndmed()
		{
			Console.WriteLine($"Mudel: {_mudel}\nVärv: {_värv}\nKohti/Reisijaid: {_kohtadeArv}/{_reisijaid}\nAasta: {_aasta}");
			KuvaVanusAastal2030();
			Console.WriteLine($"Bussipargis on istekohti {_kohtadeKoguarv}");
		}
		public void KuvaVanusAastal2030()
		{
			Console.WriteLine($"Bussi vanus aastal 2030: {2030-_aasta}");
		}
		public string Pikkus
		{
			get
			{
				if (_kohtadeArv < 9)
				{
					return "mikrobuss";
				}
				if (_kohtadeArv < 50)
				{
					return "liini buss";
				}
				return "lõõtsaga buss";
			}
		}
		public virtual void LaeReisijaid(int kogus)
		{
			if (kogus > _kohtadeArv-_reisijaid || kogus+_reisijaid < 0)
			{
				return;
			}
			_reisijaid += kogus;
		}
	}
}
