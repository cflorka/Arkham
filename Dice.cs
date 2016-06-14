using System;

namespace Arkham
{
	public class Dice
	{
		private static Random roller = new Random();
		
		public static int RollDice(int numOfDice, int successLvl)
		{
			int roll, numSuccesses = 0;
			if(numOfDice < 1) {Console.Write(" auto-failed!");}
			else {Console.Write(" rolled: ");}
			for(int i = 0; i < numOfDice; ++i)
			{
				roll = roller.Next(1, 6 + 1); //6 for 6-sided die
				Console.Write("" + roll + ", ");
				if(roll >= successLvl){++numSuccesses;}
			}
			return numSuccesses;
		}
	}
}
