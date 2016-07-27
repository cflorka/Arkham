namespace Arkham
{
	enum DamageType{Generic, Physical, Magical}
	internal interface Weapon
	{
		int CombatBonus{get;}
		DamageType DamageType{get;}
	}
}