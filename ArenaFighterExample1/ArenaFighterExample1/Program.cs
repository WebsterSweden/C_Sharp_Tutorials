using System;

namespace ArenaFighterExample1
{
    class Program
    {
        Random randomObjectTwo = new Random();

        static void Main(string[] args)
        {
            // Create an instance of the Random Object.
            Random randomObjectOne = new Random();
            //Random randomObjectOne = new Random(DateTime.Now.Millisecond);
            Console.WriteLine(randomObjectOne);
        }
    }
}
