using System;

namespace ArenaFighterExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Random Object.
            Random rnd = new Random(DateTime.Now.Millisecond);
            Console.WriteLine(rnd);
        }
    }
}
