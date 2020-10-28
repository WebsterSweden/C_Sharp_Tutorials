using System;
using System.Collections.Generic;
using System.Text;

namespace Employee1
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public Employee(string firstNameParameter, string lastNameParameter, int ageParameter, double salaryParameter)
        {
            firstName = firstNameParameter;
            lastName = lastNameParameter;
            age = ageParameter;
            salary = salaryParameter;
        }
    }
}
