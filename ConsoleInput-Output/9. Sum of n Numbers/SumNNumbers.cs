﻿/* Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
 Note: You may need to use a for-loop.
Examples:

numbers	  sum
3	      90
20	      
60	      
10	
 * 
5	      6.5
2	      
-1	      
-0.5	  
4	      
2
 * 
1	      1
1	      
 * */     

using System;

    class SumNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that enters a number n and after that enters more n numbers and calculates and prints their sum.\n");
            Console.Write("Enter your number n = ");
            int n = int.Parse(Console.ReadLine());
            double number;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter your number: ");
                number = double.Parse(Console.ReadLine());
                sum += number; 
            }
            Console.WriteLine("The sum is: " + sum);

            Console.ReadLine();
        }
    }

