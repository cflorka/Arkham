using System;

namespace Arkham
{
	internal class Encounter
	{
		internal static void MonsterEncounter(Investigator i, Monster m)
		{
			bool avoidMon = false;
			string response = "";
			Console.WriteLine(i.name + " has encountered a " + m.Name  + ". R)un or F)ight?");
			response = Console.ReadLine();
			if(response.ToUpper().StartsWith("R"))
			{
				avoidMon = Evade(i, m);
			}
			if(! avoidMon)
			{
				FightMon(i, m);
			}
			i.resolve();
		}

		private static int HorrorCheckMod(Investigator i, Monster m)
		{
			return i.HorrorCheckMod + m.HorrorCheckMod;
		}
		private static bool HorrorCheck(Investigator i, Monster m)
		{
			Console.WriteLine("Horror Check");
			Console.Write("  ");
			bool fightOver = false;
			if(i.RollDice(HorrorCheckMod(i, m)) < 1)
			{
				m.Horrify(i);
				fightOver = i.sanity[0] <= 0;
			}
			else
			{
				System.Console.WriteLine("Investigator passed Horror check");
			}
			return fightOver;
		}

		private static bool Combat(Investigator i, Monster m)
		{
			Console.WriteLine("Combat Check");
			Console.Write("  ");
			bool fightOver;
			if(i.RollDice(i.Fight + m.Fight) > m.Toughness)
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

		private static bool Evade(Investigator i, Monster m)
		{
			Console.WriteLine("Evade check");
			Console.Write("  ");
			bool fightOver;
			if(i.RollDice(i.Sneak + m.Awareness) < 1)
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

		internal static void FightMon(Investigator i, Monster m)
		{
			bool fightOver = false;
			fightOver = HorrorCheck(i, m);
			String response = "";
			while(!fightOver)
			{
				Console.WriteLine("R)un or F)ight?");
				response = Console.ReadLine();
				if(response.ToUpper().StartsWith("R"))
				{
					fightOver = Evade(i, m);
				}
				else
				{
					fightOver = Combat(i, m);
				}
			}
			i.resolve();
		}
	}
}