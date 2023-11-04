using System;

namespace _26.Casting_Enums
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);             //output: 4 

            var wd = (WeekDays)5;               // int to enum conversion
            Console.WriteLine(wd);              //output: Saturday 
        }
    }
}
