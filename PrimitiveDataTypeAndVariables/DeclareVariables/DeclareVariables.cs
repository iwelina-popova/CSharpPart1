/* Declare five variables choosing for each of them the most appropriate of the types 
byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */

using System;

    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort variable1 = 52130;
            sbyte variable2 = -115;
            int variable3 = 4825932;
            byte variable4 = 97;
            short variable5 = -10000;
            Console.WriteLine("Example for integer types:\n");
            Console.WriteLine("ushort -> {0}\nsbyte -> {1}\nint -> {2}\nbyte -> {3}\nshort -> {4}", variable1, variable2, variable3, variable4, variable5);
            Console.Read();
            }
        }
    

