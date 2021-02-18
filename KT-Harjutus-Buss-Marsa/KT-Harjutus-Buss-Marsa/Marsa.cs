using System;
using System.Collections.Generic;
using System.Text;

namespace KT_Harjutus_Buss_Marsa
{
	class Marsa:Buss
	{
		protected decimal _piletiMaksumus;
		private decimal _kassa;
		public Marsa(decimal piletiMaksusmus,int kohtadeArv,string värv, string mudel, int aasta) : base(värv, kohtadeArv, mudel, aasta)
		{
			_piletiMaksumus = piletiMaksusmus;
			_kassa = kohtadeArv*piletiMaksusmus/10;
		}
		public decimal Kassa
		{
			get
			{
				return _kassa;
			}
			private set
			{
				_kassa = value;
			}
		}
		public override void LaeReisijaid(int kogus)
		{
			if (kogus == 0) return;
			if (kogus < 0 && _reisijaid > 0)
			{
				_reisijaid--;
			}
			if (kogus > 0 && _reisijaid < _kohtadeArv)
			{
				_reisijaid++;
				Kassa += _piletiMaksumus;
			}
		}
		public override void KuvaAndmed()
		{
			base.KuvaAndmed();
			Console.WriteLine("Marsa kassa: "+Kassa);
		}
	}
}
