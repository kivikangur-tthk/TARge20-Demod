using System;
using System.Collections.Generic;
using System.Text;

namespace LiidesedHarjutus
{
	class Riidelapp
	{
		private int _pikkus;
		private int _laius;
		private string _toon;
		private int _pikkusMuudetud;
		private int _pikkusLoetud;

		public int Laius {
			get {
				return _laius;
			}
			set {
				if (value<=0)
				{
					return;
				}
				_laius = value;
			}
		}
		public int Pikkus
		{
			get
			{
				_pikkusLoetud++;
				return _pikkus;
			}
			set
			{
				if (value <= 0)
				{
					return;
				}
				_pikkusMuudetud++;
				_pikkus = value;
			}
		}
		public string Toon { 
		get
			{
				//if (_toon==null)
				//{
				//	return "Teadmata";
				//}
				//else
				//{
				//	return _toon;
				//}
				return _toon ?? "Teadmata";
			}
			set
			{
				_toon = value;
			}
		}
		public void KuvaAndmed()
		{
			Console.WriteLine("Riidelapp:");
			Console.WriteLine($"\tpikkus: {Pikkus} - muudetud {_pikkusMuudetud} korda, loetud {_pikkusLoetud} korda.");
			Console.WriteLine($"\tlaius: {Laius}");
			Console.WriteLine($"\ttoon: {Toon}");
		}
	}
}
