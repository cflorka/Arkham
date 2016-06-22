namespace Arkham
{
	internal class Monster
	{
		internal string name;
		internal int sneak, horrorCheck, sanityDam, fight, damage, toughness;
		
		internal Monster(string name, int sneak, int horrorCheck, int sanityDam, int fight, int damage, int toughness)
		{
			this.name = name;
			this.sneak = sneak;
			this.horrorCheck = horrorCheck;
			this.sanityDam = sanityDam;
			this.fight = fight;
			this.damage = damage;
			this.toughness = toughness;
		}

		internal void attack(Investigator i)
		{
			i.takeDamage(damage);
		}

		internal void horrify(Investigator i)
		{
			i.loseSanity(sanityDam);
		}
	}
}
