using System;
namespace PunktiDemo
{
	struct Punkt
	{
		public int x;
		public int y;
		public string nimi;
	}
	class Program
	{
		public static void Main(string[] arg)
		{
			Punkt[] pd = new Punkt[10]; //mälu kohe olemas
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"{pd[i].nimi} {pd[i].x} {pd[i].y}");
			}
			Console.WriteLine(pd[4].y);
		}
	}
}