using System;

namespace _11.Structures
{
    internal class Program
    {
        struct stStudent
        {
            public string FirstName;
            public string LastName;

            public stStudent(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
        static void Main(string[] args)
        {
            stStudent student;
            stStudent student2 = new stStudent();
            stStudent student3 = new stStudent("Hanem", "Shawky");

            student.FirstName = "Mohamed";
            student.LastName = "Badwy";

            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);

            student2.FirstName = "Ali";
            student2.LastName = "Ahmed";

            Console.WriteLine(student2.FirstName);      
            Console.WriteLine(student2.LastName);   

            Console.WriteLine(student3.FirstName);
            Console.WriteLine(student3.LastName);

        }
    }
}
