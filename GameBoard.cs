using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class GameBoard
	{
		private int terrorTrackLvl = 0;
		private List<Monster> monsOnBoard = new List<Monster>();
		private List<Gate> openGates = new List<Gate>();
		private List<Investigator> investigators  = new List<Investigator>();
		private Environment environment;
		private Rumor rumor;
		private Deck<Monster> monsterCup;
		static Deck<MythosCard> MythosDeck = Decks.Mythos;
		//TODO: Decks: Common, Unique, Spell, Skill, Encounter Decks, etc.

		internal GameBoard()
		{
			InitLocations();
			InitInvestigators();
			InitDecks();
		}

		private void InitLocations()
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

		private void InitInvestigators()
		{
			//TODO: Select random investigators for n players
			Add(MichaelMcGlen.Instance);
			Add(BobJenkins.Instance);
			Add(KateWinthrop.Instance);
		}

		internal void Add(Investigator i)
		{
			investigators.Add(i);
			i.Board = this;
		}

		internal void Remove(Investigator i)
		{
			investigators.Remove(i);
			i.Board = null;
		}

		private void InitDecks()
		{
			//TODO: 
			monsterCup = new Deck<Monster>();
		}

		internal List<Investigator> Investigators{get{return investigators;}}

		public delegate bool InvestigatorTest(Investigator i);

		internal List<Investigator> InvestigatorsWhere(InvestigatorTest test)
		{
			List<Investigator> investigatorsFound = new List<Investigator>();
			foreach(Investigator i in investigators)
			{
				if(test(i)) investigatorsFound.Add(i);
			}
			return investigatorsFound;
		}
		
		internal List<Investigator> InvestigatorsInStreets()
		{
			return InvestigatorsWhere(i => i.Location is Street);
		}

		internal List<Investigator> InvestigatorsInOtherWorld()
		{
			return InvestigatorsWhere(i => i.Location is OtherWorldLocation);
		}

		internal void Remove(Monster m){monsOnBoard.Remove(m);}
		internal void Add(Monster m, CityLocation loc)
		{
			monsOnBoard.Add(m);
			loc.Add(m);
			m.PlaceOnBoard(this, loc);
		}

		internal static void connectNeighborhood(Street street, params CityLocation[] arkLocs)
		{
			foreach(CityLocation loc in arkLocs)
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
				HashSet<Street> streetsToCheck = new HashSet<Street>(((CityLocation)start).ConnectedStreets());
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

		internal void openGate(Site loc)
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

		internal void CloseGate(Site loc)
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
				AddToCup(m);
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

		internal void MoveOn(Shape shape, ArrowColor color)
		{
			List<Monster> monstersMoving = GetMonstersWithShape(shape);
			foreach(Monster m in monstersMoving)
			{
				m.Move(color);
			}
		}

		internal void AddToCup(Monster mon)
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

		internal void DiscardEnvironment()
		{
			environment.Discard();
			environment = null;
		}

		internal void DiscardRumor()
		{
			rumor.Discard();
			rumor = null;
		}

		internal void PassRumor()
		{
			rumor.Pass();
			DiscardRumor();
		}

		internal void FailRumor()
		{
			rumor.Fail();
			DiscardRumor();
		}
	}
}
