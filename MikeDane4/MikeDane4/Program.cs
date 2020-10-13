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

            //int i = 1;
            //while (i <= 6)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (i = 1; i <= 6; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numberArrayOne = { 1, 2, 3, 4, 5, 6 };

            //// base number power number.
            //for (i = 0; i < numberArrayOne.Length; i++)
            //{
            //    //Console.WriteLine("numberArrayOne[{0}]: ", i + " " + numberArrayOne[i]);
            //    Console.WriteLine("numberArrayOne[" + i + "]: " + numberArrayOne[i]);
            //}

            //int[,] numberGrid = {
            //{1, 2},
            //{3, 4},
            //{5, 6}
            //};

            //Console.WriteLine(numberGrid[0, 0]);
            //Console.WriteLine(numberGrid[1, 1]);
            //Console.WriteLine(numberGrid[2, 1]);

            // Comment one row.

            /* Comment
             * multiple
             * row.
             */

            //// Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //Console.WriteLine("Divide by zero");
            //Console.Write("Enter number 1: ");
            //int one = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number 0: ");
            //int zero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(one / zero);

            try
            {
                // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
                Console.WriteLine("Divide by zero");
                Console.Write("Enter number 1: ");
                int one = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number 0: ");
                int zero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(one / zero);
            }
            catch (Exception exceptionMessage)
            {
                Console.WriteLine(exceptionMessage.Message);
            }
        }
    }
}
