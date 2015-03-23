/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
 * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

Examples:

Number a	Number b	    Equal                        Explanation
                   (with precision eps=0.000001)	
5.3	        6.01	        false	             The difference of 0.71 is too big (> eps)
5.00000001	5.00000003	    true	             The difference 0.00000002 < eps
5.00000005	5.00000001	    true	             The difference 0.00000004 < eps
-0.0000007	0.00000007	    true	             The difference 0.00000077 < eps
-4.999999	-4.999998	    false	             Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999	4.999998	    false	             Border case. The difference 0.000001 == eps. We consider the numbers are different. */

using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter two floating-point numbers:\nFirst number a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second number b = ");
            double b = double.Parse(Console.ReadLine());

            double difference = Math.Abs(a - b);
            double eps = 0.000001;
            bool isTrue = a > b;

            if (difference > eps)
            {
                Console.WriteLine("\nThe numbers are NOT equal.");
                Console.WriteLine("The difference of {0} > eps.", difference);
            }
            else
            {
                if (difference == eps)
                {
                    Console.WriteLine("\nThe numbers are NOT equal.");
                    Console.WriteLine("Border case. The difference {0} == eps. We consider the numbers are different.", difference);
                }
                else
                {
                    Console.WriteLine("\nThe numbers are equal.");
                    Console.WriteLine(" The difference {0} < eps.", difference);
                }
            }
            Console.Read();
        }
    }

