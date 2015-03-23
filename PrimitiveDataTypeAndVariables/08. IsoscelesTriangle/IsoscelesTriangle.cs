//Write a program that prints an isosceles triangle of 9 copyright symbols ©.

using System;

    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char copyrightSymbol = '\u00A9';
            Console.WriteLine("   {0}   \n  {0} {0}  \n {0}   {0} \n{0} {0} {0} {0}", copyrightSymbol);
            Console.Read();
            
        }
    }

