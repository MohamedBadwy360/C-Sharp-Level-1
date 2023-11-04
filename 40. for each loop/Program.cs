using System;

namespace _40.for_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charcaters = { 'a', 'b', 'c', 'd', 'e' };

            foreach (char c in charcaters)
            {
                Console.WriteLine(c);
            }

            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;

            foreach (char c in gender)
            {
                if (c == 'm')
                    male++;
                else if (c == 'f')
                    female++;
            }

            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
        }
    }
}
