using System;
using System.Collections.Generic;
using System.Text;

namespace MikeDane5
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string nameParameter, string majorparameter, double gpaParameter)
        {
            name = nameParameter;
            major = majorparameter;
            gpa = gpaParameter;
        }

        public bool GpaHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
