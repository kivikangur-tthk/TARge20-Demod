using System;

namespace LoomaÜlekateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Loom l1 = new Loom("Vissi", 5, false);
			l1.Häälitse();
			Koer koer = new Koer("Muri", 3, true, "Kristjan");
			koer.Häälitse();
			Kass kass = new Kass("Artur", 7, true, "Kristjan");
			kass.Häälitse();
		}
	}
}
