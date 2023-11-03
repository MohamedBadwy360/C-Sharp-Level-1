using System;

namespace _15.Ticks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar.

            DateTime dt = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);
        }
    }
}
