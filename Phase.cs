using System;
using System.Collections.Generic;

namespace Arkham
{
	internal abstract class Phase
	{
		internal abstract bool Run();
	}

	internal class UpkeepPhase : Phase
	{
		internal override bool Run()
		{
			Console.WriteLine("UpkeepPhase");
			return false;
		}
		//a) Untap
		//b) Items/Investigator powers
	}

	internal class MovementPhase : Phase
	{
		internal override bool Run()
		{
			Console.WriteLine("MovementPhase");
			return false;
		}
		/* (skip if delayed)
		a) Items (tomes, etc.)
		b) Move pieces
			i) Arkham movement (sneak past/fight monsters)
			ii) Otherworld movement */
	}

	internal class CityPhase : Phase
	{
		internal override bool Run()
		{
			Console.WriteLine("CityPhase");
			return false;
		}
		// a) Sucked through gate
		// b) Arkham Locations = neighborhood card
		// c) custom street location encounters
	}

	internal class OtherWorldPhase : Phase
	{
		internal override bool Run()
		{
			Console.WriteLine("OtherWorldPhase");
			return false;
		}
	// a) If in otherworld, draw until proper color card
	}

	internal class MythosPhase : Phase
	{
		internal override bool Run()
		{
			Console.WriteLine("MythosPhase");
			return false;
		}
	/*	a) flip card
		b) gate
			i) if gate already there => monster surge
		c) place monster(s)
		d) move monsters */
	}

	internal static class Phases
	{
		private static LinkedList<Phase> PhaseList;
		private static LinkedListNode<Phase> currentNode;

		static Phases()
		{
			PhaseList = new LinkedList<Phase>();
			PhaseList.AddLast(new UpkeepPhase());
			PhaseList.AddLast(new MovementPhase());
			PhaseList.AddLast(new CityPhase());
			PhaseList.AddLast(new OtherWorldPhase());
			PhaseList.AddLast(new MythosPhase());
			currentNode = PhaseList.First;
		}

		internal static Phase Current()
		{
			return currentNode.Value;
		}

		internal static Phase Next()
		{
			currentNode = currentNode.Next ?? PhaseList.First;
			return currentNode.Value;
		}
	}
}