namespace Arkham
{
	enum MovementType{Normal, Fast, Flying, Stationary, Unique};

	internal class Monster
	{
		internal string name;
		internal int sneak, horrorCheck, sanityDam, fight, damage, toughness;
		internal Shape shape;
		internal MovementType moveType;
		
		internal Monster(string name, Shape shape, MovementType moveType, int sneak, int horrorCheck, int sanityDam,
		int fight, int damage, int toughness)
		{
			this.name = name;
			this.shape = shape;
			this.moveType = moveType;
			this.sneak = sneak;
			this.horrorCheck = horrorCheck;
			this.sanityDam = sanityDam;
			this.fight = fight;
			this.damage = damage;
			this.toughness = toughness;
		}

		internal Shape Shape{get{return shape;}}
		internal ArkhamLocation Location{get; set;}

		internal void attack(Investigator i)
		{
			i.takeDamage(damage);
		}

		internal void horrify(Investigator i)
		{
			i.loseSanity(sanityDam);
		}

		internal void Move(ArkhamLocation loc)
		{
			Location.Remove(this);
			Location = loc;
		}
	}
}
