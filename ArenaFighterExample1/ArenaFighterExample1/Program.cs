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
            //Console.WriteLine(randomNumberMain);

            int randomNumberProgramTwo = randomNumberProgramGenerator.Next(1, 11);

            //Console.WriteLine(randomNumberProgramOne);
            //Console.WriteLine(randomNumberProgramTwo);

            //Console.WriteLine(RandomNumber.randomNumberRandomNumberOne);
            //Console.WriteLine(RandomNumber.RandomNumberFunctionOne());

            //Console.WriteLine(RandomNumber.RandomNumberFunctionTwo());
        }
    }
}
