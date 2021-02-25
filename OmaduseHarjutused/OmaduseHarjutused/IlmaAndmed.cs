using System;
using System.Collections.Generic;
using System.Text;

namespace OmaduseHarjutused
{
	class IlmaAndmed
	{
		private int _temper;
		private int _muudetud = 0;
		private int _loetud = 0;
		public int Temperatuur
		{
			get
			{
				_loetud++;
				return _temper;
			}
			set
			{
				if (value>35)
				{
					Console.WriteLine("Kahtlane temperatuur");
				}
				_muudetud++;
				_temper = value;
			}
		}
		public override string ToString()
		{
			return "Muudetud: " + _muudetud + ", loetud:" + _loetud +
			       ", temperatuur:" + _temper;
		}
	}

}
