namespace Arkham
{
	public class Encounter
	{
		public static void Main()
		{
			Investigator carl = new Investigator("Carl", new int[2]{5, 5}, new int[2]{4, 4}, 4, 3);
			Monster mon = new Monster(-1, -2, 1, -1, 2, 1);
			fight(carl, mon);
		}
		
		public static void fight(Investigator i, Monster m)
		{
			bool fightOver = false;
			int curr = i.stamina[0];
			// Horror Check
			if(i.RollDice(i.will + m.horrorCheck) < 1)
			{
				i.loseSanity(m.sanityDam);
				fightOver = i.sanity[0] < 0;
			}
			else
			{
				System.Console.WriteLine("Investigator passed Horror check");
			}
			// Fight
			while(!fightOver)
			{
				if(i.RollDice(i.fight + m.fight) > m.toughness)
				{
					System.Console.WriteLine("Investigator won!");
					fightOver = true;
				}
				else
				{
					i.dealDamage(m.damage);
					
					curr = i.stamina[0];
					fightOver = curr <= 0;
				}
				//ask input. Only set fightOver to true, can't set to false
			}
			i.resolve();
		}
	}
}
