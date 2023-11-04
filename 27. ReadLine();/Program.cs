using System;

namespace _27.ReadLine___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine() always reads string.

            // Type your username and press enter
            Console.WriteLine("Enter username?");
            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);
        }
    }
}
