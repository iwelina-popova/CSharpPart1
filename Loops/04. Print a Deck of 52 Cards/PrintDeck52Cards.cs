/* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
output

2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
 * 
Note: You may use the suit symbols instead of text.
 */ 

using System;

    class PrintDeck52Cards
    {
        static void Main()
        {
            Console.WriteLine("All possible cards from a standard deck of 52 cards (without the jokers).\n");

            for (int i = 2; i <= 14; i++)
            {               
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.Write(i); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;

                    default: Console.WriteLine("Not a card!");
                        break;
                    }

                    // Вариант 1:

                    Console.Write(" of ");
                    switch (j)
                    {
                        case 1: Console.Write("spades, "); break;
                        case 2: Console.Write("clubs, "); break;
                        case 3: Console.Write("hearts, "); break;
                        case 4: Console.Write("diamonds\n"); break;
                        default: Console.WriteLine("Not possible suit!");
                            break;
                    }

                    // Вариант 2:

                    //switch (j)
                    //{
                    //    case 1: Console.Write((char)5 + " "); break;
                    //    case 2: Console.Write((char)4 + " "); break;
                    //    case 3: Console.Write((char)3 + " "); break;
                    //    case 4: Console.WriteLine((char)6); break;
                    //    default: Console.WriteLine("Not possible suit!");
                    //        break;
                    //}
                }
            }
            Console.ReadLine();
        }
    }

