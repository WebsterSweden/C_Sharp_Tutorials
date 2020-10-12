using System;

namespace WordGuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord;
            string guessedWord = "";
            int guessCount = 0;
            int guessLimit;
            bool guessStatus = false;

            Intro();

            void Intro()
            {
                Console.WriteLine("Welcome to the Word Guessing Game!\nEnter a secret word and number of tries of guessing");
                Console.Write("Secret word: ");
                secretWord = Console.ReadLine();
                Console.Write("Number of tries: ");
                guessLimit = Convert.ToInt32(Console.ReadLine());
            }

            while (guessedWord != secretWord && guessStatus == false)
            {
                Console.Write("Guess the secret word: ");
                guessedWord = Console.ReadLine();
                guessCount++;
                Console.WriteLine("You have guessed {0} out of {1}", guessCount, guessLimit);

                if (guessedWord == secretWord)
                {
                    Console.WriteLine("Win!");
                    guessStatus = true;
                }

                if (guessCount == guessLimit)
                {
                    Console.WriteLine("Loose!");
                    guessStatus = true;
                }
            }
        }
    }
}
