/* We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.
Examples:

numbers	        result
3 -2 1 1 8	    -2 + 1 + 1 = 0
3 1 -7 35 22	no zero subset
1 3 -4 -2 -1	1 + -1 = 0
                1 + 3 + -4 = 0
                3 + -2 + -1 = 0
1 1 1 -1 -1	    1 + -1 = 0
                1 + 1 + -1 + -1 = 0
0 0 0 0 0	    0 + 0 + 0 + 0 + 0 = 0
 */

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 integer numbers and the program will print all subsets of these numbers whose sum is 0.\n");
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Fifth number: ");
        int e = int.Parse(Console.ReadLine());

        //int a = 1;
        //int b = 3;
        //int c = -4;
        //int d = -2;
        //int e = -1;

        int sumAB = a + b;
        int sumAC = a + c;
        int sumAD = a + d;
        int sumAE = a + e;
        int sumBC = b + c;
        int sumBD = b + d;
        int sumBE = b + e;
        int sumCD = c + d;
        int sumCE = c + e;
        int sumDE = d + e;

        int sumABC = sumAB + c;
        int sumABD = sumAB + d;
        int sumABE = sumAB + e;
        int sumACD = sumAC + d;
        int sumACE = sumAC + e;
        int sumADE = sumAD + e;
        int sumBCD = sumBC + d;
        int sumBCE = sumBC + e;
        int sumBDE = sumBD + e;
        int sumCDE = sumCD + e;

        int sumABCD = sumABC + d;
        int sumABCE = sumABC + e;
        int sumABDE = sumABD + e;
        int sumACDE = sumACD + e;
        int sumBCDE = sumBCD + e;

        int sumABCDE = sumABCD + e;

        bool zeroSubsets = sumAB != 0 && sumAC != 0 && sumAD != 0 && sumAE != 0 && sumBC != 0 && sumBD != 0 && sumBE != 0 &&
            sumCD != 0 && sumCE != 0 && sumDE != 0 && sumABC != 0 && sumABD != 0 && sumABE != 0 && sumBCD != 0 && sumBDE != 0 &&
            sumCDE != 0 && sumABCD != 0 && sumABDE != 0 && sumBCDE != 0 && sumABCDE != 0;

        if (zeroSubsets)
        {
            Console.WriteLine("No zero subsets!");
        }
        else
        {
            if (sumAB == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", a, b, sumAB);
            }
            if (sumAC == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", a, c, sumAC);
            }
            if (sumAD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", a, d, sumAD);
            }
            if (sumAE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", a, e, sumAE);
            }
            if (sumBC == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", b, c, sumBC);
            }
            if (sumBD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", b, d, sumBD);
            }
            if (sumBE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", b, e, sumBE);
            }
            if (sumCD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", c, d, sumCD);
            }
            if (sumCE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", c, e, sumCE);
            }
            if (sumDE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} = {2}", d, e, sumDE);
            }
            if (sumABC == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, b, c, sumABC);
            }
            if (sumABD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, b, d, sumABD);
            }
            if (sumABE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, b, e, sumABE);
            }
            if (sumACD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, c, d, sumACD);
            }
            if (sumACE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, c, e, sumACE);
            }
            if (sumADE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", a, d, e, sumADE);
            }
            if (sumBCD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", b, c, d, sumBCD);
            }
            if (sumBCE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", b, c, e, sumBCE);
            }
            if (sumBDE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", b, d, e, sumBDE);
            }
            if (sumCDE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} = {3}", c, d, e, sumCDE);
            }
            if (sumABCD == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", a, b, c, d, sumABCD);
            }
            if (sumABCE == 0)
            {
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", a, b, c, e, sumABCE);
            }                                                      
            if (sumABDE == 0)                                      
            {                                                      
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", a, b, d, e, sumABDE);
            }                                                      
            if (sumACDE == 0)                                      
            {                                                      
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", a, c, d, e, sumACDE);
            }                                                      
            if (sumBCDE == 0)                                      
            {                                                      
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", b, c, d, e, sumBCDE);
            }                                                      
            if (sumABCDE == 0)                                     
            {                                                      
                Console.WriteLine("Zero subset: {0} + {1} + {2} + {3} = {4}", a, b, c, e, sumABCDE);
            }
        }
        
        Console.ReadLine();
    }
}

