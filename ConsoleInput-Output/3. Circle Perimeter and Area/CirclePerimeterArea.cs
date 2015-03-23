/* Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:
                   
r	   perimeter  area
2	   12.57	  12.57
3.5	   21.99	  38.48  */
                   
using System;

    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle - perimeter and area.");
            Console.Write("Please enter a radius r = ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("The perimeter of a circle is {0:f2} and the area is {1:f2}", perimeter, area);

            Console.ReadLine();
        }
    }

