using System;

namespace Arkham
{
	public class Dice
	{
		private static Random roller = new Random();

		public static int[] RollDice(int numOfDice)
		{
			int[] rolls = new int[numOfDice];
			for(int i = 0; i < numOfDice; ++i)
			{
				rolls[i] = roller.Next(1, 6 + 1); //6 for 6-sided die
			}
			return rolls;
		}
	}
}
