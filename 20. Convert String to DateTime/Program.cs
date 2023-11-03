using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Convert_String_to_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = "4/11/2023";
            DateTime dt1;

            var isValidDate = DateTime.TryParse(str1, out dt1);

            if (isValidDate)
                Console.WriteLine(dt1);
            else
                Console.WriteLine($"{str1} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

        }
    }
}
