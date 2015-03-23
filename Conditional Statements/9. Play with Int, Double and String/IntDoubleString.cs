/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 * 
Example 1:                            Example 2:

program	user                          program user
Please choose a type:	              Please choose a type:
1 --> int	                          1 --> int	                             
2 --> double                          2 --> double	2	
3 --> string	3                     3 --> string
Please enter a string:	hello         Please enter a double:	1.5
hello*                                2.5

 */

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Choise what to input:\n1. Int-variable\n2. Double-variable\n3. String.\n");
        Console.Write("Please enter your choise: ");
        int choise = int.Parse(Console.ReadLine());
        string input = "NULL";
        double number;

        switch (choise)
        {
            case 1: Console.Write("\nPlease enter a integer: ");
                number = int.Parse(Console.ReadLine());
                input = (number+1).ToString();
                break;
            case 2: Console.Write("\nPlease enter a double: ");
                number = double.Parse(Console.ReadLine());
                input = (number + 1).ToString();
                break; 
            case 3: Console.Write("\nPlease enter a string: ");
                input = Console.ReadLine();
                input += "*";
                break;
		default: Console.WriteLine("This is not a valid input");
 break;
	}
        Console.WriteLine("The result is: {0}", input);
        Console.ReadLine();  
    }
}

