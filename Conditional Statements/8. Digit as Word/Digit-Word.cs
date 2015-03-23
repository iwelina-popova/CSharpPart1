/* Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
Examples:

d	    result
2	    two
1	    one
0	    zero
5	    five
-0.1    not a digit
hi	    not a digit
9	    nine
10	    not a digit
 */

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Please enter a digit and the digit shows as a word.\n");
        Console.Write("Enter a digit: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0: Console.WriteLine("'0' - Zero"); break;
            case 1: Console.WriteLine("'1' - One"); break;
            case 2: Console.WriteLine("'2' - Two"); break;
            case 3: Console.WriteLine("'3' - Three"); break;
            case 4: Console.WriteLine("'4' - Four"); break;
            case 5: Console.WriteLine("'5' - Five"); break;
            case 6: Console.WriteLine("'6' - Six"); break;
            case 7: Console.WriteLine("'7' - Seven"); break;
            case 8: Console.WriteLine("'8' - Eigth"); break;
            case 9: Console.WriteLine("'9' - Nine"); break;
            default: Console.WriteLine("This is not a digit.");
                break;
        }
        Console.ReadLine();
    }
}

