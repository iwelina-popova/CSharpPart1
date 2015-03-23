/* Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
Examples:

n	randomized numbers 1…n
3	2 1 3
10	3 4 8 2 6 7 9 1 10 5
 
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
You might need to use arrays.
 */

using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("Program that enters in integer n and prints the numbers 1, 2, …, n in random order.\n");
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[] arrayNumbers = new int[n];


        for (int i = 0; i < n; i++)
        {
            int number = rnd.Next(1, n + 1);
            if (i == 0)
            {
                arrayNumbers[i] = number;
            }
            else
            {
                for (int j = 0; j < i; j++)
                {
                    if (arrayNumbers[j] == number)
                    {
                        number = rnd.Next(1, n + 1);
                        j = -1;
                    }
                    else
                    {
                        arrayNumbers[i] = number;

                    }
                }
            }
        }
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.WriteLine(arrayNumbers[i]);
        }
        Console.WriteLine();


        Console.ReadLine();
    }
}

