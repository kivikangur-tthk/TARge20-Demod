using System;
using System.Collections.Generic;
using System.Text;

namespace KlassimuutujaDemo
{
	class Koer
	{
		private string _nimi;
		private string _toug;
		private bool _onIsane;
		private float _kaal;
		private static int _kokku = 0;
		private static int _isaseid = 0;
		private static float _koguKaal = 0;

		public Koer(string nimi, string toug, bool onIsane, float kaal)
		{
			_nimi = nimi;
			_toug = toug;
			_onIsane = onIsane;
			_kaal = kaal;
			_kokku++;
			_isaseid += onIsane ? 1 : 0;
			_koguKaal += kaal;
			//if (onIsane)	_isaseid++;
		}

		public void KuvaAndmed()
		{
			Console.WriteLine($"Nimi: {_nimi}; Tõug: {_toug}; Sugu: {(_onIsane?"isane":"emane")}; Kaal: {_kaal}.");
		}
		public static void KuvaStatistika()
		{
			Console.WriteLine($"Koeri: {_kokku}; Isaseid: {_isaseid}; Emaseid: {_kokku-_isaseid}; Kogu kaal: {_koguKaal}");
		}
	}
}
