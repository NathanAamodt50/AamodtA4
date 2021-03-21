using System;
using System.Collections.Generic;
using System.Text;

namespace HeroNS

{
   public class Character
    {
        public string Name { get; set; }
        public Global.RaceType Race { get; set; }
        public short Health { get; set; }



        public Character(string name = "Geralt", Global.RaceType race = Global.RaceType.WITCHER, short health = 200)
        {
            Name = name;
            Race = race;
            Health = health;
        }   
        
        public Character(Character one)
        {
            Name = one.Name;
            Race = one.Race;
            Health = one.Health;
        }
    }
}
