using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighterExample2
{
    class Battle
    {
        public enum Result
        {
            PlayerWin,
            OpponentWin,
            Draw
        }
        public static List<string> BattleLog = new List<string>();
        public void Fight(Character player, Character opponent)
        {
            while (player.IsAlive && opponent.IsAlive)
            {
                Round round = new Round();
                var result = (Result)round.BattleRound(player, opponent);
                if (result == Result.PlayerWin)
                {
                    opponent.Health -= player.Strength;
                    if (opponent.Health <= 0)
                        opponent.IsAlive = false;
                }
                else if (result == Result.OpponentWin)
                {
                    player.Health -= opponent.Strength;
                    if (player.Health <= 0)
                        player.IsAlive = false;
                }
            }
            if (!player.IsAlive)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string message = $"{player.Name} has died with a final score of {player.Score}";
                Console.WriteLine(message);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                BattleLog.Add(message);
                foreach (var item in BattleLog)
                {
                    Console.WriteLine(item);
                }
            }
            else if (!opponent.IsAlive)
            {
                string message = $"{opponent.Name} has died and increased {player.Name}s score by 1";
                Console.WriteLine(message);
                BattleLog.Add(message);
                player.Score++;
            }
        }
    }
}
