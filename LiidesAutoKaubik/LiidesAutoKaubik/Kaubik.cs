using System;
namespace LiidesAutoKaubik
{
	public class Kaubik : Auto, IKaup
	{
		private int _kaubaruum;
		private int _kaubaKogus;
		public Kaubik(string mark, int kohti, int kaubaruum) : base(mark, kohti)
		{
			_kaubaruum = kaubaruum;
			_kaubaKogus = 0;
		}

		public void LaeEuroAlus()
		{
			if (2 > _kaubaruum-_kaubaKogus)
			{
				Console.WriteLine("Ei mahu");
				return;
			}
			_kaubaKogus += 2;
		}

		public override void YtleMark()
		{
			base.YtleMark();
			Console.WriteLine($"Kaupa mahub {_kaubaruum}\nVaba ruumi on {_kaubaruum-_kaubaKogus}");
		}
	}
}