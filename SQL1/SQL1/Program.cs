using System;

namespace SQL1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person
            {
                Id = 1,
                Name = "FirstnameOne LastnameOne",
                PhoneNumber = "123456",
                Location = "Small City",
            };

            Person personTwo = new Person
            {
                Id = 2,
                Name = "FirstnameTwo LastnameTwo",
                PhoneNumber = "456789",
                Location = "Medium City",
            };

            Person personThree = new Person
            {
                Id = 3,
                Name = "FirstnameThree LastnameThree",
                PhoneNumber = "789123",
                Location = "Big City",
            };

            Console.WriteLine($"{personOne.Id} {personOne.Name} {personOne.PhoneNumber} {personOne.Location}");

            Console.WriteLine($"{personTwo.Id} {personTwo.Name} {personTwo.PhoneNumber} {personTwo.Location}");

            Console.WriteLine($"{personThree.Id} {personThree.Name} {personThree.PhoneNumber} {personThree.Location}");
        }
    }
}
