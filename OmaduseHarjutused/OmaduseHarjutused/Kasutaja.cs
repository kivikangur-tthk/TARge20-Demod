using System;
using System.Collections.Generic;
using System.Text;

namespace OmaduseHarjutused
{
	/// <summary>
	/// Kasutajanimi määratakse konstruktoris, ning seda on hiljem võimalik ainult omadusena küsida, mitte muuta(set - osa puudub).Parooli saab ainult määrata, aga küsida pole võimalik(get-osa puudub). Lisa käsklus parooli kontrolliks. Lisa omadusena kasutaja telefoninumber, mida on võimalik küsida ja muuta.Kontrolli, et töötaksid vaid määratud tehted(st.et kord pandud parooli ei saaks küsida).
	/// </summary>
	class Kasutaja
	{
		private string _kasutajanimi;
		private string _parool;
		private string _telefoninumber;

		public Kasutaja(string kasutajanimi, string parool)
		{
			_kasutajanimi = kasutajanimi;
			_parool = parool;
		}
		public string Kasutajanimi { get { return _kasutajanimi; } }
		public string Parool { set { _parool = value; } }
		public bool OnÕige(string parool) { return parool == _parool; }

		public string Telefoninumber
		{
			get => _telefoninumber;
			set => _telefoninumber = value;
		}

		public void MuudaParool(string kehtivParool)
		{
			if (!OnÕige(kehtivParool))
			{
				return;
			}
			Console.Write("Sisesta uus parool: ");
			string uusParool = Console.ReadLine();
			Console.Write("Sisesta parool uuesti: ");
			if (uusParool == Console.ReadLine())
			{
				Parool = uusParool;
				Console.WriteLine("Parool on muudetud");
			}
			else
			{
				Console.WriteLine("Parooli ei muudetud! Uuesti siestatud parool on erinev eelmisest sisestusest.");
			}
		}
	}
}
