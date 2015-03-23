/* Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	4	14	12
2.5	3	11	7.5
5	5	20  25 */

using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a rectangle's sides.\nThe width is: "); 
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("The height is: ");
            int height = int.Parse(Console.ReadLine());
            int perimeter = 2 * (width + height);
            int area = width * height;
            Console.WriteLine("The rectangle's perimeter is {0} and the area is {1}.", perimeter, area);
            Console.Read();
        }
    }

