using System;
using System.Collections.Generic;
using System.Text;

namespace PärilusDemo
{
	class Elamu
	{
		protected int _tubadeArv;
		protected string _aadress;
		protected int _korruseid;
		protected bool _saunOn;
		public Elamu(int tube, string aadress, int korruseid) : this(tube, aadress, korruseid, false) { }
		public Elamu(int tube,string aadress, int korruseid,bool saunOn)
		{
			_saunOn = saunOn;
			_tubadeArv = tube;
			_aadress = aadress;
			_korruseid = korruseid;
		}
		public void KuvaAndmed()
		{
			Console.WriteLine($"Tube: {_tubadeArv};" +
				$" Korruseid: {_korruseid};" +
				$" Saun: {(_saunOn?"jah":"ei")}" +
				$" Aadress: {_aadress}");
		}
		public int AnnaTubadeArv() { return _tubadeArv; }
	}
}
