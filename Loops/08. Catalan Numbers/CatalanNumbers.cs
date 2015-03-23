/* In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula.....
Write a program to calculate the n-th Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845
 */ 

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Program to calculate the n-th Catalan number by given n (0 ≤ n ≤ 100).\n");
        Console.Write("Enter n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger divisor1 = 1;
        BigInteger divisor2 = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            numerator *= i;
        }
        for (int j = 1; j <= n; j++)
        {
            divisor2 *= j;            
        }

        divisor1 = divisor2 * (n + 1);
        BigInteger divisor12 = divisor1 * divisor2;

        Console.WriteLine("The n-th Catalan number: {0}", numerator/divisor12);
        Console.ReadLine();
    }
}

