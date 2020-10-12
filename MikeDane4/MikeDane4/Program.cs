using System;
using System.Runtime.Serialization.Formatters;

namespace MikeDane4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string secretWord = "abc";
            //string guessedWord = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOffGuesses = false;

            //while (secretWord != guessedWord && !outOffGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Guess a word: ");
            //        guessedWord = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOffGuesses = true;
            //    }
            //}

            //if (outOffGuesses)
            //{
            //    Console.WriteLine("You Lose!");
            //}
            //else
            //{
            //    Console.WriteLine("Congratulations! Your guess is: {0}", guessedWord);
            //    Console.WriteLine("The secret word is: {0}", secretWord);
            //    Console.WriteLine("The number of guesses: {0}", guessCount);
            //}

            int i = 1;
            while (i <= 6)
            {
                Console.WriteLine(i);
                i++;
            }

            for (i = 1; i <= 6; i++)
            {
                Console.WriteLine(i);
            }

            int[] numberArrayOne = { 1, 2, 3, 4, 5, 6 };

            for (i = 0; i < numberArrayOne.Length; i++)
            {
                //Console.WriteLine("numberArrayOne[{0}]: ", i + " " + numberArrayOne[i]);
                Console.WriteLine("numberArrayOne[" + i + "]: " + numberArrayOne[i]);
            }
        }
    }
}
