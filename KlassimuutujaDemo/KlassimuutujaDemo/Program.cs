using System;

namespace KlassimuutujaDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Koer muri = new Koer("Muri", "Krants", true, 5.5f);
			muri.KuvaAndmed();
			Koer kuri = muri;
			kuri.KuvaAndmed();
			Koer bella = new Koer("Bella", "Puudel", false, 2.1f);
			bella.KuvaAndmed();
			Koer[] kennel = new Koer[10];
			for (int i = 0; i < kennel.Length; i++)
			{
				kennel[i] = new Koer($"Muki{i}", "Krants", true, i);
			}
			Koer.KuvaStatistika();
		}
	}
}
