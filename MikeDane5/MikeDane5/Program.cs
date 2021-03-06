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

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);
            Console.WriteLine(student1.name + " " + student1.major + " " + student1.gpa + " " + student1.GpaHonors());
            Console.WriteLine(student2.name + " " + student2.major + " " + student2.gpa + " " + student2.GpaHonors());

            Console.WriteLine("----------");

            // Rating G, PG, PG-13, R, NR.
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Movie noname = new Movie("NoName", "Anonymous", "Not Rated");
            Console.WriteLine(noname.Rating);
            // TODO: How to loop and output all Class fields?

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.getSongCount());
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);
        }
    }
}
