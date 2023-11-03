using System;

namespace _17.Time_Span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 11, 4);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 30, 30);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);
        }
    }
}
