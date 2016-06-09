using System;

namespace Arkham
{
	public class Investigator
	{
		public Random roller = new Random();
		public int DICE = 6; //game uses d6
		public int success = 5;
		public int[] stamina, sanity;
		public int fight, will;

		public Investigator(int[] stamina, int[] sanity, int fight, int will)
		{
			this.stamina = stamina;
			this.sanity = sanity;
			this.fight = fight;
			this.will = will;
		}

		public int RollDice(int numOfDice)
		{
			int roll, numSuccesses = 0;
			for(int i = 0; i < numOfDice; ++i)
			{
				roll = roller.Next(1, DICE + 1);
				if(roll >= success){++numSuccesses;}
			}
			return numSuccesses;
		}
	}
}
