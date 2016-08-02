using System;
namespace SimpleEvent
{
	public delegate void DiceRollHandler(object sender, DiceRolls e);

	public class DiceRolls : EventArgs
	{
		public int[] rolls;

		public DiceRolls(int[] rolls)
		{
			this.rolls = rolls;
		}
	}

	class DiceRoller
	{
		public event DiceRollHandler DiceRollHandlers;

		public void RollDice(int numOfDice)
		{
			if (DiceRollHandlers != null)
			{
				DiceRollHandlers(this, new DiceRolls(numOfDice));
			}
		}
	}
	
	public class RunDiceRolls
	{
		static void Main()
		{
			DiceRoller roller = new DiceRoller();
			roller.DiceRollHandlers += new DiceRollHandler(PrintRolls);
			roller.DiceRollHandlers += new DiceRollHandler(Blessed);
			roller.DiceRollHandlers += new DiceRollHandler(Normal);
			roller.DiceRollHandlers += new DiceRollHandler(Cursed);
			roller.RollDice(600);
			roller.RollDice(600);
		}

		public static void PrintRolls(object sender, DiceRolls rolls)
		{
			Console.WriteLine(string.Join(" ", rolls.rolls));
		}

		public static void Blessed(object sender, DiceRolls rolls)
		{
			rolls.NumOfSuccesses = rolls.rolls[4] + rolls.rolls[5] + rolls.rolls[6];
			Console.WriteLine("Blessed: " + rolls.NumOfSuccesses);
		}

		public static void Normal(object sender, DiceRolls rolls)
		{
			rolls.NumOfSuccesses = rolls.rolls[5] + rolls.rolls[6];
			Console.WriteLine("Normal: " + rolls.NumOfSuccesses);
		}

		public static void Cursed(object sender, DiceRolls rolls)
		{
			rolls.NumOfSuccesses = rolls.rolls[6];
			Console.WriteLine("Cursed: " + rolls.NumOfSuccesses);
		}
	}
}