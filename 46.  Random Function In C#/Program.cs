using System;

namespace _46.Random_Function_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (byte i = 0; i < 4; i++)
            {
                Console.WriteLine(random.Next(10, 20)); // returns random integers >= 10 and < 20
            }
        }
    }
}
