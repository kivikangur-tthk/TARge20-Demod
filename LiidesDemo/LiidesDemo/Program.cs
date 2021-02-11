using System;
namespace Liides1
{
 class Inimene
 {
  protected int vanus;
  public Inimene(int uvanus)
  {
   vanus = uvanus;
  }

		public virtual void YtleVanus()
  {
   Console.WriteLine("Minu vanus on " + vanus + " aastat");
  }
 }
 interface IViisakas
 {
  void Tervita(string tuttav);
  void KoputaUksele();
 }
 class Laps : Inimene, IViisakas
 {
  public Laps(int vanus) : base(vanus) { }
  public void Tervita(String tuttav)
  {
   Console.WriteLine("Tere, " + tuttav);
  }
  public void KoputaUksele()
		{
			Console.WriteLine("Kop-KOP");
		}
 }
 class Koer : IViisakas
 {
		public void KoputaUksele()
		{
			Console.WriteLine("AUH-Auh! Kraaps.");
		}

		public void Tervita(String tuttav)
  {
   Console.WriteLine("Auh!");
  }
 }
 class InimTest
 {
  static void TuleSynnipaevale(IViisakas v)
  {
   v.KoputaUksele();
   v.Tervita("vanaema");
  }
  public static void Main(string[] arg)
  {
   Inimene vanem = new Inimene(30);
   Laps juku = new Laps(6);
   juku.YtleVanus();
   Koer muki = new Koer();
   TuleSynnipaevale(juku);
   TuleSynnipaevale(muki);

  }
 }
}
