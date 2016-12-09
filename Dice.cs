using System;

namespace Arkham
{
	public delegate int SuccessCalculator(int[] diceRolls);

	public class Dice
	{
		private static Random roller = new Random();

		public static int[] RollDice(int numOfDice)
		{
			int[] rolls = new int[numOfDice];
			for(int i = 0; i < numOfDice; ++i)
			{
				rolls[i] = RollDice;
			}
			return rolls;
		}

		public static int RollDice(){ return roller.Next(1, 6 + 1); } //6 for 6-sided die

        internal class RollDice : Action
        {
            internal void method(int[] rolls, Predicate<int> reroll
                , Predicate<int[]> addRolls = false, int numOfAdditionalRolls = 0)
            {
                for(int i = 0; i < numOfDice; ++i)
                {
                    roll = rolls[i];
                    if(reroll(roll)){ rolls[i] = RollDice(); }
                }
                if(addRolls(rolls))
                {
                    newRolls = RollDice(numOfAdditionalRolls);
                }
                rolls = rolls.Concat(newRolls).ToArray();
            }
        }
    
        public class DiceModifier
        {
            
        }
    }
}
