using System;
using System.Collections.Generic;

namespace Arkham
{
	internal abstract class Action
	{
		public List<Phase> phaseList; //List of all phases that the action can be performed
		public event ActionHandler Executed;
		public delegate void ActionHandler();
	}
}