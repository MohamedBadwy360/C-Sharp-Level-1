﻿using System;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nForward Loop:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

                Console.WriteLine(i);

            }

            Console.WriteLine("\nBackword Loop:");
            //backword loop
            for (int i = 10; i >= 1; i--)

            {

                Console.WriteLine(i);

            }


            Console.WriteLine("\nNested Loops:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

                for (int j = 0; j < 10; j++)

                {

                    Console.WriteLine("i={0} and j={1}", i, j);

                }

            }


            Console.ReadKey();

        }
    }
}
