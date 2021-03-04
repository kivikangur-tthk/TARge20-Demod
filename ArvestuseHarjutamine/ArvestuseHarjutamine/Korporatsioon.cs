using System;
using System.Collections.Generic;
using System.Text;

namespace ArvestuseHarjutamine
{
	class Korporatsioon : Ettevõte,IRahvusvaheline
	{
		protected string _tegutsemiseRiik;
		protected int _juhatuseSuurus;

		public Korporatsioon(int osakondi, int töötajaid, string nimi, string tegevusala,string tegutsemiseRiik, int juhatuseSuurus):base(osakondi,töötajaid,nimi,tegevusala)
		{
			_tegutsemiseRiik = tegutsemiseRiik;
			_juhatuseSuurus = juhatuseSuurus;
		}
		public override void LisaTöötaja()
		{
			// iga 100 töötaja jaoks peab olema üks juhatuse liige.
			if (_töötajaid/100.0>=_juhatuseSuurus)
			{
				_juhatuseSuurus++;
			}
			base.LisaTöötaja();
		}

		public void TeataNimi(string keel)
		{
			Console.WriteLine($"{keel}-keeles on ettevõtte nimi {_nimi}");
		}

		public override string ToString()
		{
			return base.ToString()+$"\n\triik: {_tegutsemiseRiik}\n\tjuhatuse suurus: {_juhatuseSuurus}";
		}
	}
}
