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
            //char playGame;

            Intro();
            GameStart();

            void Intro()
            {
                Console.WriteLine("Welcome to the Word Guessing Game!\nEnter a secret word and number of tries of guessing");
                Console.Write("Secret word: ");
                secretWord = Console.ReadLine();
                Console.Write("Number of tries: ");
                guessLimit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type # to terminate the program");
            }

            void GameStart()
            {
                while (guessedWord != secretWord && guessStatus == false)
                {
                    Console.Write("Guess the secret word: ");
                    guessedWord = Console.ReadLine();
                    guessCount++;

                    if (guessedWord == "#")
                    {
                        break;
                    }

                    if (guessedWord == secretWord)
                    {
                        Console.WriteLine("Congratulations! You guessed {0} and the word is correct!", guessedWord);
                        guessStatus = true;
                    }
                    else if (guessedWord != secretWord)
                    {
                        Console.WriteLine("Sorry! You guessed: {0} and it is not the correct word", guessedWord);
                        Console.WriteLine("You have guessed {0} out of {1}", guessCount, guessLimit);
                    }

                    if (guessedWord != secretWord && guessCount == guessLimit)
                    {
                        Console.WriteLine("You have used all tries. You loose the game!");
                        guessStatus = true;
                    }
                }
            }
        }
    }
}
