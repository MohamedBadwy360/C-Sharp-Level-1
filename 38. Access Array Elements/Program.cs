﻿using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // create an array
            int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element in first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);


            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index {0} : {1} ", i, numbers[0]);
            }

            Console.ReadKey();

        }
    }
}
