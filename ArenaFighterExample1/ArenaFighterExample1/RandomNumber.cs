using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighterExample1
{
    public class RandomNumber
    {
        static Random randomNumberRandomNumberGenerator = new Random();
        public static int randomNumberRandomNumberOne = randomNumberRandomNumberGenerator.Next(1, 11);

        public static int RandomNumberFunctionOne()
        {
            //Program.randomNumberProgramGenerator = new Random();
            Program.randomNumberProgramOne = Program.randomNumberProgramGenerator.Next(1, 11);
            return Program.randomNumberProgramOne;
        }

        public static int RandomNumberFunctionTwo()
        {
            int randomNumberFunctionTwoValue = randomNumberRandomNumberGenerator.Next(1, 11);
            return randomNumberFunctionTwoValue;
        }
    }
}
