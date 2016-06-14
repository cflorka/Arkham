using System;

namespace Arkham
{
	public class Encounter
	{
		public static bool encounterResult(int baseMods, int difficulty)
		{
			return true;
		}
		public static void Main()
		{
			Investigator carl = new Investigator("Carl", new int[2]{5, 5}, new int[2]{4, 4}, 3, 2, 4, 3);
			Monster mon = new Monster(-1, -1, 1, -1, 2, 1);
			fight(carl, mon);
		}

		private static bool horrorCheck(Investigator i, Monster m)
		{
			Console.WriteLine("Horror Check");
			Console.Write("  ");
			bool fightOver = false;
			if(i.RollDice(i.will + m.horrorCheck) < 1)
			{
				i.loseSanity(m.sanityDam);
				fightOver = i.sanity[0] < 0;
			}
			else
			{
				System.Console.WriteLine("Investigator passed Horror check");
			}
			return fightOver;
		}

		private static bool combat(Investigator i, Monster m)
		{
			Console.WriteLine("Combat Check");
			Console.Write("  ");
			bool fightOver;
			if(i.RollDice(i.fight + m.fight) > m.toughness)
			{
				System.Console.WriteLine("Investigator won!");
				fightOver = true;
			}
			else
			{
				i.dealDamage(m.damage);
				fightOver = i.stamina[0] <= 0;
			}
			return fightOver;
		}

		private static bool evade(Investigator i, Monster m)
		{
			Console.WriteLine("Evade check");
			Console.Write("  ");
			bool fightOver;
			if(i.RollDice(i.sneak + m.horrorCheck) < 1)
			{
				i.dealDamage(m.damage);
				fightOver = i.stamina[0] <= 0;
			}
			else
			{
				System.Console.WriteLine("Investigator passed Evade check");
				fightOver = true;
			}
			return fightOver;
		}

		public static void fight(Investigator i, Monster m)
		{
			bool fightOver = false;
			fightOver = horrorCheck(i, m);
			String response = "";
			while(!fightOver)
			{
				Console.WriteLine("R)un or F)ight?");
				response = Console.ReadLine();
				if(response.ToUpper().StartsWith("R"))
				{
					fightOver = evade(i, m);
				}
				else
				{
					fightOver = combat(i, m);
				}
			}
			i.resolve();
		}
	}
}