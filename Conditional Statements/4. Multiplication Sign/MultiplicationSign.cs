/* Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	   b	   c	  result
5	   2	   2	  +
-2	   -2	   1	  +
-2	   4	   3	  -
0	   -2.5	   4	  0
-1	   -0.5	   -5.1	  -

 */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three real numbers and the program will show you the sign (+, - or 0) of the product.\n");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        //double firstNumber = -1;
        //double secondNumber = -0.5;
        //double thirdNumber = -5.1;
        int counter = 0;
        char sign;

        if (firstNumber < 0)
        {
            counter++;
        }
        if (secondNumber < 0)
        {
            counter++;
        }
        if (thirdNumber < 0)
        {
            counter++;
        }
        if (counter % 2 != 0) 
        {
            sign = '-';           
        }
        else
        {
            sign = '+';
        }
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            sign = '0';            
        }
        Console.WriteLine("The sign of the product of the numbers is \"{0}\"", sign);

        Console.Read();
    }
}

