using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktneKlassDemo
{
	class Risttahukas : Kujund
	{
		private double _pikkus;
		private double _laius;
		private double _kõrgus;

		public Risttahukas(double pikkus, double laius, double kõrgus)
		{
			_pikkus = pikkus;
			_laius = laius;
			_kõrgus = kõrgus;
		}

		public override double AnnaKõrgus()
		{
			return _kõrgus;
		}

		public override double AnnaPõhjaPindala()
		{
			return _pikkus * _laius;
		}

		public override double AnnaPõhjaÜmbermõõt()
		{
			return (_pikkus + _laius) * 2;
		}
	}
}
