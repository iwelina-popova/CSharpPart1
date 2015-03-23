/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.

Examples:

n	sum of digits	reversed	last digit in front	second and third digits exchanged
2011	4	1102	1201	2101
3333	12	3333	3333	3333
9876	30	6789	6987	9786 */

using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four-digit number: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 1000 || number > 9999)
            {
                Console.WriteLine("Your number is not with four digits or starts with zero!");
                Console.WriteLine("Please enter four-digit number: ");
                number = int.Parse(Console.ReadLine());
            }

            int a = (number / 1000) % 10;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sum = a + b + c + d;

            Console.WriteLine("The sum of the digits is: " + sum);
            Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}", d, b, c, a);
            Console.WriteLine("The second and the third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
            Console.Read();
        }
    }

