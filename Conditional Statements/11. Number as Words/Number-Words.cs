/* Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
Examples:

numbers	number as words
0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine
 */

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a number un the range [0 - 999] and it will convert to word.");
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        //int number = 173;

        int one = number % 10;
        int ten = (number % 100) / 10;
        int hundred = number / 100;

        if (hundred != 0)
        {
            switch (hundred)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eigth hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
                default: Console.WriteLine();
                    break;
            }
            if (ten != 0 && one != 0)
            {
                Console.Write("and ");
            }
        }
        if (ten == 1)
        {
            switch (one)
            {
                case 0: Console.Write("Ten"); break;
                case 1: Console.Write("Eleven"); break;
                case 2: Console.Write("Twelve"); break;
                case 3: Console.Write("Thirteen"); break;
                case 4: Console.Write("Fourteen"); break;
                case 5: Console.Write("Fifteen"); break;
                case 6: Console.Write("Sixteen"); break;
                case 7: Console.Write("Seventeen"); break;
                case 8: Console.Write("Eighteen"); break;
                case 9: Console.Write("Nineteen"); break;
                default: Console.WriteLine();
                    break;
            }
        }
        if (ten > 1)
        {
            switch (ten)
            {                
                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Fourty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;
                default: Console.WriteLine();
                    break;
            }
        }
        if (ten != 1)
        {
            switch (one)
            {               
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eigth"); break;
                case 9: Console.Write("Nine"); break;
                default: Console.WriteLine();
                    break;
            }
        }
        if (hundred == 0 && ten == 0 && one == 0)
        {
            Console.WriteLine("Zero");
        }
        Console.ReadLine();
    }
}

