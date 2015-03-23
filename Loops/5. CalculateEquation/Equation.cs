/* Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781
 */

using System;

class Equation
{
    static void Main()
    {
        Console.WriteLine("Please enter two integer numbers n and x and the program will calculate the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.\n");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        int numerator = 1;
        int divisor = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= i;
            divisor *= x;
            sum += (double)numerator / divisor;
        }
        Console.WriteLine("Sum is : {0:0.00000}", sum);
        Console.ReadLine();
    }
}

