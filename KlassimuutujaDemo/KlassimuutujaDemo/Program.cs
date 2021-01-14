using System;

namespace KlassimuutujaDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Koer muri = new Koer("Muri", "Krants", true, 5.5f);
			muri.KuvaAndmed();
			Koer bella = new Koer("Bella", "Puudel", false, 2.1f);
			bella.KuvaAndmed();
			Koer.KuvaStatistika();
		}
	}
}
