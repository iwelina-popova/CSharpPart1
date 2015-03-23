/* Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a	   b	   c	  result
5	   1	   2	  5 2 1
-2	   -2	   1	  1 -2 -2
-2	   4	   3	  4 3 -2
0	   -2.5	   5	  5 0 -2.5
-1.1   -0.5	   -0.1	  -0.1 -0.5 -1.1
10	   20	   30	  30 20 10
1	   1	   1	  1 1 1
 */ 

using System;

class SortNumbersNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers and the program will show you the biggest.\n");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        //double firstNumber = 5;
        //double secondNumber = 2;
        //double thirdNumber = 1;

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}",  secondNumber, thirdNumber, firstNumber);
            }
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("The numbers sorted in descending order: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
        Console.ReadLine();
    }
}

