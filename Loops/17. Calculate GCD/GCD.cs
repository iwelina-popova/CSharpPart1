/* Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
Examples:

a	b	 GCD(a, b)
3	2	 1
60	40	 20
5	-15	 5
 */

using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Program that calculates the greatest common divisor (GCD) of given two integers a and b.\n");
        Console.Write("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        firstNumber = Math.Abs(firstNumber);
        secondNumber = Math.Abs(secondNumber);

        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }
            if (firstNumber == 0)
            {
                Console.WriteLine("The greatest common divisor (GCD) is: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The greatest common divisor (GCD) is: {0}", firstNumber);
            }     


        Console.ReadLine();
    }
}

