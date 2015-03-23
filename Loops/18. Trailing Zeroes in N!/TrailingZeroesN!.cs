/* Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
Examples:

n	    trailing zeroes of n!	explaination
10	    2	                    3628800
20	    4	                    2432902008176640000
100000	24999	                think why
 */ 

using System;
using System.Numerics;

class TrailingZeroesN
{
    static void Main()
    {
        Console.WriteLine("Program that calculates with how many zeroes the factorial of a given number n has at its end.\n");
        Console.Write("Please enter a number: ");
        long number = long.Parse(Console.ReadLine());
        long zeroesCounter = 0;
        long k = 1;
        long result;

        while (Math.Pow(5, k) < number)
        {
            result = (long)Math.Pow((long)5, k);
            zeroesCounter += number / result;
            ++k;
        }
        
        Console.WriteLine("Trailing zeroes of n! -> {0}", zeroesCounter);

        Console.ReadLine();
    }
}

