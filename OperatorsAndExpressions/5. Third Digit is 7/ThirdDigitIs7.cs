/* Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	Third digit 7?
5	false
701	true
9703	true
877	false
777877	false
9999799	true */

using System;

    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool isSeven = (number / 100) % 10 == 7;
            if (true)
            {
                Console.WriteLine("Is the third digit from right-to-left 7?");
                Console.WriteLine(isSeven);
            }
            else
            {
                Console.WriteLine("Is the third digit from right-to-left 7?");
                Console.WriteLine(isSeven);
            }
                Console.Read();
        }
    }

