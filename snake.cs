	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace Snake
	{
		class Program
	{
		static void Main( string[] args )
        {
        	Console.SetBufferSize( 80, 25 );



			/* 
			Point p1 = new Point(1, 3, '*');
			p1.Draw();
			Point p2 = new Point(4, 5, '#');
			p2.Draw();  
			*/

			//отрисовка рамки

			HorizontalLine upLine = new HorizontalLine( 0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine( 0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+');
			VerticalLine rightLine = new VerticalLine( 0, 24, 78, '+');
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();


			// отрисовка точек
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			snake.Move();
		}
	}
}