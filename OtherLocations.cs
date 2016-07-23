namespace Arkham
{
	internal class Sky:Location
	{
		private static readonly Sky instance = new Sky();
		private Sky():base("Sky"){}
		internal static Sky Instance { get { return instance; } }
	}

	internal class Outskirts:Location
	{
		private static readonly Outskirts instance = new Outskirts();
		private Outskirts():base("Outskirts"){}
		internal static Outskirts Instance { get { return instance; } }
	}

	internal class LostInTime:Location
	{
		private static readonly LostInTime instance = new LostInTime();
		private LostInTime():base("Lost in Time and Space"){}
		internal static LostInTime Instance { get { return instance; } }
	}
}