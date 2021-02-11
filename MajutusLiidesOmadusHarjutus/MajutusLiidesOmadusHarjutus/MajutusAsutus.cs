using System;
using System.Collections.Generic;
using System.Text;

namespace MajutusLiidesOmadusHarjutus
{
	class MajutusAsutus
	{
		protected decimal _hind;
		protected int _kohti;
		protected int _kylalisi;
		public MajutusAsutus(decimal hind,int kohti)
		{
			_hind = hind;
			_kohti = kohti;
			_kylalisi = 0;
		}
		public virtual int VabuKohti { 
			get
			{
				return _kohti - _kylalisi;
			} 
			set
			{
				if (value < 0 || _kohti < value)		// vabukohti võimalik 0 kuni kohti
				{
					return;
				}
				_kylalisi = _kohti - value;
			}
		}
		public virtual int ArvutaMaksumus(int külalisi)
		{
			//1.Kui külalisi on rohkem kui vabu kohti annab veateate
			if (külalisi>VabuKohti)
			{
				throw new ArgumentOutOfRangeException(nameof(külalisi),külalisi, $"Külalisi ei tohi olla rohkem kui vabu kohti: {VabuKohti}");
			}
			//2.Kui külalisi on negatiivne arv annab veateate
			if (külalisi<0)
			{
				throw new ArgumentOutOfRangeException(nameof(külalisi),külalisi, "Külalisi ei tohi olla negatiivne arv");
			}
			//3.Vähendab vabu kohti külaliste arvu võrra(kui eelmised kaks ei andnud viga)
			VabuKohti -= külalisi;
			//4.Tagastab mitu tuba hõivatakse(praegu alati 1)
			return 1;
		}
	}
}
