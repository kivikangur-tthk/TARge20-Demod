using System;
using System.Collections.Generic;
using System.Text;

namespace MajutusLiidesOmadusHarjutus
{
	class Hotell : MajutusAsutus
	{
		private int _tubadeArv;
		private int _kohtiToas;
		private int _vabuTube;
		public Hotell(decimal hind,int tubadeArv,int kohtiToas):base(hind,tubadeArv*kohtiToas)
		{
			_tubadeArv = tubadeArv;
			_vabuTube = _tubadeArv;
			_kohtiToas = kohtiToas;
		}
		public int VabuTube { 
			get {
				return _vabuTube;
			} 
			set {
				if (value > _tubadeArv|| 0 > value)
				{
					return;
				}
				_vabuTube = value;
			}
		}
		public override int VabuKohti
		{
			get
			{
				return _vabuTube * _kohtiToas;
			}
			set
			{
				if (value < 0 || _tubadeArv*_kohtiToas < value)		// lubatud vahemik 0 kuni tubadeArv*kohtiToas
				{
					return;
				}
				_vabuTube = value / _kohtiToas;
			}
		}
		public override int ArvutaMaksumus(int külalisi)
		{
			int result = _vabuTube;
			base.ArvutaMaksumus(külalisi);
			return result - _vabuTube;
		}
	}
}
