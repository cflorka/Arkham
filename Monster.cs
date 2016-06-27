namespace Arkham
{
	enum MovementType{Normal, Fast, Flying, Stationary, Unique};

	internal class Monster
	{
		private string name;
		private int awareness, horrorCheckMod, sanityDam, fight, damage, toughness;
		private GameBoard Board;
		private Shape shape;
		private MovementType moveType;

		internal Monster(string name, Shape shape, MovementType moveType, int awareness, int horrorCheckMod, int sanityDam,
		int fight, int damage, int toughness)
		{
			this.name = name;
			this.shape = shape;
			this.moveType = moveType;
			this.awareness = awareness;
			this.horrorCheckMod = horrorCheckMod;
			this.sanityDam = sanityDam;
			this.fight = fight;
			this.damage = damage;
			this.toughness = toughness;
		}

		internal string Name{get{return name;}}
		internal Shape Shape{get{return shape;}}
		internal Location Location{get; set;}
		internal MovementType MoveType{get{return moveType;}}
		internal int HorrorCheckMod{get{return horrorCheckMod;}}
		internal int Fight{get{return fight;}}
		internal int Toughness{get{return toughness;}}
		internal int Awareness{get{return awareness;}}

		internal void attack(Investigator i)
		{
			i.takeDamage(damage);
		}

		internal void Horrify(Investigator i)
		{
			i.loseSanity(sanityDam);
		}

		internal void Move(ArkhamLocation loc)
		{
			Location.Remove(this);
			Location = loc;
		}

		internal void Move(ArrowColor color)
		{
			ArkhamLocation loc = (ArkhamLocation)Location;
			switch(MoveType)
			{
				case MovementType.Stationary:
					break;
				case MovementType.Normal:
					Move(loc.GetArrowLocation(color));
					break;
				case MovementType.Fast:
					Move(loc.GetArrowLocation(color));
					Move(loc.GetArrowLocation(color));
					break;
				case MovementType.Flying:
					Fly();
					break;
				case MovementType.Unique:
					UniqueMove();
					break;
			}
		}

		private void Fly()
		{
			if(Location is Sky)
			{
				//find least sneaky in the streets
			}
			else
			{
				
			}
		}

		private void UniqueMove(){} //TODO
	}
}
