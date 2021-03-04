using System;
using System.Collections.Generic;
using System.Text;

namespace ArvestuseHarjutamine
{
	class Ettevõte
	{
		//•	Osakondade arv
		protected int _osakondi;
		//•	Töötajate arv
		protected int _töötajaid;
		//•	Ettevõtte nimi
		protected string _nimi;
		//•	Tegevusala
		protected string _tegevusala;

		private static int _ettevõteteKogus = 0;
		private static int _itEttevõteteKogus = 0;

		public Ettevõte(int osakondi, int töötajaid, string nimi, string tegevusala)
		{
			_osakondi = osakondi;
			_töötajaid = töötajaid;
			_nimi = nimi;
			_tegevusala = tegevusala;
			_ettevõteteKogus++;
			if (tegevusala == "IT")
			{
				_itEttevõteteKogus++;
			}
		}

		public int TöötajateArv
		{
			get
			{
				if (_töötajaid <0)
				{
					throw new Exception("Töötajaid ei tohi olla negatiivne arv.");
				}
				return _töötajaid;
			}
		}

		public virtual void LisaTöötaja() { _töötajaid++; }

		public override string ToString()
		{
			return $"Kokku ettevõtteid: {_ettevõteteKogus}\n{_nimi} - tegevusala: {_tegevusala}\n\ttöötajaid: {_töötajaid}\n\tosakondi: {_osakondi}";
		}
	}
}
