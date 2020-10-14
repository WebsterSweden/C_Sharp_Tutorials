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

            Console.WriteLine("----------");

            Book book1 = new Book("OneTitle", "OneAuthor", 100);
            Console.WriteLine(book1.title + " " + book1.author + " " + book1.pages);

            Book book2 = new Book("TwoTitle", "TwoAuthor", 200);
            Console.WriteLine(book2.title + " " + book2.author + " " + book2.pages);

            Console.WriteLine("----------");
        }
    }
}
