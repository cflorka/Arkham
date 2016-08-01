using System;
namespace SimpleEvent
{
	public delegate void DiceRollHandler(object sender, DiceRolls e);

	public class DiceRolls : EventArgs
	{
		public int[] rolls;
		public int NumOfSuccesses;
		private static Random roller = new Random();
		
		public DiceRolls(int numOfDice)
		{
			rolls = new int[7]; //7 for dice rolls, 0 to be unused
			for(int i = 0; i < numOfDice; ++i)
			{
				++rolls[roller.Next(1, 6 + 1)]; //6 for 6-sided die
			}
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
}