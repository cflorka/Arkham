using System.Collections.Generic;

namespace Arkham
{
	internal class Location
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
		internal void Add(Investigator i){investigators.Add(i);}
		internal void Add(Monster m){monsters.Add(m);}
		internal void Remove(Investigator i){investigators.Remove(i);}
		internal void Remove(Monster m){monsters.Remove(m);}
		internal List<Location> ConnectedLocations{ get; set; }

		internal static void Connect(Location loc1, Location loc2)
		{
			loc1.ConnectedLocations.Add(loc2);
			loc2.ConnectedLocations.Add(loc1);
		}

		internal new string ToString(){return name;}
	}

	internal class ArkhamLocation:Location
	{
		internal ArkhamLocation(string name):base(name){}

		internal Location BlackLocation{ get; set; }
		internal Location WhiteLocation{ get; set; }
	}
	internal class CityLocation:ArkhamLocation
	{
		internal CityLocation(string name):base(name) {}

		internal Street ConnectedStreet{ get; set; }
		//internal Gate openGate{ get; set; }
	}
	internal class Street:ArkhamLocation
	{
		internal Street(string name):base(name) {}
	}

	internal class OtherWorldLocation:Location
	{
		internal List<ArkhamLocation> OpenGateLocations;
		internal OtherWorldLocation first, second;
		internal OtherWorldLocation(string name, bool parent):base(name)
		{
			if(parent)
			{
				first = new OtherWorldLocation(name + " 1", false);
				second = new OtherWorldLocation(name + " 2", false);
				OpenGateLocations = new List<ArkhamLocation>();
				first.ConnectedLocations.Add(second);
			}
		}

		internal void OpenGate(Gate gate)
		{
			OpenGateLocations.Add(gate.Location);
			second.ConnectedLocations.Add(gate.Location);
		}

		internal void CloseGate(Gate gate)
		{
			OpenGateLocations.Remove(gate.Location);
			second.ConnectedLocations.Remove(gate.Location);
		}

	}
}
