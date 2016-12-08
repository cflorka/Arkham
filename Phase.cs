using System;
using System.Collections.Generic;

namespace Arkham
{
	internal abstract class Phase
	{
		public event PhaseStartHandler PhaseStart;
		public event PhaseEndHandler PhaseEnd;
		public delegate void PhaseEndHandler();
		public delegate void PhaseStartHandler();

		internal bool Run(List<Investigator> investigators)
		{
			bool GameOver;
			if (PhaseStart != null) PhaseStart();
			GameOver = InvestigatorActions(investigators);
			if (PhaseEnd != null && !GameOver) PhaseEnd();
			return GameOver;
		}
		internal abstract bool InvestigatorActions(List<Investigator> investigators);
	}

	internal class UpkeepPhase : Phase
	{
		private static readonly UpkeepPhase instance = new UpkeepPhase();
		static UpkeepPhase(){}
		internal static UpkeepPhase Instance{ get { return instance; } }
		
		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
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
		public override string ToString(){ return "Upkeep Phase"; }
	}

	internal class MovementPhase : Phase
	{
		private static readonly MovementPhase instance = new MovementPhase();
		static MovementPhase(){}
		internal static MovementPhase Instance{ get { return instance; } }

		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
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
		public override string ToString(){ return "Movement Phase"; }
	}

	internal class CityPhase : Phase
	{
		private static readonly CityPhase instance = new CityPhase();
		static CityPhase(){}
		internal static CityPhase Instance{ get { return instance; } }

		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			return false;
		}
		// a) Sucked through gate
		// b) Arkham Locations = neighborhood card
		// c) custom street location encounters
		public override string ToString(){ return "City Phase"; }
	}

	internal class OtherWorldPhase : Phase
	{
		private static readonly OtherWorldPhase instance = new OtherWorldPhase();
		static OtherWorldPhase(){}
		internal static OtherWorldPhase Instance{ get { return instance; } }

		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			return false;
		}
	// a) If in otherworld, draw until proper color card
		public override string ToString(){ return "OtherWorld Phase"; }
	}

	internal class MythosPhase : Phase
	{
		private static readonly MythosPhase instance = new MythosPhase();
		static MythosPhase(){}
		internal static MythosPhase Instance{ get { return instance; } }

		internal override bool InvestigatorActions(List<Investigator> investigators)
		{
			return false;
		}
	/*	a) flip card
		b) gate
			i) if gate already there => monster surge
		c) place monster(s)
		d) move monsters */
		public override string ToString(){ return "Mythos Phase"; }
	}

	internal static class Phases
	{
		internal static LinkedList<Phase> PhaseList;
		private static LinkedListNode<Phase> currentNode;

		static Phases()
		{
			PhaseList = new LinkedList<Phase>();
			PhaseList.AddLast(UpkeepPhase.Instance);
			PhaseList.AddLast(MovementPhase.Instance);
			PhaseList.AddLast(CityPhase.Instance);
			PhaseList.AddLast(OtherWorldPhase.Instance);
			PhaseList.AddLast(MythosPhase.Instance);
			currentNode = PhaseList.First;
		}

		internal static Phase Current()
		{
			return currentNode.Value;
		}

/*		internal static Phase get(int index)
		{
			return PhaseList.ElementAt(index);
		}*/

		internal static Phase Next()
		{
			currentNode = currentNode.Next ?? PhaseList.First;
			return currentNode.Value;
		}

		public static void Subscribe(Phase phase, Phase.PhaseStartHandler psh)
		{
			phase.PhaseStart += psh;
		}

		public static void Subscribe(Phase phase, Phase.PhaseEndHandler peh)
		{
			phase.PhaseEnd += peh;
		}
	}
}