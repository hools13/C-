using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym; 

		public Point()
		{
			Console.WriteLine("Создается новая точка");
		}

		public Point(int_x, int_y, char_sym)
		{
			x = _x;
			y = _y;
			sym = _sym;
		}

		public void Draw()
		{
			Console.SetCursorPosition( x, y );
			Console.Write( sym );
		}
	}
}