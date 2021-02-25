using System;

namespace AbstraktneKlassDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Kujund kujund = new Tikutops();
			Console.WriteLine(kujund);
			kujund = new Vorstijupp(5, 10);
			Console.WriteLine(kujund);
			Kujund teineJupp = new Vorstijupp(5, 10.00001);
			if (kujund.Equals(teineJupp))
			{
				Console.WriteLine("On võrdsed");
			}
			else
			{
				Console.WriteLine("Erinevad");
			}
		}
	}
}
