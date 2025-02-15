using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFight
{
    public class Monster
    {
        public string Name;
        //public string MonsterElement { get; set; }
        //public string Weakness { get; set; }
        public int MaxHealth;
        public int CurrentHealth;
        public int Defense;
        public int Power;
        public int Speed;
        //public Ability MonsterAbility { get; set; }
        public Random random;

        public int Hp {  get {return CurrentHealth;  } }
        public string MonsterName { get { return Name; } }
        public bool IsDead { get { return CurrentHealth <= 0; } }


        //consider difference in taking "get/set" out and in constructor typing "this.name = name"


        //constructor for class monster
        public Monster(string name, int maxHealth, int defense, int power, int speed)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.Defense = defense;
            this.Power = power;
            this.Speed = speed;
            this.random = new Random();
        }

        //public override string ToString()
        //{
        //    return $"Name: {Name}, Health: {Health}, Defense: {Defense}, Power: {Power}, Speed: {Speed}";
        //}


        public void Attack(Monster enemy)
        {
            //returns a double value between 0 and 1
            double rng = random.NextDouble();
            //changing range from 0 to 0.5 then 0.75 to 1.25
            rng = rng / 2 + 0.75f;
            int randomDamage = (int)(Power * rng);
            enemy.TakeDamage(randomDamage);
            Console.WriteLine(Name + " attacks " + enemy.Name + " and deals " + randomDamage + " damage!");
        }

        //public void Heal()
        //{
        //    double rng = random.NextDouble();
        //    rng = rng / 2 + 0.75f;
        //    int heal = (int)(HealPower * rng);
        //    CurrentHealth = heal + CurrentHealth > MaxHealth ? MaxHealth : CurrentHealth + heal;
        //    Console.WriteLine(Name + " heals " + heal);

        //}


        public void TakeDamage(int damage) 
        {
            CurrentHealth -= damage;

            if (IsDead)
            {
                Console.WriteLine(Name + " has been defeated!");
            }


        }





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




