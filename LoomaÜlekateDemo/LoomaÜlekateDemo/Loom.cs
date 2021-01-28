using System;

namespace LoomaÜlekateDemo
{
	public class Loom
	{
		protected string _nimi;
		protected int _vanus;
		protected bool _onIsane;

		public Loom(string nimi, int vanus, bool onIsane)
		{
			_nimi = nimi;
			_vanus = vanus;
			_onIsane = onIsane;
		}

		public virtual void Häälitse()
		{
			Console.WriteLine("GRRRR");
		}
	}
}