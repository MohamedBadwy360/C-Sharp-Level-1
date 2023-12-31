﻿using System;

namespace _44.C__Methods
{
    internal class Program
    {
        static void PrintName()
        {
            Console.WriteLine("My Name is Mohamed");
        }

        static void PrintName(string Name, byte Age)
        {
            Console.WriteLine($"My name is {Name}. My age is {Age}.");
        }

        static void PrintMyInfo(string Name, byte Age, string Address = "No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}", Name, Age, Address);
        }

        static string GetMyName()
        {
            return "Mohammed-AbuHadhoud";

        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            PrintName();
            PrintName("Mohamed Badwy", 23);
            PrintMyInfo("Mohammed-AbuHadhoud", 45, "Amman-Jordan");
            Console.WriteLine(GetMyName());

            MyMethod(child3: "Mohamed", child1: "Ahmed", child2: "Amgad");
        }
    }
}
