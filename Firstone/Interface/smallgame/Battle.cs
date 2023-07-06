using System;
namespace Firstone.Interface.smallgame
{
	public class Battle
	{

		public string FightProcess(Warrior a, Warrior b)
		{
			double demage = a.Attack() - b.Block();
			if (demage <= 0) { demage = 0; }
			Console.WriteLine("{0} Attacks {1} and deals {2} demage", a.warriorName,b.warriorName, demage);
            b.healthMax = b.healthMax - demage;
			if (b.healthMax <= 0)
			{
				Console.WriteLine($"{b.warriorName} is dead, and {a.warriorName} is victorier.");
				return "Game Over";
			}
            Console.WriteLine("{0} has {1} health\n", b.warriorName, b.healthMax);

            return "Next round";
		}

		public void StartFight(Warrior a, Warrior b)
		{
			while (true)
			{
				if(FightProcess(a,b) == "Game Over")
				{
					Console.WriteLine("Game Over");
					break;
				}
                if (FightProcess(b, a) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
			
		}
	}
}

