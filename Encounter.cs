namespace Arkham
{
	public class Encounter
	{
		public static void Main()
		{
			Investigator carl = new Investigator(new int[2]{5, 5}, new int[2]{4, 4}, 3, 2);
			Monster mon = new Monster(-1, 1, 1, -1, 2, 1);
			fight(carl, mon);
		}
		
		public static void fight(Investigator i, Monster m)
		{
			bool fightOver = false;
			int curr = i.stamina[0];
			//HorrorCheck
			while(!fightOver)
			{
				if(i.RollDice(i.fight + m.fight) > m.toughness)
				{
					System.Console.WriteLine("Investigator won!");
					fightOver = true;
				}
				else
				{
					System.Console.WriteLine("Monster dealt " + m.damage + " damage");
					i.stamina[0] -= m.damage;
					curr = i.stamina[0];
					if(curr <= 0)
					{
						i.stamina[0] = 1;
						System.Console.WriteLine("Investigator lost!");
						fightOver = true;
					}
				}
			}
		}
	}
}
