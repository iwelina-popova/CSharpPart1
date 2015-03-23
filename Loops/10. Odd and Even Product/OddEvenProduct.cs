/* You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
Examples:

numbers	            result
2 1 1 6 3	        yes
product = 6	        
3 10 4 6 5 1	    yes
product = 60	    
4 3 2 5 2	        no
odd_product = 16	
even_product = 15	
 */

using System;
using System.Linq;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Program that checks whether the product of the odd elements is equal to the product of the even elements.\n");
        Console.Write("Enter your numbers: ");
        string numbers = Console.ReadLine();
        int[] arrayNumbers = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 1; i <= arrayNumbers.Length; i++)
        {
            if (i % 2 == 1)
            {
                oddProduct *= arrayNumbers[i-1]; 
            }
            else
            {
                evenProduct *= arrayNumbers[i-1];
            }
        }

        bool isEqual = (oddProduct == evenProduct);

        if (isEqual)
        {
            Console.WriteLine("Product = {0}", oddProduct);
            Console.WriteLine("Is the product of the odd elements equal to the product of the even elements?\nYes");
        }
        else
        {
            Console.WriteLine("Odd product = {0}\nEven product = {1}");
            Console.WriteLine("Is the product of the odd elements equal to the product of the even elements?\nNo");
        }

        Console.ReadLine();
    }
}

