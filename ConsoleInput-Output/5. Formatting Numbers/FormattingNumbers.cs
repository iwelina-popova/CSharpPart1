﻿/* Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
Examples:

a	    b	       c	        result
254	    11.6	   0.5	        FE |0011111110| 11.60|0.500 |
499	    -0.5559	   10000	    1F3 |0111110011| -0.56|10000 |
0	    3	       -0.1234	    0 |0000000000| 3|-0.123 |        */

using System;

    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers:");
            Console.Write("First number should be integer: ");
            int a = int.Parse(Console.ReadLine());            
            Console.Write("Second number should be floating-point: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Third number should be floating-point: ");
            double c = double.Parse(Console.ReadLine());

            string bitA = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("|{0, -10:X}|{1, 10:2}|{2, 10:f2}|{3, -10:f3}|", a, bitA, b, c);

            Console.ReadLine();
        }
    }

