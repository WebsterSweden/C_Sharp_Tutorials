using System;

namespace MikeDane5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1();
            Console.WriteLine("class1Object.class1String1: " + class1Object.class1String1);
            Console.WriteLine("class1Object.Class1Method1: " + class1Object.Class1Method1());

            Console.WriteLine("Class1.class1Int1: " + Class1.class1Int1);
        }
    }
}
