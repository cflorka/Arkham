using System.Collections.Generic;

namespace Arkham
{
	enum ArrowColor{White, Black};

	internal class Location
	{
		string name;
		//ToDo clueTokens/events
		internal Location(string name)
		{
			this.name = name;
			Investigators = new List<Investigator>();
			Monsters = new List<Monster>();
			ConnectedLocations = new List<Location>();
		}
		internal List<Investigator> Investigators{ get; set; }
		internal void Add(Investigator i){Investigators.Add(i);}
		internal void Remove(Investigator i){Investigators.Remove(i);}
		internal bool HasInvestigators(){return Investigators.Count > 0;}

		internal List<Monster> Monsters{ get; set; }
		internal void Add(Monster m){Monsters.Add(m);}
		internal void Remove(Monster m){Monsters.Remove(m);}
		internal bool HasMonsters(){return Monsters.Count > 0;}

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
		private Dictionary<ArrowColor, ArkhamLocation> arrowLocations;
		internal ArkhamLocation(string name):base(name)
		{
			arrowLocations = new Dictionary<ArrowColor, ArkhamLocation>();
		}

		internal ArkhamLocation Location{ get; set; }

		internal void SetArrowLocation(ArrowColor color, ArkhamLocation loc)
		{
			arrowLocations.Add(color, loc);
		}

		internal ArkhamLocation GetArrowLocation(ArrowColor color)
		{
			return arrowLocations[color];
		}

		internal List<Street> ConnectedStreets()
		{
			List<Street> connectedStreets = new List<Street>();
			foreach(Location l in ConnectedLocations)
			{
				if(l is Street) connectedStreets.Add((Street)l);
			}
			return connectedStreets;
		}
	}
	internal class CityLocation:ArkhamLocation
	{
		internal CityLocation(string name):base(name) {}

		internal Street ConnectedStreet{ get; set; }
		internal Gate OpenGate{ get; set; }
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
		internal OtherWorldLocation(string name):this(name, true){}

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
