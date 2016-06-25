using System.Collections.Generic;

namespace Arkham
{
	internal class Gate
	{
		private OtherWorldLocation otherWorld;
		private int skillMod;
		private Shape shape;
		
		internal Gate(OtherWorldLocation otherWorld, int skillMod, Shape shape)
		{
			this.otherWorld = otherWorld;
			this.skillMod = skillMod;
			this.shape = shape;
		}
		
		internal ArkhamLocation Location{ get; set; }
		internal OtherWorldLocation OtherWorld{ get {return otherWorld;} }
		internal Shape Shape{ get {return shape;} }
	}
}
