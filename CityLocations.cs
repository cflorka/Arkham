namespace Arkham
{
	internal class MiskatonicU:Street
	{
		private static readonly MiskatonicU instance = new MiskatonicU();
		private MiskatonicU():base("Miskatonic University"){}
		internal static MiskatonicU Instance { get { return instance; } }
	}

	internal class AdminBuilding:Site
	{
		private static readonly AdminBuilding instance = new AdminBuilding();
		private AdminBuilding():base("Administration Building"){}
		internal static AdminBuilding Instance { get { return instance; } }
	}

	internal class ScienceBuilding:Site
	{
		private static readonly ScienceBuilding instance = new ScienceBuilding();
		private ScienceBuilding():base("Science Building"){}
		internal static ScienceBuilding Instance { get { return instance; } }
	}

	internal class Library:Site
	{
		private static readonly Library instance = new Library();
		private Library():base("Library"){}
		internal static Library Instance { get { return instance; } }
	}
/////
	internal class Uptown:Street
	{
		private static readonly Uptown instance = new Uptown();
		private Uptown():base("Uptown"){}
		internal static Uptown Instance { get { return instance; } }
	}

	internal class Hospital:Site
	{
		private static readonly Hospital instance = new Hospital();
		private Hospital():base("St. Mary's Hospital"){}
		internal static Hospital Instance { get { return instance; } }

/*
		internal class Heal:Encounter
		{
			System.Console.WriteLine("F)ull heal or P)artial?");
		}
*/
	}

	internal class Woods:Site
	{
		private static readonly Woods instance = new Woods();
		private Woods():base("Woods"){}
		internal static Woods Instance { get { return instance; } }
	}

	internal class MagicShop:Site
	{
		private static readonly MagicShop instance = new MagicShop();
		private MagicShop():base("Ye Olde Magick Shoppe"){}
		internal static MagicShop Instance { get { return instance; } }
	}
/////
	internal class MercDistrict:Street
	{
		private static readonly MercDistrict instance = new MercDistrict();
		private MercDistrict():base("Mercant District"){}
		internal static MercDistrict Instance { get { return instance; } }
	}

	internal class Unnamable:Site
	{
		private static readonly Unnamable instance = new Unnamable();
		private Unnamable():base("The Unnamable"){}
		internal static Unnamable Instance { get { return instance; } }
	}

	internal class Docks:Site
	{
		private static readonly Docks instance = new Docks();
		private Docks():base("River Docks"){}
		internal static Docks Instance { get { return instance; } }
	}

	internal class UnvisitedIsle:Site
	{
		private static readonly UnvisitedIsle instance = new UnvisitedIsle();
		private UnvisitedIsle():base("Unvisited Isle"){}
		internal static UnvisitedIsle Instance { get { return instance; } }
	}
/////
	internal class Northside:Street
	{
		private static readonly Northside instance = new Northside();
		private Northside():base("Northside"){}
		internal static Northside Instance { get { return instance; } }
	}

	internal class Newspaper:Site
	{
		private static readonly Newspaper instance = new Newspaper();
		private Newspaper():base("Newspaper"){}
		internal static Newspaper Instance { get { return instance; } }
	}

	internal class TrainStation:Site
	{
		private static readonly TrainStation instance = new TrainStation();
		private TrainStation():base("Train Station"){}
		internal static TrainStation Instance { get { return instance; } }
	}

	internal class CurioShop:Site
	{
		private static readonly CurioShop instance = new CurioShop();
		private CurioShop():base("Curiositie Shoppe"){}
		internal static CurioShop Instance { get { return instance; } }
	}
/////
	internal class Downtown:Street
	{
		private static readonly Downtown instance = new Downtown();
		private Downtown():base("Downtown"){}
		internal static Downtown Instance { get { return instance; } }
	}

	internal class Asylum:Site
	{
		private static readonly Asylum instance = new Asylum();
		private Asylum():base("Arkham Asylum"){}
		internal static Asylum Instance { get { return instance; } }
	}

	internal class Bank:Site
	{
		private static readonly Bank instance = new Bank();
		private Bank():base("Bank of Arkham"){}
		internal static Bank Instance { get { return instance; } }
	}

	internal class IndependenceSq:Site
	{
		private static readonly IndependenceSq instance = new IndependenceSq();
		private IndependenceSq():base("Independence Square"){}
		internal static IndependenceSq Instance { get { return instance; } }
	}
/////
	internal class Easttown:Street
	{
		private static readonly Easttown instance = new Easttown();
		private Easttown():base("Easttown"){}
		internal static Easttown Instance { get { return instance; } }
	}

	internal class PoliceStation:Site
	{
		private static readonly PoliceStation instance = new PoliceStation();
		private PoliceStation():base("Police Station"){}
		internal static PoliceStation Instance { get { return instance; } }
	}

	internal class Roadhouse:Site
	{
		private static readonly Roadhouse instance = new Roadhouse();
		private Roadhouse():base("Hibb's Roadhouse"){}
		internal static Roadhouse Instance { get { return instance; } }
	}

	internal class Diner:Site
	{
		private static readonly Diner instance = new Diner();
		private Diner():base("Velma's Diner"){}
		internal static Diner Instance { get { return instance; } }
	}
/////
	internal class Rivertown:Street
	{
		private static readonly Rivertown instance = new Rivertown();
		private Rivertown():base("Rivertown"){}
		internal static Rivertown Instance { get { return instance; } }
	}

	internal class GenStore:Site
	{
		private static readonly GenStore instance = new GenStore();
		private GenStore():base("General Store"){}
		internal static GenStore Instance { get { return instance; } }
	}

	internal class Graveyard:Site
	{
		private static readonly Graveyard instance = new Graveyard();
		private Graveyard():base("Graveyard"){}
		internal static Graveyard Instance { get { return instance; } }
	}

	internal class Cave:Site
	{
		private static readonly Cave instance = new Cave();
		private Cave():base("Black Cave"){}
		internal static Cave Instance { get { return instance; } }
	}
/////
	internal class FrenchHill:Street
	{
		private static readonly FrenchHill instance = new FrenchHill();
		private FrenchHill():base("French Hill"){}
		internal static FrenchHill Instance { get { return instance; } }
	}

	internal class Lodge:Site
	{
		private static readonly Lodge instance = new Lodge();
		private Lodge():base("Silver Twilight Lodge"){}
		internal static Lodge Instance { get { return instance; } }
	} //Add "Inner Sanctum" logic

	internal class WitchHouse:Site
	{
		private static readonly WitchHouse instance = new WitchHouse();
		private WitchHouse():base("The Witch House"){}
		internal static WitchHouse Instance { get { return instance; } }
	}
/////
	internal class Southside:Street
	{
		private static readonly Southside instance = new Southside();
		private Southside():base("Southside"){}
		internal static Southside Instance { get { return instance; } }
	}

	internal class HistSociety:Site
	{
		private static readonly HistSociety instance = new HistSociety();
		private HistSociety():base("Historical Society"){}
		internal static HistSociety Instance { get { return instance; } }
	}

	internal class BoardHouse:Site
	{
		private static readonly BoardHouse instance = new BoardHouse();
		private BoardHouse():base("Ma's Boarding House"){}
		internal static BoardHouse Instance { get { return instance; } }
	}

	internal class Church:Site
	{
		private static readonly Church instance = new Church();
		private Church():base("South Church"){}
		internal static Church Instance { get { return instance; } }
	}
}