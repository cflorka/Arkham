namespace Arkham
{
	public class Monster
	{
		internal string name;
		internal int sneak, horrorCheck, sanityDam, fight, damage, toughness;
		
		public Monster(string name, int sneak, int horrorCheck, int sanityDam, int fight, int damage, int toughness)
		{
			this.name = name;
			this.sneak = sneak;
			this.horrorCheck = horrorCheck;
			this.sanityDam = sanityDam;
			this.fight = fight;
			this.damage = damage;
			this.toughness = toughness;
		}

		public void attack(Investigator i)
		{
			i.takeDamage(damage);
		}

		public void horrify(Investigator i)
		{
			i.loseSanity(sanityDam);
		}
	}
}
