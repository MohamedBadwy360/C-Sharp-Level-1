﻿using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Mohammed Abu-Hadhoud";
            Console.WriteLine(MyName);

            int x = 10; int y = 20;

            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
            //this line will give wrong answer :-)
            Console.WriteLine("x+y=" + x + y);

            //this line will give right answer :-)
            Console.WriteLine("x+y=" + (x + y));

            //other common data types
            double MyDouble = 25.89D;
            char MyLetter = 'M';
            bool MyBool = true;

            Console.ReadKey();

        }
    }
}