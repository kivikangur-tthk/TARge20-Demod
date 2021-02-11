using System;
using System.Collections.Generic;
using System.Text;

namespace LiidesAutoKaubik
{
	public class Auto
	{
		protected string _mark;
		protected int _kohti;
		protected int _reisijaid;
		protected int _nr;
		protected static int _kogus = 0;
		public Auto(string mark,int kohti)
		{
			_mark = mark;
			_kohti = kohti;
			_reisijaid = 0;
			_nr = ++_kogus;
		}
		public virtual void YtleMark() 
		{ 
			Console.WriteLine($"{_nr}/{_kogus} Mark on: {_mark}\nAutos on kohti/sõitjaid: {_kohti}/{_reisijaid}");
		}
		public void SiseneAutosse(int arv)
		{
			if (arv>_kohti-_reisijaid)
			{
				Console.WriteLine("Ei mahtunud autosse!");
				return;
			}
			_reisijaid += arv;
		}
	}
}
