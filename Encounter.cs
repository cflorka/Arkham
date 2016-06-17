using System;

namespace Arkham
{
	public class Encounter
	{
		public static void Main()
		{
			//Investigator(name, currStam/total, currSanity/total, speed, sneak, fight, will, lore, luck)
			Investigator mike = MichaelMcGlen.Instance;
			Investigator kate = KateWinthrop.Instance;
			Investigator bob = BobJenkins.Instance;
			bob.moveSlider(1,-1);
			mike.moveSlider(1, -1);
			//Monster(sneak, horrorCheck, sanityDam, fight, damage, toughness)
			Monster bat = new Monster("bat", -1, -1, 3, -1, 2, 1);
			initMonster(mike, bat);
		}

		public static void initMonster(Investigator i, Monster m)
		{
			bool avoidMon = false;
			string response = "";
			Console.WriteLine(i.name + " has encountered a " + m.name  + ". R)un or F)ight?");
			response = Console.ReadLine();
			if(response.ToUpper().StartsWith("R"))
			{
				avoidMon = evade(i, m);
			}
			if(! avoidMon)
			{
				fightMon(i, m);
			}
			i.resolve();
		}

		private static bool horrorCheck(Investigator i, Monster m)
		{
			Console.WriteLine("Horror Check");
			Console.Write("  ");
			bool fightOver = false;
			if(i.RollDice(i.getWill() + m.horrorCheck) < 1)
			{
				m.horrify(i);
				fightOver = i.sanity[0] <= 0;
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
			if(i.RollDice(i.getFight() + m.fight) > m.toughness)
			{
				System.Console.WriteLine("Investigator won!");
				fightOver = true;
			}
			else
			{
				m.attack(i);
				fightOver = i.stamina[0] <= 0;
			}
			return fightOver;
		}

		private static bool evade(Investigator i, Monster m)
		{
			Console.WriteLine("Evade check");
			Console.Write("  ");
			bool fightOver;
			if(i.RollDice(i.getSneak() + m.horrorCheck) < 1)
			{
				m.attack(i);
				fightOver = i.stamina[0] <= 0;
			}
			else
			{
				System.Console.WriteLine("Investigator passed Evade check");
				fightOver = true;
			}
			return fightOver;
		}

		public static void fightMon(Investigator i, Monster m)
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