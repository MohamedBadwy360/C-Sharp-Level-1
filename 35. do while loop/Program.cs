﻿using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int i = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;

            } while (i <= 5);

            Console.ReadKey();

        }
    }
}
