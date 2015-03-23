/* Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
 * that the reminder of the division by 5 is 0.
Examples:

start	end	   p	comments
17	    25	   2	20, 25
5	    30	   6	5, 10, 15, 20, 25, 30
3	    33	   6	5, 10, 15, 20, 25, 30
3	    4	   0	-
99	    120	   5	100, 105, 110, 115, 120
107	    196	   18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
 * 
 */

using System;

    class NumbersDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two positive integer numbers.");
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                }                
            }
            if (counter > 0)
            {
                Console.WriteLine("\nThe count of the numbers is: " + counter);               
            }
            else
            {
                Console.WriteLine("\nThe count of the numbers is: none");
            }
            Console.ReadLine();
        }
    }

