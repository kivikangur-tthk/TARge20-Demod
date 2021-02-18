using System;

namespace KT_Harjutus_Buss_Marsa
{
	class Program
	{
		static void Main(string[] args)
		{
			Buss väikebuss = new Buss("Kollane", 5, "Ford", 2000);
			väikebuss.KuvaAndmed();
			väikebuss.KuvaVanusAastal2030();
			väikebuss.LaeReisijaid(5);
			väikebuss.KuvaAndmed();
			väikebuss.LaeReisijaid(-5);
			väikebuss.KuvaAndmed();
		}
	}
}
