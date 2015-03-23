/* Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	    b	 c	  roots
2	    5    -3	  x1=-3; x2=0.5
-1	    3	 0	  x1=3; x2=0
-0.5    4	 -8	  x1=x2=4
5	    2	 8	  no real roots  */

using System;

    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation ax2 + bx + c = 0");
            Console.Write("Please enter values to the coefficients:\na = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else
            {
                if (discriminant > 0)
                {
                    Console.WriteLine("The roots are:\nx1 = {0}\nx2 = {1}", root1, root2);
                }
                else
                {
                    Console.WriteLine("There is one real root:\nx1 = x2 = {0}", root1);
                }
            }
            Console.ReadLine();
        }
    }

