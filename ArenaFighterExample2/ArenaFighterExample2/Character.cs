using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighterExample2
{
    class Character
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }
        public bool IsAlive { get; set; }
        public bool IsRetired { get; set; }
        public static string[] listOfNames = new string[] { "Orc", "Goblin", "Troll", "Demon", "Dragon", "Faun" };
        public Character()
        {
            Strength = Program.rnd.Next(1, 7);
            Health = Program.rnd.Next(1, 21);
            IsAlive = true;
            IsRetired = false;
        }
        public Character(string name) : this()
        {
            Name = name;
        }
    }
}
