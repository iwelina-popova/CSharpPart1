/* Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	    binary
0	        0
3	        11
43691	    1010101010101011
236476736	1110000110000101100101000000
 */ 

using System;

class DecimalBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Program that converts an integer number to its binary representation.\n");
        Console.Write("Enter an integer number: ");
        long number = long.Parse(Console.ReadLine());

        long decimalNumber = number;
        string currentString = String.Empty;
        string binaryNumber = String.Empty;

        while (decimalNumber > 0)
        {
            long currentBit = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            currentString += currentBit.ToString();
        }
        for (int i = currentString.Length - 1; i >= 0 ; i--)
        {
            binaryNumber += currentString[i];
        }
        Console.WriteLine("Decimal: {0} -> binary: {1}", number, binaryNumber);

        Console.ReadLine();
    }
}

