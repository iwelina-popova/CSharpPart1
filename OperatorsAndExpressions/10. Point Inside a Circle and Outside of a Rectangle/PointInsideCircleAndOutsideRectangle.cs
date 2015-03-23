/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
 * and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x	     y	    inside K & outside of R
1	     2	    yes
2.5	     2	    no
0	     1	    no
2.5	     1	    no
2	     0	    no
4	     0	    no
2.5	     1.5	no
2	     1.5	yes
1	     2.5	yes
-100	-100	no     */

using System;

    class PointInsideCircleAndOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if two points are inside a circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
            Console.Write("Please enter two points:\nx = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            double radius = 1.5;
            bool equationOfTheCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5);
            bool outTheRectangle = ((-1 <= x) || (x <= 5)) || ((-1 <= y) || (y <= 1));
            if (equationOfTheCircle && outTheRectangle == true)
            {
                Console.WriteLine("The points are inside a circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
            }
            else
            {
                Console.WriteLine("The points are not inside a circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).");
            }
            Console.Read();
        }
    }

