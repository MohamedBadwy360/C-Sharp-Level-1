﻿using System;

namespace _28.User_Input_and_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is: " + age);
        }
    }
}
