using System;

namespace _24.Explicit_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 17.58;
            int myInt = (int) myDouble;     // double myDouble = 17.58;

            Console.WriteLine(myDouble);   // Outputs 17.58
            Console.WriteLine(myInt);      // Outputs 17
        }
    }
}
