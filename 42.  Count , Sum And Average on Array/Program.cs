﻿using System;

// provides us various methods to use in an array
using System.Linq;


namespace _42.Count___Sum_And_Average_on_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note that we used System.Linq above.

            int[] numbers = { 20, 22, 19, 18, 1 };



            // compute Count
            Console.WriteLine("Count = " + numbers.Count());

            // compute Sum
            Console.WriteLine("Sum = " + numbers.Sum());

            // compute the average
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
