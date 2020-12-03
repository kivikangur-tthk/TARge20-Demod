using System;

namespace MassiivMitmeDimensiooniline
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] m = new int[] { 1 }; // Ühe mõõtmeline
			int[,] m2 = new int[,] { { 1 }, { 2 } }; // kahe mõõtmeline
			int[,,] m3 = new int[1, 2, 3]
				{
					{
						{1,2,3},
						{4,5,6}
					}
				}; // kolme mõõtmeline
			int[][] mm = new int[][] { new int[] { 1 } }; // massiivide massiiv
			Console.WriteLine($"Ühemõõtmelise pikkus: {m.Length}");
			Console.WriteLine($"Kahemõõtmelise pikkus: {m2.Length}");
			Console.WriteLine($"Kolmemõõtmelise pikkus: {m3.Length}");
			Console.WriteLine($"Massivide Massiivi pikkus: {mm.Length}");

			Console.WriteLine($"Mõõdete arv:\nm.Rank: {m.Rank}\nm2.Rank: {m2.Rank}\nm3.Rank: {m3.Rank}");

			for (int i = 0; i < m3.Rank; i++)
			{
				Console.WriteLine($" m3 {i+1}. dimensiooni pikkus: {m3.GetLength(i)}");
			}

		}
	}
}
