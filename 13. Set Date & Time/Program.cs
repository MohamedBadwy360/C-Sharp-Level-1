using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Set_Date___Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 11, 4);
            Console.WriteLine(dt2);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 11, 4, 0, 44, 30);
            Console.WriteLine(dt3);

            DateTime dt4 = new DateTime(2023, 11, 4, 0, 45, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);

            Console.WriteLine();
        }
    }
}
