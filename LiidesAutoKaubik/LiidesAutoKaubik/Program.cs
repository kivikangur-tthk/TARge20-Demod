using System;

namespace LiidesAutoKaubik
{
	/// <summary>
	/// 1. Klassi loomine
	/// 2. Klassimuutuja
	/// 3. Pärilus ja Ülekate
	/// 4. Liidesed
	/// 
	/// Auto -> Kaubik
	/// 1. Auto - väljad: mark, kohti
	///											meetodid: YtleMark(), SiseneAutosse(arv)
	///	2. AutodeArv
	///	3. Kaubik - väli: kaubaruum
	///					YtleMark() - teavitab lisaks kaubaruumi suuruse
	///	4. LaeEuroAlus() - vähendab vaba kaubaruumi 2 kuupmeetrit
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Auto auto = new Auto("Seat", 5);
			Auto auto1 = new Auto("Subaru", 2);
			Kaubik kaubik = new Kaubik("Ford", 3, 2);
			auto.YtleMark();			
			auto1.SiseneAutosse(2);
			auto1.YtleMark();		
			kaubik.YtleMark();
			kaubik.LaeEuroAlus();
			kaubik.LaeEuroAlus();
			kaubik.YtleMark();
		}
	}
}
