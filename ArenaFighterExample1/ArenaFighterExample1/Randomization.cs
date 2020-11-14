using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighterExample1
{
    public class Randomization
    {
        static Random randomizationRandomNumberGenerator = new Random();
        public static int randomNumberRandomNumberOne = randomizationRandomNumberGenerator.Next(1, 11);

        public static int RandomNumberFunctionOne()
        {
            Program.randomNumberProgramGenerator = new Random();
            Program.randomNumberProgramOne = Program.randomNumberProgramGenerator.Next(1, 11);
            return Program.randomNumberProgramOne;
        }

        public static int RandomNumberFunctionTwo()
        {
            int randomNumberFunctionTwoValue = randomizationRandomNumberGenerator.Next(1, 11);
            return randomNumberFunctionTwoValue;
        }
    }
}
