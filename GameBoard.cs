using System;

namespace Arkham
{
	public class GameBoard
	{
		public static void Main()
		{
			Investigator mike = MichaelMcGlen.Instance;
			Investigator kate = KateWinthrop.Instance;
			Investigator bob = BobJenkins.Instance;
			//Uptown neighborhood
			Street uptown = Uptown.Instance;
			ArkhamLocation hospital = Hospital.Instance;
			ArkhamLocation woods = Woods.Instance;
			ArkhamLocation magicShop = MagicShop.Instance;
			connectNeighborhood(uptown, hospital, woods, magicShop);
			//miskU neighborhood
			Street miskU = MiskatonicU.Instance;
			ArkhamLocation admin = AdminBuilding.Instance;
			ArkhamLocation library = Library.Instance;
			ArkhamLocation science = ScienceBuilding.Instance;
			connectNeighborhood(miskU, admin, library, science);
			connectBWStreets(uptown, miskU);
			//MercDist neighborhood
			Street mercDist = MercDistrict.Instance;
			ArkhamLocation unnamable = Unnamable.Instance;
			ArkhamLocation docks = Docks.Instance;
			ArkhamLocation unvisitedIsle = UnvisitedIsle.Instance;
			connectNeighborhood(mercDist, unnamable, docks, unvisitedIsle);
			connectBWStreets(miskU, mercDist);
			//Northside neighborhood
			Street northside = Northside.Instance;
			ArkhamLocation newspaper = Newspaper.Instance;
			ArkhamLocation trainStation = TrainStation.Instance;
			ArkhamLocation curioShop = CurioShop.Instance;
			connectNeighborhood(northside, newspaper, trainStation, curioShop);
			connectBWStreets(mercDist, northside);
			//Downtown neighborhood
			Street downtown = Downtown.Instance;
			ArkhamLocation asylum = Asylum.Instance;
			ArkhamLocation bank = Bank.Instance;
			ArkhamLocation independSq = IndependenceSq.Instance;
			connectNeighborhood(downtown, asylum, bank, independSq);
			connectBWStreets(northside, downtown);
			//Easttown neighborhood
			Street easttown = Easttown.Instance;
			ArkhamLocation policeStation = PoliceStation.Instance;
			ArkhamLocation roadhouse = Roadhouse.Instance;
			ArkhamLocation diner = Diner.Instance;
			connectNeighborhood(easttown, policeStation, roadhouse, diner);
			connectBWStreets(downtown, easttown);
			//Rivertown neighborhood
			Street rivertown = Rivertown.Instance;
			ArkhamLocation genStore = GenStore.Instance;
			ArkhamLocation graveyard = Graveyard.Instance;
			ArkhamLocation cave = Cave.Instance;
			connectNeighborhood(rivertown, genStore, graveyard, cave);
			connectBWStreets(easttown, rivertown);
			//FrenchHill neighborhood
			Street frenchHill = FrenchHill.Instance;
			ArkhamLocation lodge = Lodge.Instance;
			ArkhamLocation witchHouse = WitchHouse.Instance;
			connectNeighborhood(frenchHill, lodge, witchHouse);
			connectBWStreets(rivertown, frenchHill);
			//Southside neighborhood
			Street southside = Southside.Instance;
			ArkhamLocation histSoc = HistSociety.Instance;
			ArkhamLocation boardHouse = BoardHouse.Instance;
			ArkhamLocation church = Church.Instance;
			connectNeighborhood(southside, histSoc, boardHouse, church);
			connectBWStreets(frenchHill, southside);
			connectBWStreets(southside, uptown);
			//
			Location.connect(rivertown, mercDist);
			Location.connect(mercDist, downtown);
			Location.connect(miskU, frenchHill);
		}

		public static void connectNeighborhood(Street street, params ArkhamLocation[] arkLocs)
		{
			foreach(ArkhamLocation loc in arkLocs)
			{
				Location.connect(street, loc);
				loc.BlackLocation = loc.WhiteLocation = street;
			}
		}
		public static void connectBWStreets(Street blackStreet, Street whiteStreet)
		{
			Location.connect(blackStreet, whiteStreet);
			blackStreet.WhiteLocation = whiteStreet;
			whiteStreet.BlackLocation = blackStreet;
		}
	}
}
