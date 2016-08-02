using System;
using System.Collections.Generic;

namespace Arkham
{
	enum MovementType{Normal, Fast, Flying, Stationary, Unique};

	internal class Monster
	{
		private string name;
		private int awareness, horrorCheckMod, sanityDam, fight, damage, toughness;
		private GameBoard board;
		private Location location;
		private Shape shape;
		private MovementType moveType;

		internal Monster(string name, Shape shape, MovementType moveType, int awareness, int horrorCheckMod, int sanityDam,
		int fight, int damage, int toughness)
		{
			this.name = name;
			this.shape = shape;
			this.moveType = moveType;
			this.awareness = awareness;
			this.horrorCheckMod = horrorCheckMod;
			this.sanityDam = sanityDam;
			this.fight = fight;
			this.damage = damage;
			this.toughness = toughness;
		}

		internal string Name{get{return name;}}
		internal Shape Shape{get{return shape;}}
		internal Location Location{get{return location;}}
		internal MovementType MoveType{get{return moveType;}}
		internal int HorrorCheckMod{get{return horrorCheckMod;}}
		internal int Fight{get{return fight;}}
		internal int Toughness{get{return toughness;}}
		internal int Awareness{get{return awareness;}}

		internal void PlaceOnBoard(GameBoard board, Location loc)
		{
			this.board = board;
			location = loc;
		}

		internal void attack(Investigator i)
		{
			i.takeDamage(damage);
		}

		internal void Horrify(Investigator i)
		{
			i.loseSanity(sanityDam);
		}

		internal void Move(Location loc)
		{
			location.Remove(this);
			System.Console.WriteLine(name + " moved from " + location + " to " + loc);
			location = loc;
			loc.Add(this);
		}

		internal void Move(ArrowColor color)
		{
			bool nearInvestigators = location.HasInvestigators();
			if(!(nearInvestigators || location is Outskirts) || location is Sky)
			{
				switch(MoveType)
				{
					case MovementType.Stationary:
						break;
					case MovementType.Normal:
						Move(((CityLocation)location).GetArrowTarget(color));
						break;
					case MovementType.Fast:
						Move(((CityLocation)location).GetArrowTarget(color));
						Move(((CityLocation)location).GetArrowTarget(color));
						break;
					case MovementType.Flying:
						FlyingMove();
						break;
					case MovementType.Unique:
						UniqueMove();
						break;
				}
			}
		}

		private void FlyingMove()
		{
			if(location is Sky) Swoop();
			else
			{
				List<Investigator> closeTargets = adjacentTargets();
				if(closeTargets.Count > 0) HuntLeastSneaky(closeTargets);
				else Move(Sky.Instance);
			}
		}

		private void Swoop()
		{
			List<Investigator> streetTargets = board.InvestigatorsInStreets();
			if(streetTargets.Count > 0) HuntLeastSneaky(streetTargets);
		}

		//Presumption: invList is not empty
		private void HuntLeastSneaky(List<Investigator> invList)
		{
			Move((CityLocation)LeastSneaky(invList).Location);
		}

		private Investigator LeastSneaky(List<Investigator> invList)
		{
			Investigator leastSneaky = invList[0];
			foreach(Investigator i in invList)
			{
				if(i.Sneak < leastSneaky.Sneak) leastSneaky = i;
			}
			return leastSneaky;
		}

		private List<Investigator> adjacentTargets()
		{
			List<Investigator> adjacentTargets = new List<Investigator>();
			foreach(Location loc in location.ConnectedLocations)
			{
				if(loc is Street && loc.HasInvestigators())
				{
					adjacentTargets.AddRange(loc.Investigators);
				}
			}
			return adjacentTargets;
		}

		private void UniqueMove(){} //TODO
	}
}
