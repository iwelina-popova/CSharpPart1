/* Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
Examples:

n	k	n! / k!
5	2	60
6	5	6
8	3	6720
 */

using System;
using System.Numerics;

class Equation
{
    static void Main()
    {
        Console.WriteLine("Program that calculates n! / k! for given n and k (1 < k < n < 100).\n");
        Console.Write("Enter n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger divisor = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;

            if (i <= k)
            {
                divisor *= i;
            }
        }
        Console.WriteLine("n! / k! = {0}", numerator/divisor);
        Console.ReadLine();
    }
}

