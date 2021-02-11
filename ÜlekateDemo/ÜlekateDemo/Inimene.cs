using System;
using System.Collections.Generic;
using System.Text;

namespace ÜlekateDemo
{
	class Inimene
	{
		protected int _vanus;
		public Inimene(int vanus) { _vanus = vanus; }
		public virtual void YtleVanus() { Console.WriteLine($"Ma olen {_vanus} aastat vana."); }
	}
}
