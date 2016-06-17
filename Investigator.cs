using System;

namespace Arkham
{
	public class Investigator
	{
		internal String name;
		internal int[] stamina, sanity, focus;
		private int speed, sneak, fight, will, lore, luck;
		private int speedSneakBar, fightWillBar, loreLuckBar;
		internal int success = 5;

		public Investigator(string name, int[] sanity, int[] stamina, int[] focus, int[] bars,
			int speed, int sneak, int fight, int will, int lore, int luck)
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
			this.speedSneakBar = bars[0];
			this.fightWillBar = bars[1];
			this.loreLuckBar = bars[2];
		}
		
		public int getSpeed() {return speed + speedSneakBar;}
		public int getSneak() {return sneak - speedSneakBar;}
		public int getFight() {return fight + fightWillBar;}
		public int getWill() {return will - fightWillBar;}
		public int getLore() {return lore + loreLuckBar;}
		public int getLuck() {return luck - loreLuckBar;}

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
			System.Console.WriteLine("  " + name + " takes " + dam + " damage! "
				+ name + " has " + healthString() + " stamina");
		}

		public void loseSanity(int dam)
		{
			sanity[0] -= dam;
			System.Console.WriteLine("  " + name + " lost " + dam + " sanity! "
				+ name + " has " + sanityString() + " sanity");
		}

		public int RollDice(int numOfDice)
		{
			return numOfSuccesses(Dice.RollDice(numOfDice));
		}

		public int numOfSuccesses(int[] rolls)
		{
			Console.Write(name);
			int successes = 0;
			if(rolls.Length == 0) Console.WriteLine(" auto-failed!");
			else
			{
				Console.WriteLine(" rolled " + string.Join(", ", rolls) + ";");
				foreach(int roll in rolls)
				{
					successes += numOfSuccesses(roll);
				}
			}
			return successes;
		}

		public int numOfSuccesses(int roll)
		{
			int numOfSuccesses = 0;
			if(roll >= success) ++numOfSuccesses;
			return numOfSuccesses;
		}

		public void bless()
		{
			success = Math.Max(4, success - 1);
		}

		public void curse()
		{
			success = Math.Min(6, success + 1);
		}

		public void moveSlider(int bar, int amount) //bar 1 = speed/sneak, 2 = fight/will, 3 = lore/luck
		{
			if (bar < 1 || bar > 3)
			{
				System.Console.WriteLine("Invalid bar");
			}
			else if (amount > focus[0])
			{
				System.Console.WriteLine("Not enough focus");
			}
			else
			{
				int newPos;
				switch(bar)
				{
					case 1:
						newPos = speedSneakBar + amount;
						if(newPos > 3 || newPos < 0) Console.WriteLine("Slider can't go that far");
						else
						{
							speedSneakBar = newPos;
							focus[0] -= amount;
						}
						break;
					case 2:
						newPos = fightWillBar + amount;
						if(newPos > 3 || newPos < 0) Console.WriteLine("Slider can't go that far");
						else
						{
							fightWillBar = newPos;
							focus[0] -= amount;
						}
						break;
					case 3:
						newPos = loreLuckBar + amount;
						if(newPos > 3 || newPos < 0) Console.WriteLine("Slider can't go that far");
						else
						{
							loreLuckBar = newPos;
							focus[0] -= amount;
						}
						break;
				}
			}
		}

		public void newTurn()
		{
			focus[0] = focus[1];
			//unexhaust cards
		}
	}
}
