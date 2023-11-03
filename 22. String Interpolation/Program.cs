using System;

namespace _22.String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  String Interpolation

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            Console.WriteLine($"Mr. {firstName} {lastName}, code: {code}");

            string fullName = $"Mr. {firstName} {lastName}, code: {code}";
            Console.WriteLine(fullName);
        }
    }
}
