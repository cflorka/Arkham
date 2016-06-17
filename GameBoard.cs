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
			Console.Write("Connected to " + uptown.ToString() + ": ");
			Console.WriteLine(string.Join(", ", uptown.ConnectedLocations));
			//miskU neighborhood
			Street miskU = MiskatonicU.Instance;
			ArkhamLocation admin = AdminBuilding.Instance;
			ArkhamLocation library = Library.Instance;
			ArkhamLocation science = ScienceBuilding.Instance;
			connectNeighborhood(miskU, admin, library, science);
			Console.Write("Connected to " + miskU.ToString() + ": ");
			Console.WriteLine(string.Join(", ", miskU.ConnectedLocations));
		}

		public static void connectNeighborhood(Street street, params ArkhamLocation[] arkLocs)
		{
			foreach(ArkhamLocation loc in arkLocs)
			{
				Location.connect(street, loc);
			}
		}
	}
}
