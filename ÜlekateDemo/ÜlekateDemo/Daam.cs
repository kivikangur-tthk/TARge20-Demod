using System;
using System.Collections.Generic;
using System.Text;

namespace ÜlekateDemo
{
	class Daam:Inimene
	{
		public Daam(int vanus) : base(vanus) { }
		public override void YtleVanus()
		{ 
			Console.WriteLine($"Minu vanus on {_vanus-5} aastat.");
		}
	}
}
