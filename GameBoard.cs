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
			Location miskU = MiskatonicU.Instance;
			Location admin = AdminBuilding.Instance;
			Location.connect(admin, miskU);
			Location library = Library.Instance;
			Location.connect(library, miskU);
			ScienceBuilding science = ScienceBuilding.Instance;
			Location.connect(science, miskU);
			Console.Write("Connected to " + miskU.ToString() + ": ");
			Console.WriteLine(string.Join(", ", miskU.ConnectedLocations));
			Console.WriteLine(science.ToString());
		}
	}
}
