using System;

namespace ArenaFighterExample1
{
    class Program
    {
        public static Random randomNumberProgramGenerator = new Random();
        public static int randomNumberProgramOne = randomNumberProgramGenerator.Next(1, 11);

        static void Main()
        {
            Random randomNumberMainGenerator = new Random();
            int randomNumberMain = randomNumberMainGenerator.Next(1, 11);
            Console.WriteLine(randomNumberMain);

            int randomNumberProgramTwo = randomNumberProgramGenerator.Next(1, 11);

            Console.WriteLine(randomNumberProgramOne);
            Console.WriteLine(randomNumberProgramTwo);

            Console.WriteLine(Randomization.randomNumberRandomNumberOne);
            Console.WriteLine(Randomization.RandomNumberFunctionOne());

            Console.WriteLine(Randomization.RandomNumberFunctionTwo());
        }
    }
}
