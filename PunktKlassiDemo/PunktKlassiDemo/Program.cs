using System;

namespace PunktKlassiDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Punkt p1 = new Punkt(1,2);
			Console.WriteLine($"p1 kaugus nullist on {p1.KaugusNullist()}.");
			Punkt p2 = new Punkt(3, 4);
			Console.WriteLine($"p2 x:{p2.GetX()} y:{p2.GetY()} kaugus nullist on {p2.KaugusNullist()}.");
			p2.SetX(5);
			Console.WriteLine($"p2 x:{p2.GetX()} y:{p2.GetY()} kaugus nullist on {p2.KaugusNullist()}.");
			Punkt p3 = p2; // kasutatakse samu mälu kohti - object on viitetüüpi
			p3.SetY(6);
			Console.WriteLine($"p2 x:{p2.GetX()} y:{p2.GetY()} kaugus nullist on {p2.KaugusNullist()}.");
			Console.WriteLine($"p3 x:{p3.GetX()} y:{p3.GetY()} kaugus nullist on {p3.KaugusNullist()}.");
		}
	}
}
