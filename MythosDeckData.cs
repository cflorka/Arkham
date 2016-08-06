using System;
using System.Collections.Generic;

namespace Arkham
{
	internal static class MythosDeckData
	{
		public static List<MythosCard> list = new List<MythosCard>();
		internal static List<MythosCard> List{get{return list;}}
		
		static MythosDeckData()
		{
			list.Add(new Environment("A Strange Plague", EnvironmentType.Mystic
				, "Investigators cannot gain Stamina except by receiving medical care in St. Mary's Hospital (or from Vincent Lee). Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Environment("Alien Technology", EnvironmentType.Urban
				, "Mi-Go have their toughness increased by 2. If an investigator passes a Combat check against a Mi-Go, he draws 1 extra Unique Item. Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("All Quiet in Arkham!"
				, "Each player may pass a Luck (-1) check to be Blessed. Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Environment("An Evil Fog", EnvironmentType.Weather
				, "Will checks in Arkham are made at a -1 penalty. Sneak checks in Arkham are made at a +1 bonus. Fliers do not move. Pass:  Fail: "
				, Graveyard.Instance, UnvisitedIsle.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Headline("Big Storm Sweeps Arkham!"
				, "All monsters in the Sky and Outskirts are returned to the cup. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Bizarre Dreams Plague Citizens!"
				, "All Gugs and Nightgaunts in Arkham are returned to the cup. If at least one monster returns to the cup, raise the terror level by 1. Pass:  Fail: "
				, ScienceBuilding.Instance, WitchHouse.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Environment("Blackest Night", EnvironmentType.Mystic
				, "Luck checks in Arkham are made at a -1 penalty. Sneak checks in Arkham are made at a +1 bonus. Pass:  Fail: "
				, Cave.Instance, Roadhouse.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Environment("Blood Magic", EnvironmentType.Mystic
				, "Investigators who end their movement in Rivertown streets may choose to delve into dark mysteries using their life force. They roll dice equal to their current Stamina, and for every failed die, they lose 1 Stamina. If this reduces them to 0 Stamina, they are devoured and the player must start a new character. Otherwise, they gain 3 Clue tokens. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Blue Flu!"
				, "All investigators in jail are released. No investigators may be arrested until the end of next turn. Leave this card in play until then to indicate this. Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("Campus Security Increased!"
				, "All monsters in the Miskatonic U. Streets or Locations are returned to the cup. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Church Group Reclaims Southside!"
				, "All monsters in the Southside streets or locations are returned to the cup. Pass:  Fail: "
				, Cave.Instance, Roadhouse.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("City Gripped by Blackouts!"
				, "The General Store, Curiositie Shoppe, and Ye Olde Magick Shoppe are closed until the end of next turn. Leave this card in play until then to indicate this. Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Environment("Curfew Enforced", EnvironmentType.Urban
				, "Any investigator who ends his movement in the streets must pass a Will (+0) check or be arrested and taken to the Police Station. Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("Darke's Carnival Arrives", EnvironmentType.Urban
				, "Investigators who end their movement in the Northside streets gain 1 Clue token from the sinister wonders they witness, but must pass a Will (-1) check or lose 1 Sanity. Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Rumor("Disturbing the Dead"
				, "Ongoing Effect: Roll a die at the end of every Mythos Phase while this card is in play (beginning the turn after it entered play). On a 1 or 2, increase the terror level by 1. Pass: If a single player discards 2 gate trophies during the Arkham Encounter Phase while in the Rivertown streets, return this card to the box. Each player draws 1 Spell. Fail: If the terror level reaches 10, return this card to the box. Every investigator is Cursed."
				, Cave.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Environment("Dreams of a Sunken City", EnvironmentType.Mystic
				, "Investigators cannot gain Sanity except by receiving psychiatric care at Arkham Asylum (or from Carolyn Fern). Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("Egyptian Exhibit Visits Miskatonic U.", EnvironmentType.Urban
				, "Any investigator who ends his movement in the Miskatonic U. streets may pass a Lore (-1) check to gain 1 Clue token by reading the strange hieroglyphics on the artifacts in the exhibit. Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("Estate Sale", EnvironmentType.Urban
				, "Investigators who end their movement in the Uptown streets may draw 2 Unique Items and purchase one, none, or both of them at list price, discarding any that are not purchased Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Family Found Butchered!"
				, "The terror level increases by 1 in light of this tragic news. Pass:  Fail: "
				, Graveyard.Instance, UnvisitedIsle.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Feds Raid Arkham!"
				, "All monsters in the streets are returned to the cup. Pass:  Fail: "
				, Cave.Instance, Roadhouse.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Fourth of July Parade!"
				, "Investigators cannot move into or out of the Merchant Dist. streets until the end of next turn. Leave this card in play until then to indicate this Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Gangs Clean Up Easttown!"
				, "All monsters in the Easttown streets or locations are returned to the cup. Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Ghost Ship Docks by Itself!"
				, "An ancient ghost ship arrives in Arkham, releasing 2 monsters into the Merchant Dist. streets Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Goat-like Creature Spotted in Woods!"
				, "All Dark Young in Arkham are returned to the cup. If at least one monster returns to the cup, raise the terror level by 1. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Rumor("Good Work Undone"
				, "When this card enters play, place 6 Clue tokens on it. Any player may spend Clue tokens during the Arkham Encounter Phase while in the Easttown streets to discard Clue tokens from this card on a 1-for-1 basis. Pass: If there are no Clue tokens on this card, return it to the box. Each player draws one unique item Fail: If there are 10 Clue tokens on this card, return it to the box. All elder sign tokens are removed from the board."
				, UnvisitedIsle.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Environment("Happy Days are Here Again", EnvironmentType.Urban
				, "Due to the renewed prosperity that has come to Arkham, the terror level cannot increase Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Diamond, Shape.Square, Shape.Triangle}, new Shape[]{Shape.Circle}));
			list.Add(new Environment("Heat Wave", EnvironmentType.Weather
				, "Fight checks in Arkham are made at a -1 penalty. Lore checks in Arkham are made at a +1 bonus. Fire Vampires have their toughness increased by 1 Pass:  Fail: "
				, Woods.Instance, Woods.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Horror at Groundbreaking!"
				, "An ancient stone is disturbed by the construction, releasing 2 monsters into the Miskatonic U. streets Pass:  Fail: "
				, HistSociety.Instance, Lodge.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Environment("Icy Conditions", EnvironmentType.Weather
				, "Investigators receive 1 less movement point during the Movement Phase. Fast Monsters move like normal monsters Pass:  Fail: "
				, HistSociety.Instance, Lodge.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Headline("Ill Wind Grips Arkham!"
				, "The first player must pass a Luck (-1) check or be Cursed Pass:  Fail: "
				, Graveyard.Instance, UnvisitedIsle.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("Lodge Member Held for Questioning!"
				, "A Silver Lodge ritual lets 2 monsters loose in the French Hill streets. Pass:  Fail: "
				, Cave.Instance, Roadhouse.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Lodge Members Watch the Night!"
				, "All monsters in the French Hill streets or locations are returned to the cup. Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Manhunt in Arkham!"
				, "All monsters in locations are returned to the cup. Pass:  Fail: "
				, Woods.Instance, IndependenceSq.Instance
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Headline("Merchants March on Crime!"
				, "All monsters in the Merchant Dist. streets or locations are returned to the cup. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Miskatonic Arctic Expedition Returns!"
				, "Any Elder Things previously claimed as monster trophies by players return to life and are placed in the River Docks. Pass:  Fail: "
				, Roadhouse.Instance, IndependenceSq.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Headline("Missing People Return!"
				, "All investigators currently lost in time and space immediately return to Arkham, appearing in a street or location of their choice. Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Environment("No One Can Help You Now", EnvironmentType.Mystic
				, "Gates cannot be sealed, although they can still be closed Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("Noden's Favor", EnvironmentType.Mystic
				, "It costs 2 fewer Clue tokens to seal gates Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Headline("Picnickers Panic!"
				, "A careless picnicker unleashes 2 monsters on the Downtown streets Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Environment("Planetary Alignment", EnvironmentType.Mystic
				, "Thanks to the mystic energy generated by the planetary alignment, all Spells have a Sanity cost of 0. Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Police Step Up Patrols in Northside!"
				, "All monsters in the Northside streets or locations are returned to the cup. Pass:  Fail: "
				, Lodge.Instance, Graveyard.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Private Security Hired in Uptown!"
				, "All monsters in the Uptown streets or locations are returned to the cup Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Environment("Raining Cats and Dogs", EnvironmentType.Weather
				, "Star Spawn and Maniacs have their toughness increased by 1. The difficulty to seal or close gates to R'lyeh is increased by 1. Pass:  Fail: "
				, Roadhouse.Instance, HistSociety.Instance
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Headline("Rivertown Residents Take Back Streets!"
				, "Speed checks in Arkham are made at a -1 penalty, and players receive one less movement point during theMovement Phase. Sneak checks in Arkham are made at a +1 bonus. Return any Fire Vampires in play to the cup. If a Fire Vampire enters play, return it to the cup and draw a different monster. Pass:  Fail: "
				, WitchHouse.Instance, IndependenceSq.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("R'lyeh Rising", EnvironmentType.Mystic
				, "All monsters in the Rivertown streets or locations are returned to the cup. Pass:  Fail: "
				, Woods.Instance, Cave.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Scientist Warns of Dimensional Rift!"
				, "All Dimensional Shamblers and Hounds of Tindalos are returned to the cup. If one or more monster is returned to the cup, raise the terror level by 1. Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("Sheldon Gang Turns to Police for Aid!"
				, " Pass: The Sheldon Gang disturbs a burial mound, releasing 2 monsters into the Uptown Streets. Fail: "
				, Graveyard.Instance, UnvisitedIsle.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Slum Murders Continue!"
				, "An old basement is opened, releasing 2 monsters into the Easttown Streets Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Environment("Solar Eclipse", EnvironmentType.Mystic
				, "Due to the interference of the solar eclipse, no spells may be cast Pass:  Fail: "
				, Graveyard.Instance, UnvisitedIsle.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Southside Strangler Suspected!"
				, "However, the press is mistaken, and the murders were caused by 2 monsters that are released into the Southside streets. Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Strange Lights on Campus!"
				, "The Library, Administration Building and Science Building are all closed until the end of next turn. Leave this card in play until then to indicate this Pass:  Fail: "
				, Woods.Instance, HistSociety.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("Strange Power Flux Plagues City!"
				, "All investigators in Other World areas may immediately return to Arkham Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Headline("Strange Tremors Cease!"
				, "All Chthonians and Dholes in Arkham are returned to the cup. If at least one monster returns to the cup, raise theterror level by 1. Pass:  Fail: "
				, IndependenceSq.Instance, Unnamable.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Environment("Sunny and Clear", EnvironmentType.Weather
				, "Sneak checks in Arkham are made at a -1 penalty. Pass:  Fail: "
				, Cave.Instance, Roadhouse.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Headline("Temperence Fever Sweeps City"
				, "Any investigator with Whiskey must pass a Sneak (-1) check or get arrested and taken to the Police Station. If this occurs, they must discard their Whiskey. In addition, Hibb's Roadhouse is closed until the end of next turn. Leave this card in play until then to indicate this Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Hexagon}, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}));
			list.Add(new Headline("Terror at the Train Station!"
				, "A rusty train arrives in Arkham, disgorging 2 monsters into the Northside streets Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
			list.Add(new Environment("The Chill of the Grave", EnvironmentType.Mystic
				, "All Undead monsters have their toughness increased by 1 Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Environment("The Festival", EnvironmentType.Urban
				, "The festival has begun! Cultists and Byakhees have their toughness increased by 1. Pass:  Fail: "
				, Woods.Instance, Woods.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Rumor("The Great Ritual"
				, "Ongoing Effect: Cultists, Witches, Warlocks, and High Priests have their toughness increased by 2 while this card is in play. Place 1 clue token on this card at the end of every Mythos Phase (beginning the turn after it entered play) Pass: If a single player discards 3 spells (4 if there are 5 or more players) while in the French Hill streets during the Arkham Encounters phase, return this card to the box. Each player gains 2 clue tokens. Fail: If there are ever 5 Clue tokens on this card, return it to the box. From now on, draw 2 Mythos cards each Mythos Phase. Ignore everything on the first card except for the gate opening."
				, Graveyard.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Environment("The Man in Black", EnvironmentType.Mystic
				, "Investigators who end their movement in the French Hill streets may deal with the Man in Black to gain power. They roll dice equal to their current Sanity and for every failed die, the lose 1 Sanity. If this reduces them to 0 Sanity, they are devouredand the player must start a new character. Otherwise, they gain 1 Clue token and draw 1 Spell. Pass:  Fail: "
				, WitchHouse.Instance, Cave.Instance
				, new Shape[]{Shape.Plus}, new Shape[]{Shape.Crescent}));
			list.Add(new Rumor("The Southside Strangler Strikes"
				, "Ongoing Effect: Return one Ally from the Ally deck to the box at random at the end of every Mythos Phase while this card is in play (beginning the turn after it entered play). The Southside Strangler has struck again! Pass: If a single player discards 5 Clue tokens while in Ma's Boarding House during the Arkham Encounters Phase, return this card to the box. Each player receives a $5 reward from the police Fail: If there are no more Allies to return to the box at the end of the Mythos Phase, return this card to the box. Each player must lower either their maximum Sanity or Stamina (their choice) by 1 for the rest of the game"
				, IndependenceSq.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Rumor("The Stars Are Right"
				, "Ongoing Effect: Roll a die at the end of every Mythos Phase while this card is in play (beginning the turn after it enters play). On a 1 or 2, place one doom token on the ancient one's doom track. Pass: If a player discards an Ally card while in the Downtown streets during the Arkham Encounter Phase, return this card to the box. Each player draws 2 Common Items. Fail: If the Ancient One awakens, return this card to the box"
				, ScienceBuilding.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Headline("The Story Continues?"
				, "Shuffle the mythos deck, being sure to include this card in it. After the deck is shuffled, draw a new mythos card for the turn Pass:  Fail: "
				, null, null
				, new Shape[]{}, new Shape[]{}));
			list.Add(new Rumor("The Terrible Experiment"
				, "When this card enters play, place 5 monsters from the cup on it. Any player may choose to fight one or more of these monsters while in the Miskatonic U. streets during the Arkham Encounter Phase. If defeated, they are claimed as monster trophies. These monsters do not move, are not considered on the board, and do not count against the monster limit. Pass: If there are no monsters on this card, return it to the box. Each player draws 1 Skill. Fail: If there are 8 monsters on this card, return it to the box. Raise the terror level to 10 and place the monsters that were on it in play in the Miskatonic U. streets"
				, UnvisitedIsle.Instance, null
				, new Shape[]{Shape.Diagonal, Shape.Triangle, Shape.Star}, new Shape[]{Shape.Hexagon}));
			list.Add(new Environment("Things of Darkness", EnvironmentType.Mystic
				, "Ghouls, Formless Spawns, Shoggoths and Flying Polyps have their toughness increased by 1 Pass:  Fail: "
				, Lodge.Instance, Graveyard.Instance
				, new Shape[]{Shape.Diamond, Shape.Square}, new Shape[]{Shape.Circle}));
			list.Add(new Headline("Vigilante Guards the Night!"
				, "All monsters in the Downtown streets or locations are returned to the cup Pass:  Fail: "
				, Unnamable.Instance, Woods.Instance
				, new Shape[]{Shape.Circle}, new Shape[]{Shape.Diamond, Shape.Square}));
			list.Add(new Headline("Witch Burning Anniversary!"
				, "An ancient curse strikes Arkham, releasing 2 monsters into the Rivertown streets Pass:  Fail: "
				, UnvisitedIsle.Instance, ScienceBuilding.Instance
				, new Shape[]{Shape.Crescent}, new Shape[]{Shape.Plus}));
		}
	}
}