using System;

namespace MikeDane4
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "abc";
            string guessedWord = "";
            int numberOfGuesses = 0;

            while (secretWord != guessedWord)
            {
                Console.Write("Guess a word: ");
                guessedWord = Console.ReadLine();
                numberOfGuesses++;
            }

            Console.WriteLine("Congratulations! Your guess is: {0}", guessedWord);
            Console.WriteLine("The secret word is: {0}", secretWord);
            Console.WriteLine("The number of guesses: {0}", numberOfGuesses);
        }
    }
}
