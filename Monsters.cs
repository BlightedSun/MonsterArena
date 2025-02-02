using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFight
{
    public class Monster
    {
        public string Name { get; set; } 
        //public string MonsterElement { get; set; }
        //public string Weakness { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        //public Ability MonsterAbility { get; set; }


        public Monster(string name, int health, int defense, int power, int speed)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Power = power;
            Speed = speed;

        }

        //public override string ToString()
        //{
        //    return $"Name: {Name}, Health: {Health}, Defense: {Defense}, Power: {Power}, Speed: {Speed}";
        //}


    }

   

    public class Ability
    {
        public string Name { get; set; }
        public int AbilityDamage { get; set; }
        public int HitChance { get; set; }
        //public string AbilityElement { get; set; }

        public Ability(string name, int abilityDamage, int hitChance)
        {
            Name = name;
            AbilityDamage = abilityDamage;
            HitChance = hitChance;

        }
    }

    //elements: nature > earth > storm > water > fire > nature




}




