/* Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true */

using System;

    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            bool isDevided = (number % 5 == 0 && number % 7 == 0);
            if (isDevided == true)
            {
                Console.WriteLine("The number {0} can be devided without remainder by 5 and 7.", number);
            }
            else
            {
                Console.WriteLine("The number {0} can not be devided without remainder by 5 and 7.", number);
            }
            Console.Read();
        }
    }

