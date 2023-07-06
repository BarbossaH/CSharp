using System;
namespace Firstone.Interface.smallgame
{
	public class MagicWarrior:Warrior
	{
        int teleportChance = 0;
        CanTelepost teleportType = new CanTelepost();
        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);
            if (rndDodge < teleportChance)
            {
                Console.WriteLine($"{warriorName}{teleportType.teleport()}");
                return 9999999;
            }
            return base.Block();
        }
        public MagicWarrior(string name = "Julian", double health = 0,
            double attack = 0, double block = 0, int teleportChance =0)
            :base(name, health,attack,block)
		{
            this.teleportChance = teleportChance;
		}
	}
}

