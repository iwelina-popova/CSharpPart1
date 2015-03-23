﻿/* The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Examples:

weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129 */

using System;

    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight:");
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = (weight * 17) / 100;
            Console.WriteLine("Your weight on the moon is {0}.", moonWeight);
            Console.Read();
        }
    }

