using System;

namespace Arkham
{
    public delegate int SuccessCalculator(int[] diceRolls);

    public class Dice
    {
        private static Random roller = new Random();

        public static int RollADie(){ return roller.Next(1, 6 + 1); } //6 for 6-sided die

        internal static int[] RollDice(int numOfDice)
        {
            int[] diceRolls = new int[numOfDice];
            for(int i = 0; i < numOfDice; ++i) diceRolls[i] = RollADie();
            return diceRolls;
        }
    
        internal static int[] RerollConditional(int[] diceRolls, Predicate<int> reroll)
        {
            int[] newDiceRolls = new int[diceRolls.Length];
            int roll;
            for(int i = 0; i < diceRolls.Length; ++i)
            {
                roll = diceRolls[i];
                newDiceRolls[i] = (reroll(roll) ? RollADie() : roll);
            }
            return newDiceRolls;
        }

        internal static int[] RerollAll(int[] diceRolls)
        {
            return RerollConditional(diceRolls, x => true);
        }
    
        internal static int[] addRolls(int[] diceRolls, int numOfDiceAdded)
        {
            int[] newDiceRolls = new int[diceRolls.Length + numOfDiceAdded];
            diceRolls.CopyTo(newDiceRolls, 0);
            RollDice(numOfDiceAdded).CopyTo(newDiceRolls, diceRolls.Length);
            return newDiceRolls;
        }
    }
}
