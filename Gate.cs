using System.Collections.Generic;

namespace Arkham
{
	internal class Gate
	{
		OtherWorldLocation OtherWorld;
		int difficulty;
		Shape shape;
		
		internal Gate(OtherWorldLocation otherWorld, int difficulty, Shape shape)
		{
			OtherWorld = otherWorld;
			this.difficulty = difficulty;
			this.shape = shape;
		}
		
		internal ArkhamLocation Location{ get; set; }
	}
}
