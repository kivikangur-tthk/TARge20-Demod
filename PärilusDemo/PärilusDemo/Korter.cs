using System;
using System.Collections.Generic;
using System.Text;

namespace PärilusDemo
{
	class Korter : Elamu
	{
		private int _korteriNr;
		public Korter(int tube, string aadress,int korteriNr,bool saunOn=false) : base(tube, aadress, 1,saunOn)
		{
			_korteriNr = korteriNr;
		}
		public void KuvaAadress()
		{
			Console.WriteLine($"{ _aadress} Korter number {_korteriNr}");
		}
	}
}
