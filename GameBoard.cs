using System;
using System.Collections.Generic;

namespace Arkham
{
	internal class GameBoard
	{
		int terrorTrack;
		List<Monster> monsOnBoard, sky, outskirts;
		List<Investigator> investigators = new List<Investigator>();
		
		
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
	}
}
