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

		public Buss(string värv, int kohtadeArv,string mudel,int aasta)
		{
			_värv = värv;
			_kohtadeArv = kohtadeArv;
			_mudel = mudel;
			_aasta = aasta;
			_reisijaid = 0;
		}
		public void KuvaAndmed()
		{
			Console.WriteLine($"Mudel: {_mudel}\nVärv: {_värv}\nKohti/Reisijaid: {_kohtadeArv}/{_reisijaid}\nAasta: {_aasta}");
			
		}
		public void KuvaVanusAastal2030()
		{
			Console.WriteLine($"Bussi vanus aastal 2030: {2030-_aasta}");
		}
		public void LaeReisijaid(int kogus)
		{
			if (kogus > _kohtadeArv-_reisijaid || kogus+_reisijaid < 0)
			{
				return;
			}
			_reisijaid += kogus;
		}
	}
}
