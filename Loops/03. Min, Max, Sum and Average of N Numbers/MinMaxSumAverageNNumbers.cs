/* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 * 
Example 1:                Example 2:

input	output            input	  output
3       min = 1           2       min = -1
2       max = 5           -1      max = 4
5       sum = 8           4       sum = 3
1	    avg = 2.67                avg = 1.50
 
 */

using System;

class MinMaxSumAverageNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter how many numbers you want to write.\n");
        int n = int.Parse(Console.ReadLine());
        int number;
        int min = 0;
        int max = 0;
        int sum = 0;
        

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                min = number;
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, (double)sum/n);
        Console.ReadLine();
    }
}

