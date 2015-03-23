﻿/* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
 Use two nested loops.
Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
 */ 

using System;

class MatrixNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer n (1 ≤ n ≤ 20) and the program print a matrix.\n");
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        for (int i = 1; i <= n; i++)
        {
            int variable = i;
            for (int j = 0; j < n; j++)
            {                
                Console.Write("{0} ", variable);
                ++variable;
            }
            Console.WriteLine("");
        }

        Console.ReadLine();
    }
}

