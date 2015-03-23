/* In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: formula ..... For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960
*/
using System;
using System.Numerics;

class Equation
{
    static void Main()
    {
        Console.WriteLine("Program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).\n");
        Console.Write("Enter n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger divisor1 = 1;
        BigInteger divisor2 = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;

            if (i <= k)
            {
                divisor1 *= i;
            }
            if (i <= (n - k))
            {
                divisor2 *= i;
            }
        }
        BigInteger divisor12 = divisor1 * divisor2;
        Console.WriteLine("{0}! / ({1}! * ({0}-{1})!) = {2}", n, k, numerator/divisor12);

        Console.ReadLine();
    }
}

