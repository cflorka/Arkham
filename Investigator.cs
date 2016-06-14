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
		internal int speed, sneak, fight, will;

		public Investigator(string name, int[] stamina, int[] sanity, int speed, int sneak, int fight, int will)
		{
			this.name = name;
			this.stamina = stamina;
			this.sanity = sanity;
			this.speed = speed;
			this.sneak = sneak;
			this.fight = fight;
			this.will = will;
		}

		public int currentHealth()
		{
			return stamina[0];
		}
		
		public int totalHealth()
		{
			return stamina[1];
		}
		
		public String healthString()
		{
			return "" + currentHealth() + "/" + totalHealth();
		}
		
		public String sanityString()
		{
			return "" + sanity[0] + "/" + sanity[1];
		}

		public void resolve()
		{
			if (sanity[0] < 0 && stamina[0] < 0)
			{
				Console.WriteLine(name + " has been DEVOURED!!!"); //add devoured logic
			}
			else if (stamina[0] < 0)
			{
				Console.WriteLine(name + " fainted!");
				stamina[0] = 1;
				//change location to hospital
			}
			else if (sanity[0] < 0)
			{
				Console.WriteLine(name + " went insane!");
				sanity[0] = 1;
				//change location to asylum 
			}
		}

		public void dealDamage(int dam)
		{
			stamina[0] -= dam;
			System.Console.WriteLine(name + " takes " + dam + " damage! " + name + " has " + healthString() + " stamina");
		}

		public void loseSanity(int dam)
		{
			sanity[0] -= dam;
			System.Console.WriteLine(name + " lost " + dam + " sanity! " + name + " has " + sanityString() + " sanity");
		}

		public int RollDice(int numOfDice)
		{
			Console.Write(name);
			return Dice.RollDice(numOfDice, success);
		}
	}
}
