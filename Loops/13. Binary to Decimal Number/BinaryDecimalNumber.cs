/* Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

binary	                        decimal
0	                            0
11	                            3
1010101010101011	            43691
1110000110000101100101000000	236476736
 */

using System;

class BinaryDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Program that converts a binary integer number to its decimal form.\n");
        Console.Write("Enter a binary integer number: ");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;
        long currentNumber = 0;
        int power = 1;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            currentNumber = (binaryNumber[i] - 48) * power;
            decimalNumber += currentNumber;
            power *= 2;
        }

        Console.WriteLine("Binary: {0} -> decimal: {1}", binaryNumber, decimalNumber);
        Console.ReadLine();
    }
}

