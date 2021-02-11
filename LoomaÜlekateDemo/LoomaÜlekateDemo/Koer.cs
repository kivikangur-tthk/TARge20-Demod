using System;
using System.Collections.Generic;
using System.Text;

namespace LoomaÜlekateDemo
{
	class Koer:Loom
	{
		protected string _omanik;
		public Koer(string nimi, int vanus, bool onIsane,string omanik):base(nimi,vanus,onIsane)
		{
			_omanik = omanik;
		}
		public override void Häälitse()
		{
			Console.WriteLine("Auh");
		}
	}
}
