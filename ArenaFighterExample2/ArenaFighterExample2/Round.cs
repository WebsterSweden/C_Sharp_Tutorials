using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighterExample2
{
    class Round
    {
        string message;
        public Enum BattleRound(Character player, Character opponent)
        {
            int playerRoll = Program.rnd.Next(1, 7);
            int opponentRoll = Program.rnd.Next(1, 7);
            int playerPower = player.Strength + playerRoll;
            int opponentPower = opponent.Strength + opponentRoll;
            if (playerPower > opponentPower)
            {
                opponent.Health -= player.Strength;
                message = $"{player.Name} did {player.Strength} damage to {opponent.Name}\n{opponent.Name} have {opponent.Health} health remaining";
                Console.WriteLine(message);
                Battle.BattleLog.Add(message);
                return Battle.Result.PlayerWin;
            }
            else if (playerPower < opponentPower)
            {
                player.Health -= opponent.Strength;
                message = $"{opponent.Name} did {opponent.Strength} damage to {player.Name}\n{player.Name} have {player.Health} health remaining";
                Console.WriteLine(message);
                Battle.BattleLog.Add(message);
                return Battle.Result.OpponentWin;
            }
            else
            {
                message = $"{player.Name} and {opponent.Name} blocked each others blows";
                Console.WriteLine(message);
                Battle.BattleLog.Add(message);
                return Battle.Result.Draw;
            }
        }
    }
}
