using System;

namespace ArenaFighterExample2
{
    class Program
    {
        public static Random rnd = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            Console.WriteLine("Welcome to Arena Fighter!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Character player = new Character(name);
            Console.WriteLine($"Hello {player.Name}!\n" + $"Strength: {player.Strength}\n" + $"Health: {player.Health}");
            while (!player.IsRetired && player.IsAlive)
            {
                Character opponent = new Character(Character.listOfNames[rnd.Next(1, Character.listOfNames.Length)]);
                Console.WriteLine($"Your opponent is {opponent.Name}!\n" + $"Strength: {opponent.Strength}\n" + $"Health: {opponent.Health}");
                battle.Fight(player, opponent);
                if (player.IsAlive)
                {
                    Console.WriteLine("Do you want to retire? (Y/N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        player.IsRetired = true;
                        Console.Clear();
                    }
                }
            }
            if (player.IsRetired)
            {
                Console.WriteLine($"{player.Name} has retired with a final score of {player.Score}");
                foreach (var item in Battle.BattleLog)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}

