using System;

namespace _18.Subtraction_of_two_dates_results_in_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2023, 2, 21);
            DateTime dt2 = new DateTime(2023, 2, 25);

            TimeSpan result = dt2.Subtract(dt1);
            Console.WriteLine(result.Days);
        }
    }
}
