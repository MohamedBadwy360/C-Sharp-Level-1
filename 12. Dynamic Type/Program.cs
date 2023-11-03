using System;

namespace _12.Dynamic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("value: {0}, type: {1}\n", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}\n", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}\n", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}\n", MyDynamicVar, MyDynamicVar.GetType());

        }
    }
}
