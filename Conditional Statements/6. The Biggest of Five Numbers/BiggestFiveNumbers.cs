/* Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	   b	   c	   d	 e	    biggest
5	   2	   2	   4	 1	    5
-2	   -22	   1	   0	 0	    1
-2	   4	   3	   2	 0	    4
0	   -2.5	   0	   5	 5	    5
-3	   -0.5	   -1.1	   -2	 -0.1	-0.1
 */

using System;

class BiggestFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five real numbers and the program will show you the biggest.\n");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        //double firstNumber = -2;
        //double secondNumber = -22;
        //double thirdNumber = 1;
        //double fourthNumber = 0;
        //double fifthNumber = 0;

        double theBiggest = firstNumber;

        if (secondNumber > theBiggest)
        {
            secondNumber = theBiggest;
        }
        if (thirdNumber > theBiggest)
        {
            theBiggest = thirdNumber;
        }
        if (fourthNumber > theBiggest)
        {
            theBiggest = fourthNumber;
        }
        if (fifthNumber > theBiggest)
        {
            theBiggest = fifthNumber;
        }
        Console.WriteLine("The biggest number is: {0}", theBiggest);

        Console.ReadLine();
    }
}

