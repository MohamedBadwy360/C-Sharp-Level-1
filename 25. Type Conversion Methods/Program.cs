using System;

namespace _25.Type_Conversion_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));     // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));     // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));   // convert double to int
            //Console.WriteLine(Convert.ToBoolean(myInt));
            Console.WriteLine(Convert.ToString(myBool));    // convert bool to string
        }
    }
}
