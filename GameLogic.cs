using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MonsterFight
{
    public class GameLogic
    {
        List<Ability> _abilities = new List<Ability>();
        List<Monster> _monsters = new List<Monster>();

        //constructor
        public GameLogic() 
        {
            AddMonster(new Monster("Dragon", 100, 10, 10, 10));
            //_monsters.Add("dragon", new Monster("dragon", 100, 10, 10, 10));
            //name, hp, def, pwr, spd

            AddAbility(new Ability("Fire Breath", 40, 100));
        
        
        
        
        
        }
        
        
        public void AddMonster(Monster monster)
        {
            
            _monsters.Add(monster);

        }

        public void AddAbility(Ability ability)
        {
            _abilities.Add(ability);

        }


        public void PrintMonsterList()
        {
            foreach (var monster in _monsters)
            {
                Console.WriteLine($"Name: {monster.Name}, Health: {monster.Health}, Defense: {monster.Defense}, Power: {monster.Power}, Speed: {monster.Speed}");
            }



        }




    }

    



}
