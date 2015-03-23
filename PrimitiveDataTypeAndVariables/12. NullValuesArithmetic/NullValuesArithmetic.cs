/* Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;

    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? variableInt = null;
            double? variableDouble = null;
            Console.WriteLine("Print values:\ninteger type variable -> \"{0}\"\ndouble type variable -> \"{1}\"", variableInt, variableDouble);
            variableInt += 5;
            variableDouble = 10.5;
            Console.WriteLine("Print new values:\ninteger type variable -> {0}\ndouble type variable -> {1}", variableInt, variableDouble);
            Console.Read();
        }
    }

