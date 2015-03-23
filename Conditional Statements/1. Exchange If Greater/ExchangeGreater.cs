/*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
 * As a result print the values a and b, separated by a space.
Examples:

a	   b	  result
5	   2	  2 5
3	   4	  3 4
5.5	   4.5	  4.5 5.5
*/
using System;

    class ExchangeGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            Console.Write("First number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                Console.WriteLine(firstNumber + " " + secondNumber);                
            }
            else
            {
                Console.WriteLine(secondNumber + " " + firstNumber);
            }
            Console.ReadLine();
        }
    }

