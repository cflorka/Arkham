using System;
using System.Collections.Generic;

namespace Arkham
{
	internal abstract class Phase
	{
		public event PhaseStartHandler PhaseStart;
		public event PhaseEndHandler PhaseEnd;
		public delegate void PhaseEndHandler(Phase p);
		public delegate void PhaseStartHandler();

		internal bool Run(List<Investigator> investigators)
		{
			bool GameOver;
			if (PhaseStart != null) PhaseStart();
			GameOver = InvestigatorActions(investigators);
			if (PhaseEnd != null && !GameOver) PhaseEnd(this);
			return GameOver;
		}
		internal abstract bool InvestigatorActions(List<Investigator> investigators);
	}

	internal class UpkeepPhase : Phase
	{
		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			Console.WriteLine("UpkeepPhase");
			foreach(Investigator i in investigators)
			{
				i.UnexhaustItems();
				i.Upkeep();
				i.AdjustSliders();
			}
			return false;
		}
		//a) Untap
		//b) Items/Investigator powers
		//b) Adjust Skills
	}

	internal class MovementPhase : Phase
	{
		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			Console.WriteLine("MovementPhase");
			foreach(Investigator i in investigators)
			{
				if(i.Location is OtherWorldLocation) i.OtherWorldMove();
				else
				{
					i.Move();
				}
			}
			return false;
		}
		/* (skip if delayed)
		a) Items (tomes, etc.)
		b) Move pieces
			i) Arkham movement
				receive movement points
				move/trade
				fight
				pickup token
			ii) Otherworld movement */
	}

	internal class CityPhase : Phase
	{
		internal override bool InvestigatorActions(List<Investigator> investigators)
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
		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			Console.WriteLine("OtherWorldPhase");
			return false;
		}
	// a) If in otherworld, draw until proper color card
	}

	internal class MythosPhase : Phase
	{
		internal override bool InvestigatorActions(List<Investigator> investigators)
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
		internal static LinkedList<Phase> PhaseList;
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

		internal static Phase get(int index)
		{
			return PhaseList.ElementAt(index);
		}

		internal static Phase Next()
		{
			currentNode = currentNode.Next ?? PhaseList.First;
			return currentNode.Value;
		}
	}
}