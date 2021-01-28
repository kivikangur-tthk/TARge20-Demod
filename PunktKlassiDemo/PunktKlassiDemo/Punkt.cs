using System;
using System.Collections.Generic;
using System.Text;

namespace PunktKlassiDemo
{
	// 1. Klassi loomine
	class Punkt
	{
		// 2. Väljade loomine
		private int _x;
		private int _y;
		// 3. Konstruktori loomine
		public Punkt(int x,int y)
		{
			// 4. Väljade väärtustamine
			_x = x;
			_y = y;
		}
		// 5. Teeme midagi kasulikku
		public double KaugusNullist()
		{
			return Math.Sqrt(_x * _x + _y * _y);
		}

		public int GetX() { return _x; }

		public void SetX(int value) { _x = value; }
		public int GetY() { return _y; }

		public void SetY(int value) { _y = value; }
	}
}
