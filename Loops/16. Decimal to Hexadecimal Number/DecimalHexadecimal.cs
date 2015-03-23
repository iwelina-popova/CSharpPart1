/* Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	hexadecimal
254	FE
6883	1AE3
338583669684	4ED528CBB4
 */ 

using System;

class DecimalHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Program that converts an integer number to its hexadecimal representation.\n");
        Console.Write("Enter an integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        long currentNumber = 0;
        string hexNumber = "";

        while (decimalNumber > 0)
        {
            currentNumber = decimalNumber % 16;
            switch (currentNumber)
            {
                case 10: hexNumber = "A" + hexNumber; break;
                case 11: hexNumber = "B" + hexNumber; break;
                case 12: hexNumber = "C" + hexNumber; break;
                case 13: hexNumber = "D" + hexNumber; break;
                case 14: hexNumber = "E" + hexNumber; break;
                case 15: hexNumber = "F" + hexNumber; break;
                default: hexNumber = currentNumber.ToString() + hexNumber;
                    break;
            }
            decimalNumber = decimalNumber / 16;
        }
        Console.WriteLine("The hex presentation is: {0}", hexNumber);

        Console.ReadLine();      
    }
}

