using System;

namespace _44.C__Methods
{
    internal class Program
    {
        static void PrintName()
        {
            Console.WriteLine("My Name is Mohamed");
        }

        static void PrintName(string Name, int Age)
        {
            Console.WriteLine($"My name is {Name}. My age is {Age}.");
        }

        static void Main(string[] args)
        {
            PrintName();
            PrintName("Mohamed Badwy", 23);
        }
    }
}
