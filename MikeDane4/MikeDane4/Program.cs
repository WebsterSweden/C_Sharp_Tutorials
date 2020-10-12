using System;

namespace MikeDane4
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "abc";
            string guessedWord = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOffGuesses = false;

            while (secretWord != guessedWord && !outOffGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Guess a word: ");
                    guessedWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOffGuesses = true;
                }
            }

            if (outOffGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("Congratulations! Your guess is: {0}", guessedWord);
                Console.WriteLine("The secret word is: {0}", secretWord);
                Console.WriteLine("The number of guesses: {0}", guessCount);
            }
        }
    }
}
