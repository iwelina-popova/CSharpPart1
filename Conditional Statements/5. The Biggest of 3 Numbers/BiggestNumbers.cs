/* Write a program that finds the biggest of three numbers.
Examples:

a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1
 */ 

using System;

class BiggestNumbers
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

        //double firstNumber = -1;
        //double secondNumber = -1.5;
        //double thirdNumber = -0.1;

        double theBiggest = firstNumber;

        if (secondNumber > theBiggest)
        {
            theBiggest = secondNumber;
        }
        if(thirdNumber > theBiggest)
        {
            theBiggest = thirdNumber;
        }
        Console.WriteLine("The biggest number is: {0}", theBiggest);   

        Console.ReadLine();
    }
}

