using System;

namespace _30.Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);
        }
    }
}
