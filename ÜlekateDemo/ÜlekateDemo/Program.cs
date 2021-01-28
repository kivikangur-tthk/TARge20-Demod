using System;

namespace ÜlekateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Inimene inimene = new Inimene(40);
			Daam daam = new Daam(40);
			inimene.YtleVanus();
			daam.YtleVanus();
			Inimene inimDaam = new Daam(40);
			inimDaam.YtleVanus();
			
		}
	}
}
