﻿/* Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined. */

using System;

    class Program
    {
        static void Main(string[] args)
        {
            string firstWay = @"The ""use"" of quotations causes difficulties.";
            string secondWay = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstWay);
            Console.WriteLine(secondWay);
            Console.Read();
        }
    }

