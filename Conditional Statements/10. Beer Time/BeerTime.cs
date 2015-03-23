﻿/* A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
Note: You may need to learn how to parse dates and times.
Examples:

time	    result
1:00 PM	    beer time
4:30 PM	    beer time
10:57 PM    beer time
8:30 AM	    non-beer time
02:59 AM    beer time
03:00 AM    non-beer time
03:26 AM    non-beer time
 */

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Please enter a time in format \"hh:mm tt\" and the program will print is it beer time ot non-beer time.");
        Console.Write("Enter time: ");
        DateTime dateTime;
        string inputTime = Console.ReadLine();

        bool check = DateTime.TryParse(inputTime, out dateTime);

        if (check)
        {
            dateTime = DateTime.ParseExact(inputTime, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            DateTime startBeerTime = Convert.ToDateTime("1:00 PM");
            DateTime endBeerTime = Convert.ToDateTime("3:00 AM");
            if (dateTime >= startBeerTime || dateTime <= endBeerTime)
            {
                Console.WriteLine("It's a beer time, yeee!");
            }
            else
            {
                Console.WriteLine("It's not a beer time now :(");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }
            Console.ReadLine();
    }
}

