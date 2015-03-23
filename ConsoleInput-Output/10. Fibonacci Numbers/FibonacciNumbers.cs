/* Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
 * (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
 * */

using System;

    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that reads a number n and prints on the console the first n members of the Fibonacci sequence.\n");
            Console.Write("Please enter number n = ");
            int n = int.Parse(Console.ReadLine());
            ulong firstNumber = 0;
            ulong secondNumber = 1;
            ulong nextNumber;

            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.Write("0, 1");

                for (int i = 2; i < n; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    Console.Write(", {0}", nextNumber);
                }
            }
            //ulong[] array = new ulong[n];
            //array[0] = 0;
            //array[1] = 1;
            
            //Console.Write("0, 1");

            //for (int i = 2; i < n; i++)
            //{
            //    array[i] = array[i - 1] + array[i - 2]; 
            //    Console.Write(", {0}", array[i]);
            //}
            Console.ReadLine();
        }
    }

