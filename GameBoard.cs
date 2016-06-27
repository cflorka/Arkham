using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class GameBoard
	{
		int terrorTrackLvl;
		List<Monster> monsOnBoard;
		List<Gate> openGates;
		List<Investigator> investigators = new List<Investigator>();
		//TODO: Decks: MonsterCup, Mythos, Common, Unique, Spell, Skill, Encounter Decks, etc.

		public static void Main()
		{
			GameBoard gb = new GameBoard();
			Investigator player1 = gb.investigators[0];
			//player1.MoveTo(Southside.Instance);
			//player1.MoveTo(Uptown.Instance);
			player1.MoveTo(MiskatonicU.Instance);
			player1.newTurn();
			//player1.MoveTo(MercDistrict.Instance);
			//player1.MoveTo(Northside.Instance);
			player1.MoveTo(Newspaper.Instance);
			gb.openGate(Newspaper.Instance);
			gb.openGate(Newspaper.Instance);
			player1.ChangeLocationTo(Newspaper.Instance);
			player1.CloseGate();
		}

		internal GameBoard()
		{
			terrorTrackLvl = 0;
			monsOnBoard = new List<Monster>();
			openGates = new List<Gate>();
			InitLocations();
			InitInvestigators();
		}

		internal void InitInvestigators()
		{
			//TODO: Select random investigators for n players
			investigators.Add(MichaelMcGlen.Instance);
			investigators.Add(BobJenkins.Instance);
			investigators.Add(KateWinthrop.Instance);
			foreach(Investigator i in investigators) i.Board = this;
		}

		internal void InitLocations()
		{
			//Uptown neighborhood
			Street uptown = Uptown.Instance;
			connectNeighborhood(uptown, Hospital.Instance, Woods.Instance,
				MagicShop.Instance);
			//miskU neighborhood
			Street miskU = MiskatonicU.Instance;
			connectNeighborhood(miskU, AdminBuilding.Instance, Library.Instance,
				ScienceBuilding.Instance);
			connectBWStreets(uptown, miskU);
			//MercDist neighborhood
			Street mercDist = MercDistrict.Instance;
			connectNeighborhood(mercDist, Unnamable.Instance, Docks.Instance,
				UnvisitedIsle.Instance);
			connectBWStreets(miskU, mercDist);
			//Northside neighborhood
			Street northside = Northside.Instance;
			connectNeighborhood(northside, Newspaper.Instance, TrainStation.Instance,
				CurioShop.Instance);
			connectBWStreets(mercDist, northside);
			//Downtown neighborhood
			Street downtown = Downtown.Instance;
			connectNeighborhood(downtown, Asylum.Instance, Bank.Instance,
				IndependenceSq.Instance);
			connectBWStreets(northside, downtown);
			//Easttown neighborhood
			Street easttown = Easttown.Instance;
			connectNeighborhood(easttown, PoliceStation.Instance, Roadhouse.Instance,
				Diner.Instance);
			connectBWStreets(downtown, easttown);
			//Rivertown neighborhood
			Street rivertown = Rivertown.Instance;
			connectNeighborhood(rivertown, GenStore.Instance, Graveyard.Instance,
				Cave.Instance);
			connectBWStreets(easttown, rivertown);
			//FrenchHill neighborhood
			Street frenchHill = FrenchHill.Instance;
			connectNeighborhood(frenchHill, Lodge.Instance, WitchHouse.Instance);
			connectBWStreets(rivertown, frenchHill);
			//Southside neighborhood
			Street southside = Southside.Instance;
			connectNeighborhood(southside, HistSociety.Instance, BoardHouse.Instance,
				Church.Instance);
			connectBWStreets(frenchHill, southside);
			connectBWStreets(southside, uptown);
			//Additional connections
			Location.Connect(rivertown, mercDist);
			Location.Connect(mercDist, downtown);
			Location.Connect(miskU, frenchHill);
		}

		internal void Remove(Monster m){monsOnBoard.Remove(m);}
		internal void Add(Monster m, ArkhamLocation loc)
		{
			monsOnBoard.Add(m);
			loc.Add(m);
			m.Location = loc;
		}

		internal static void connectNeighborhood(Street street, params ArkhamLocation[] arkLocs)
		{
			foreach(ArkhamLocation loc in arkLocs)
			{
				Location.Connect(street, loc);
				loc.SetArrowLocation(ArrowColor.Black, loc);
				loc.SetArrowLocation(ArrowColor.White, loc);
			}
		}
		internal static void connectBWStreets(Street blackStreet, Street whiteStreet)
		{
			Location.Connect(blackStreet, whiteStreet);
			blackStreet.SetArrowLocation(ArrowColor.White, whiteStreet);
			whiteStreet.SetArrowLocation(ArrowColor.Black, blackStreet);
		}

		internal int DistanceBetween(Location start, Location end)
		{
			int distance = 1;
			if(start.Equals(end)) distance = 0;
			else if(start is OtherWorldLocation || end is OtherWorldLocation)
				distance = -1;
			else if(start.ConnectedLocations.Contains(end)) distance = 1;
			else
			{
				List<Street> checkedStreets = new List<Street>();
				List<Street> nextStreetsToCheck = new List<Street>();
				HashSet<Street> streetsToCheck = new HashSet<Street>(((ArkhamLocation)start).ConnectedStreets());
				bool found = false;
				while(!found)
				{
					++distance;
					foreach(Street s in streetsToCheck)
					{
						if(s.ConnectedLocations.Contains(end))
						{
							found = true;
							break;
						}
						nextStreetsToCheck.AddRange(s.ConnectedStreets());
					}
					checkedStreets.AddRange(streetsToCheck);
					nextStreetsToCheck.RemoveAll(loc => checkedStreets.Contains(loc));
					streetsToCheck = new HashSet<Street>(nextStreetsToCheck);
				}
			}
			return distance;
		}

		internal void openGate(CityLocation loc)
		{
			if(loc.OpenGate == null)
			{
				Gate openingGate = new Gate(new OtherWorldLocation("Other World"), 1, Shape.Circle); //TODO: Draw gate from deck
				loc.OpenGate = openingGate; //TODO: Increase Doom track
				openGates.Add(openingGate);
				openingGate.Location = loc;
				Console.WriteLine("Gate to " + openingGate.OtherWorld + " opened.");
				if(loc.HasInvestigators())
				{
					List<Investigator> investigatorsInLoc = new List<Investigator>(loc.Investigators);
					foreach(Investigator i in investigatorsInLoc)
					{
						i.ChangeLocationTo(openingGate.OtherWorld);
						//TODO: Make investigator delayed
					}
				}
			}
			else Console.WriteLine("MONSTER SURGE!!!"); //TODO: Monster surge logic
		}

		internal void CloseGate(CityLocation loc)
		{
			Gate closingGate = loc.OpenGate; 
			loc.OpenGate = null;
			Shape shape = closingGate.Shape;
			openGates.Remove(closingGate);
			if(openGates.Count == 0)
			{
				//TODO: Add check for game end (no gates, and enough gate trophies)
			}
			BanishMonsters(shape);
		}

		private void BanishMonsters(Shape shape)
		{
			List<Monster> monsterList = GetMonstersWithShape(shape);
			Location loc;
			foreach(Monster m in monsterList)
			{
				loc = m.Location;
				loc.Remove(m);
				this.Remove(m);
				m.Location = null;
				addToCup(m);
			}
		}

		private List<Monster> GetMonstersWithShape(Shape shape)
		{
			List<Monster> monsterList = new List<Monster>();
			foreach(Monster m in monsOnBoard)
			{
				if(m.Shape == shape)
				{
					monsterList.Add(m);
				}
			}
			return monsterList;
		}

		private void MoveOn(Shape shape, ArrowColor color)
		{
			List<Monster> monstersMoving = GetMonstersWithShape(shape);
			foreach(Monster m in monstersMoving)
			{
				m.Move(color);
				//TODO: Handle special movement types
			}
		}

		internal void addToCup(Monster mon)
		{
			//TODO: add monster back to cup deck and shuffle
		}

		internal void IncreaseTerror()
		{
			IncreaseTerror(1);
		}
		internal void IncreaseTerror(int increase)
		{
			terrorTrackLvl += increase;
		}
	}
}
