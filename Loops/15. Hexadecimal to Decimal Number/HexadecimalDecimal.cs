/* Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

hexadecimal	  decimal
FE	          254
1AE3	      6883
4ED528CBB4	  338583669684
 */

using System;

class HexadecimalDecimal
{
    static void Main()
    {
        Console.WriteLine("Program that converts a hexadecimal integer number to its decimal form.\n");
        Console.Write("Enter a hexadecimal integer number: ");
        string hexNumber = Console.ReadLine();

        long currentNumber = 0;
        long decimalNumber = 0;
        long power = 1;

        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case 'A': currentNumber = 10; break;
                case 'B': currentNumber = 11; break;
                case 'C': currentNumber = 12; break;
                case 'D': currentNumber = 13; break;
                case 'E': currentNumber = 14; break;
                case 'F': currentNumber = 15; break;

                default: currentNumber = hexNumber[i] - 48;
                    break;
            }
            decimalNumber += currentNumber * power;
            power *= 16;
        }
        Console.WriteLine("Hexadecimal number: {0} -> decimal: {1}", hexNumber, decimalNumber);

        Console.ReadLine();
    }
}

