using System.Collections.Generic;

namespace Arkham
{
	public class Location
	{
		string name;
		List<Investigator> investigators;
		List<Monster> monsters;
		//ToDo clueTokens/events
		internal Location(string name)
		{
			this.name = name;
			investigators = new List<Investigator>();
			monsters = new List<Monster>();
			ConnectedLocations = new List<Location>();
		}
		internal void add(Investigator i){investigators.Add(i);}
		internal void add(Monster m){monsters.Add(m);}
		internal List<Location> ConnectedLocations{ get; set; }

		internal static void connect(Location loc1, Location loc2)
		{
			loc1.ConnectedLocations.Add(loc2);
			loc2.ConnectedLocations.Add(loc1);
		}

		internal new string ToString(){return name;}
	}

	public class ArkhamLocation:Location
	{
		internal ArkhamLocation(string name):base(name){}

		internal Location BlackLocation{ get; set; }
		internal Location WhiteLocation{ get; set; }
	}

	public class CityLocation:ArkhamLocation
	{
		internal CityLocation(string name):base(name) {}

		internal Street connectedStreet{ get; set; }
		//internal Gate openGate{ get; set; }
	}
	
	public class Street:ArkhamLocation
	{
		internal Street(string name):base(name) {}
	}
}
