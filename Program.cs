//choose monsters from a list
//pick 1 at first
//begin combat (speed of monsters)
//options to attack


using MonsterFight;

string playerMonster = "dragon";
string enemyMonster = "dragon";

GameLogic gameLogic = new GameLogic();  


List<string>playerParty = new List<string>();
playerParty.Add("dragon");

List<string>enemyParty = new List<string>();
enemyParty.Add("dragon");




Console.WriteLine("Pick monster(s): ");
gameLogic.PrintMonsterList();

Console.WriteLine("Type '1' to attack. Type 'exit' to quit program.");
