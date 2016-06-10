using System;

namespace Arkham
{
	public class Investigator
	{
		internal String name;
		internal Random roller = new Random();
		internal int DICE = 6; //game uses d6
		internal int success = 5;
		internal int[] stamina, sanity;
		internal int fight, will;

		public Investigator(string name, int[] stamina, int[] sanity, int fight, int will)
		{
			this.name = name;
			this.stamina = stamina;
			this.sanity = sanity;
			this.fight = fight;
			this.will = will;
		}

		public int RollDice(int numOfDice)
		{
			int roll, numSuccesses = 0;
			Console.Write(name + " rolled ");
			for(int i = 0; i < numOfDice; ++i)
			{
				roll = roller.Next(1, DICE + 1);
				Console.Write("" + roll + ", ");
				if(roll >= success){++numSuccesses;}
			}
			return numSuccesses;
		}
	}
}
