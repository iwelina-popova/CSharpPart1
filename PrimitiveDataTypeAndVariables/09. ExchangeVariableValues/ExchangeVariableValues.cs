/* Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange. */

using System;

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Variables values:\na = {0}\nb = {1}", a, b);
            a = a + b;
            b = a * a;
            Console.WriteLine("New values:\na = {0}\nb = {1}", a, b);
            Console.Read();
        }
    }

