using System;

namespace Arkham
{
	public class Investigator
	{
		internal String name;
		internal int[] stamina, sanity, focus;
		internal int speed, sneak, fight, will, lore, luck;
		internal int success = 5;

		public Investigator(string name, int[] stamina, int[] sanity, int[] focus, int speed, int sneak, int fight, int will, int lore, int luck)
		{
			this.name = name;
			this.stamina = stamina;
			this.sanity = sanity;
			this.focus = focus;
			this.speed = speed;
			this.sneak = sneak;
			this.fight = fight;
			this.will = will;
			this.lore = lore;
			this.luck = luck;
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
			if (sanity[0] <= 0 && stamina[0] <= 0)
			{
				Console.WriteLine(name + " has been DEVOURED!!!"); //add devoured logic
			}
			else if (stamina[0] <= 0)
			{
				Console.WriteLine(name + " fainted!");
				stamina[0] = 1;
				//change location to hospital
			}
			else if (sanity[0] <= 0)
			{
				Console.WriteLine(name + " went insane!");
				sanity[0] = 1;
				//change location to asylum 
			}
		}

		public virtual void takeDamage(int dam)
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
		
		public void bless()
		{
			success = max(4, success - 1);
		}
		
		public void curse()
		{
			success = min(6, success + 1);
		}
	}
}
