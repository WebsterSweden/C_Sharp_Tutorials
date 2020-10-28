using System;

namespace Employee1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("FirstNameOne", "LastNameOne", 30, 30000.30);

            Employee person2 = new Employee("FirstNameTwo", "LastNameTwo", 40, 40000.40);

            Console.WriteLine($"{person1.firstName} {person1.lastName} {person1.age} years $ {person1.salary}");

            Console.WriteLine($"{person2.firstName} {person2.lastName} {person2.age} years $ {person2.salary}");
        }
    }
}
