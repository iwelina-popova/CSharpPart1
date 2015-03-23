/* Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	            sum
1 2 3 4 5	        15
10 10 10 10 10	    50
1.5 3.14 8.2 -1 0	11.84   */

using System;

    class Sum5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 5 numbers (separated by a space):");
            string numbers = Console.ReadLine();            
            string[] fiveNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }

