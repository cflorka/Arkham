using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class Investigator
	{
		internal String name;
		internal Location location;
		internal int[] stamina, sanity, focus;
		private int speed, sneak, fight, will, lore, luck, movement;
		private int speedSneakBar, fightWillBar, loreLuckBar;
		internal int success = 5;
		internal List<Gate> gateTrophies;
		internal List<Monster> monsterTrophies;
		List<SuccessCalculator> calculators;
		List<Item> equipment;

		internal Investigator(string name, Location location,
			int maxSanity, int maxStamina, int maxFocus, int[] bars,
			int speed, int sneak, int fight, int will, int lore, int luck)
		{
			this.name = name;
			this.location = location;
			location.Add(this);
			stamina = new int[2]{maxStamina, maxStamina};
			sanity = new int[2]{maxSanity, maxSanity};
			focus = new int[2]{maxFocus, maxFocus};
			this.speed = speed;
			this.sneak = sneak;
			this.fight = fight;
			this.will = will;
			this.lore = lore;
			this.luck = luck;
			this.speedSneakBar = bars[0];
			this.fightWillBar = bars[1];
			this.loreLuckBar = bars[2];
			movement = Speed;
			gateTrophies = new List<Gate>();
			monsterTrophies = new List<Monster>();
			calculators = new List<SuccessCalculator>();
			calculators.Add(defaultNumOfSuccesses);
		}
		
		internal Location Location {get{return location;}}
		internal int Speed {get{return speed + speedSneakBar;}}
		internal int Sneak {get{return sneak - speedSneakBar;}}
		internal int Fight {get{return fight + fightWillBar;}}
		internal int Will {get{return will - fightWillBar;}}
		internal int Lore {get{return lore + loreLuckBar;}}
		internal int Luck {get{return luck - loreLuckBar;}}
		internal int HorrorCheckMod {get{return Will;}}

		internal int currentHealth()
		{
			return stamina[0];
		}

		internal int totalHealth()
		{
			return stamina[1];
		}

		internal String healthString()
		{
			return "" + currentHealth() + "/" + totalHealth();
		}

		internal String sanityString()
		{
			return "" + sanity[0] + "/" + sanity[1];
		}
		
		internal GameBoard Board{get;set;}

		internal void resolve()
		{
			if (sanity[0] <= 0 && stamina[0] <= 0)
			{
				Console.WriteLine(name + " has been DEVOURED!!!"); //TODO: add devoured logic
			}
			else if (stamina[0] <= 0)
			{
				Console.WriteLine(name + " fainted!");
				stamina[0] = 1;
				ChangeLocationTo(Hospital.Instance);
			}
			else if (sanity[0] <= 0)
			{
				Console.WriteLine(name + " went insane!");
				sanity[0] = 1;
				ChangeLocationTo(Asylum.Instance);
			}
		}

		internal virtual void takeDamage(int dam)
		{
			stamina[0] -= dam;
			System.Console.WriteLine("  " + name + " takes " + dam + " damage! "
				+ name + " has " + healthString() + " stamina");
		}

		internal void loseSanity(int dam)
		{
			sanity[0] -= dam;
			System.Console.WriteLine("  " + name + " lost " + dam + " sanity! "
				+ name + " has " + sanityString() + " sanity");
		}

		internal int RollDice(int numOfDice)
		{
			return numOfSuccesses(Dice.RollDice(numOfDice));
		}

		internal int numOfSuccesses(int[] rolls)
		{
			int numOfSuccesses = 0;
			foreach(SuccessCalculator calc in calculators)
			{
				numOfSuccesses += calc(rolls);
			}
			return numOfSuccesses;
		}

		internal int defaultNumOfSuccesses(int[] rolls)
		{
			Console.Write(name);
			int successes = 0;
			if(rolls.Length == 0) Console.WriteLine(" auto-failed!");
			else
			{
				Console.WriteLine(" rolled " + string.Join(", ", rolls) + ";");
				foreach(int roll in rolls)
				{
					successes += NumOfSuccesses(roll);
				}
			}
			return successes;
		}

		private int NumOfSuccesses(int roll)
		{
			int numOfSuccesses = 0;
			if(roll >= success) ++numOfSuccesses;
			return numOfSuccesses;
		}

		internal void Bless()
		{
			success = Math.Max(4, success - 1);
		}

		internal void Curse()
		{
			success = Math.Min(6, success + 1);
		}

		internal void MoveSlider(int bar, int amount) //bar 1 = speed/sneak, 2 = fight/will, 3 = lore/luck
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
						if(newPos > 3 || newPos < 0)
							Console.WriteLine("Slider can't go that far");
						else
						{
							speedSneakBar = newPos;
							focus[0] -= amount;
						}
						break;
					case 2:
						newPos = fightWillBar + amount;
						if(newPos > 3 || newPos < 0)
							Console.WriteLine("Slider can't go that far");
						else
						{
							fightWillBar = newPos;
							focus[0] -= amount;
						}
						break;
					case 3:
						newPos = loreLuckBar + amount;
						if(newPos > 3 || newPos < 0)
							Console.WriteLine("Slider can't go that far");
						else
						{
							loreLuckBar = newPos;
							focus[0] -= amount;
						}
						break;
				}
			}
		}

		internal void MoveTo(Location destination)
		{
			int distance = Board.DistanceBetween(location, destination);
			if(distance >= 0)
			{
				if(movement >= distance)
				{
					movement -= distance;
					ChangeLocationTo(destination);
					Console.WriteLine(name + " has " + movement + " movement left");
				}
				else Console.WriteLine(name + " has " + movement + " movement points, and " + destination + " requires " + distance);
			}
			else Console.WriteLine(location + " and " + destination
				+ " are not connected"); //TODO: add recursivity
		}

		internal void ChangeLocationTo(Location destination)
		{
			Console.WriteLine(name + " moved from " + location + " to " + destination);
			location.Remove(this);
			location = destination;
			destination.Add(this);
		}

		internal void NewTurn()
		{
			Console.WriteLine("New Turn");
			//TODO: unexhaust cards
			focus[0] = focus[1];
			//TODO: move focus bar
			//TODO: powers at beginning of turn
			movement = Speed;
		}

		internal void CloseGate()
		{
			if(location is Site)
			{
				Gate gate = ((Site)location).OpenGate;
				if(gate != null)
				{
					gateTrophies.Add(gate);
					Console.WriteLine(name + " closed the gate to " + gate.OtherWorld);
					Board.CloseGate((Site)location);
				}
			}
		}
	}
}
