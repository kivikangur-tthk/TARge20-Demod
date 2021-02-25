using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktneKlassDemo
{
	class Vorstijupp : Kujund
	{
		private double _raadius;
		private double _pikkus;
		public Vorstijupp(double raadius,double pikkus)
		{
			_raadius = raadius;
			_pikkus = pikkus;
		}
		public override double AnnaKõrgus()
		{
			return _pikkus;
		}

		public override double AnnaPõhjaPindala()
		{
			return Math.PI * _raadius * _raadius;
		}

		public override double AnnaPõhjaÜmbermõõt()
		{
			return 2 * Math.PI * _raadius;
		}
		public override bool Equals(object obj)
		{
			if (!(obj is Vorstijupp))
			{
				return false;
			}
			double täpsus = 0.00001;
			Vorstijupp other = (Vorstijupp)obj;
			return Math.Abs(other._pikkus - _pikkus) < täpsus && other._raadius == _raadius;
		}
		public override int GetHashCode()
		{
			//throw new Exception("No hashcode for this object possible");
			return $"{_raadius} {_pikkus}".GetHashCode();
		}
	}
}
