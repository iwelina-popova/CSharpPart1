/* Write an expression that extracts from given integer n the value of given bit at index p.
Examples:

n	    binary representation	p	  bit @ p
5	    00000000 00000101	    2	  1
0	    00000000 00000000	    9	  0
15	    00000000 00001111	    1	  1
5343	00010100 11011111	    7	  1
62241	11110011 00100001	    11	  0    */

using System;


    class BitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an unsigned integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());
            int mask = 1 << bitPosition;
            int nAndMask = n & mask;
            int bit = nAndMask >> bitPosition;
            Console.WriteLine(bit);
            Console.Read();
        }
    }

