using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class GameBoard
	{
		int terrorTrack;
		List<Monster> monsOnBoard, sky, outskirts;
		List<Investigator> investigators = new List<Investigator>();
		
		public static void Main()
		{
			GameBoard gb = new GameBoard();
			Investigator player1 = gb.investigators[0];
			//player1.moveTo(Southside.Instance);
			//player1.moveTo(Uptown.Instance);
			//player1.moveTo(MiskatonicU.Instance);
			player1.newTurn();
			//player1.moveTo(MercDistrict.Instance);
			//player1.moveTo(Northside.Instance);
			player1.moveTo(Newspaper.Instance);
		}
		
		internal GameBoard()
		{
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

		internal static void connectNeighborhood(Street street, params ArkhamLocation[] arkLocs)
		{
			foreach(ArkhamLocation loc in arkLocs)
			{
				Location.Connect(street, loc);
				loc.BlackLocation = loc.WhiteLocation = street;
			}
		}
		internal static void connectBWStreets(Street blackStreet, Street whiteStreet)
		{
			Location.Connect(blackStreet, whiteStreet);
			blackStreet.WhiteLocation = whiteStreet;
			whiteStreet.BlackLocation = blackStreet;
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
					Console.WriteLine(string.Join(", ", streetsToCheck));
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
	}
}
