/* Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
Examples:

n	min	max	random numbers
5	0	1	1 0 0 1 1
10	10	15	12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
 */ 

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].\n");
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max = ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int number = rnd.Next(min, max + 1);
            Console.Write("{0} ", number);
        }
        
        Console.ReadLine();
    }
}

