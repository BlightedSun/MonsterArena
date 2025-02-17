//choose monsters from a list
//pick 1 at first
//begin combat (speed of monsters)
//options to attack


using MonsterFight;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;




bool playGame = true;

string playerMonster;
string enemyMonster;

GameLogic gameLogic = new GameLogic();  

//creating the enemy and player parties. for now, enemy auto selects dragon
List<Monster>_playerParty = new List<Monster>();

List<Monster>_enemyParty = new List<Monster>();
_enemyParty.Add(gameLogic._monsters.Find(monster => monster.Name == "Kelpie"));

Random random = new Random();


Console.WriteLine("Pick 1 monster by typing its name: ");
gameLogic.PrintMonsterList();
string playerchoice = Console.ReadLine();
_playerParty.Add(gameLogic._monsters.Find(monster => monster.Name == playerchoice));



//how do i create an instance of the monster they have chosen and assign it to the active monster?
//do i create a method to create an instance of each type of monster? do i assign Monsters or strings to the playerParty list?


//Console.WriteLine("Enemy picks Kelpie.");
//    Monster activeEnemy = new Monster("Kelpie", 75, 10, 10, 15);
//    Console.WriteLine("You pick Dragon.");
//    Monster activePlayer = new Monster("Dragon", 100, 10, 10, 10);

Console.WriteLine("Player has chosen " + _playerParty.First().Name);
Console.WriteLine("Enemy has chosen " + _enemyParty.First().Name);

Monster activePlayer = _playerParty.First();
Monster activeEnemy = _enemyParty.First();


//who goes first?
bool playerFirst = false;
if (activePlayer.Speed >= activeEnemy.Speed)
{
    playerFirst = true;
}



while (!activePlayer.IsDead && !activeEnemy.IsDead)
{

    
    
    
    if (playerFirst)
    {
        Console.WriteLine(activePlayer.Name + " HP = " + activePlayer.Hp + "  |  " + activeEnemy.Name + " HP = " + activeEnemy.Hp);

        Console.WriteLine("Type '1' to attack. Type 'exit' to quit program.");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            activePlayer.Attack(activeEnemy);

        }
        //add more actions
        else if (choice == "2")
        {
            //activePlayer.Attack(activeEnemy);
        }

    }
    
    playerFirst = true;

    Console.WriteLine(activePlayer.Name + " HP = " + activePlayer.Hp + "  |  " + activeEnemy.Name + " HP = " + activeEnemy.Hp);

    if (activePlayer.IsDead || activeEnemy.IsDead) break;

    Console.WriteLine("Enemy turn: ");
    int rand = random.Next(0, 2);
    if (rand == 0)
    {
        activeEnemy.Attack(activePlayer);
    }
    //can add extra action here
    else
    {
        activeEnemy.Attack(activePlayer);
    }

    if (activePlayer.IsDead || activeEnemy.IsDead) break;
}
Console.WriteLine("Game will close.");




