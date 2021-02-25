using System;
using System.Collections.Generic;
using System.Text;

namespace AbstraktneKlassDemo
{
	abstract class Kujund
	{
		public abstract double AnnaPõhjaPindala();
		public abstract double AnnaKõrgus();
		public abstract double AnnaPõhjaÜmbermõõt();

		public double AnnaKüljePindala()
		{
			return AnnaPõhjaÜmbermõõt() * AnnaKõrgus();
		}
		public double AnnaRuumala() { return AnnaKõrgus() * AnnaPõhjaPindala(); }
		public override string ToString()
		{
			return base.ToString() +
										$"\nKõrgus: {AnnaKõrgus()}\n" +
										$"Põhja pindala: {AnnaPõhjaPindala()}\n" +
										$"Põhja ümbermõõt: {AnnaPõhjaÜmbermõõt()}\n" +
										$"Külje pindala: {AnnaKüljePindala()}\n" +
										$"Ruumala: {AnnaRuumala()}";
		}
	}
}
