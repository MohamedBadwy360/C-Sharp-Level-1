using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Get_Current_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
        }
    }
}
