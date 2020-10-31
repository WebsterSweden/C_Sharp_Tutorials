using System;

namespace PlayerTurn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string gameEnd = "";

            //Console.WriteLine("Enter number 3 to end the Game");
            //while (gameEnd != "3")
            //{
            //    Console.WriteLine("Game is running");
            //    Console.Write("Enter number 3 to end the Game: ");
            //    gameEnd = Console.ReadLine();
            //}

            //Console.WriteLine("----------");

            bool gameStatus = true;
            string gameInput;
            bool playerAStatus;
            int playerATurn = 1;
            bool playerBStatus;
            int playerBTurn = 1;

            Console.WriteLine("The Game will alternate between Player A and Player B");
            Console.WriteLine("The Player that will start the Game is randomized");
            Console.WriteLine("Enter the word End to exit the Game");

            // Random number 1-2.
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            int randomNumber_1_2 = randomGenerator.Next(1, 3);
            //Console.WriteLine(randomNumber_1_2);

            //Console.WriteLine("----------");

            if (randomNumber_1_2 == 1)
            {
                playerAStatus = true;
                playerBStatus = false;
                Console.WriteLine("The Player A will start the Game");
            }
            else
            {
                playerAStatus = false;
                playerBStatus = true;
                Console.WriteLine("The Player B will start the Game");
            }

            Console.WriteLine("----------");

            while (gameStatus == true)
            {
                if (playerAStatus == true)
                {
                    Console.Write($"Player A Turn: {playerATurn}");
                    playerAStatus = false;
                    playerBStatus = true;
                    playerATurn++;
                    gameInput = Console.ReadLine();
                    if (gameInput == "End")
                    {
                        gameStatus = false;
                    }
                }
                else
                {
                    Console.Write($"Player B Turn: {playerBTurn}");
                    playerAStatus = true;
                    playerBStatus = false;
                    playerBTurn++;
                    gameInput = Console.ReadLine();
                    if (gameInput == "End")
                    {
                        gameStatus = false;
                    }
                }
            }

            Console.WriteLine($"Player A Total Turns: {playerATurn}");
            Console.WriteLine($"Player B Total Turns: {playerBTurn}");
        }
    }
}

// TODO: Turn-based game.
// Two players alternate.
// Each player have specified number of turns before alternation.
// Each player indenpendently have a specified number of turns based on a algorithm before alternation.
