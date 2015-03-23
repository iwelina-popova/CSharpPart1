/* Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false */

using System;

    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number {0} is even.", number);
            }
            else
            {
                Console.WriteLine("Your number {0} is odd.", number);
            }
            Console.Read();
        }
    }

